using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MUCOBADI.Emailhelper;
using MUCOBADI.Models;
using MUCOBADI.Repository.TrackingTools;
using Quartz;
using Syncfusion.Blazor.Data;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MUCOBADI.ScheduleTask
{
    public class SystemNotificationSchedule : IJob
    {
        //ViralloadTrackerModel viralloadTrackerModel = new ViralloadTrackerModel();
        EmailSender email = new EmailSender();
        private SPToCoreContext db;
        public Task Execute(IJobExecutionContext context)
        {
            var serviceScope = ServiceActivator.GetScope();
            db = (SPToCoreContext)serviceScope.ServiceProvider.GetService(typeof(SPToCoreContext));
            LoadData();
            return Task.CompletedTask;
        }
        private async void LoadData()
        {
            //viralloadTrackerModel.ForwardValidViralload();
            await GetNotVisitedMembers();
            await GetMembersDueForVlAppointment();
            await GetMembersMissedVlAppointment();
            await GetNonsuppressing();
        }
        private async Task GetNotVisitedMembers()
        {
            try
            {
                DateTime CurrentDate = DateTime.Now;
                DateTime? StartDate = null;
                DateTime? EndDate = null;

                if(CurrentDate.Month >= 10 &&  CurrentDate.Month <= 12)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 10, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 12, DateTime.DaysInMonth(DateTime.Now.Year, 12));
                }
                else if (CurrentDate.Month >= 1 && CurrentDate.Month <= 3)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 1, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 3, DateTime.DaysInMonth(DateTime.Now.Year, 3));
                }
                else if (CurrentDate.Month >= 4 && CurrentDate.Month <= 6)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 4, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 6, DateTime.DaysInMonth(DateTime.Now.Year, 6));
                }
                else if (CurrentDate.Month >= 7 && CurrentDate.Month <= 9)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 7, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 9, DateTime.DaysInMonth(DateTime.Now.Year, 9));
                }

                var data = await db.spSystemalertsGetAllAsync(StartDate, EndDate, 1);
                if (data != null && data.Count > 0)
                {
                    using (ExcelEngine excelEngine = new ExcelEngine())
                    {
                        IApplication application = excelEngine.Excel;
                        application.DefaultVersion = ExcelVersion.Excel2013;
                        IWorkbook workbook = application.Workbooks.Create(1);
                        IWorksheet worksheet = workbook.Worksheets[0];
                        worksheet.Name = "Missed service Or Household visit";

                        #region Styles
                        var headerStyle = workbook.Styles.Add("headerStyle");

                        headerStyle.BeginUpdate();
                        headerStyle.Color = Syncfusion.Drawing.Color.Black; //Syncfusion.Drawing.Color.FromArgb(255, 0, 0);
                        headerStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        headerStyle.Font.Bold = true;
                        headerStyle.Font.FontName = "Arial";
                        headerStyle.Font.Size = 8f;
                        headerStyle.Font.Color = ExcelKnownColors.White;

                        headerStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        headerStyle.Borders.Color = ExcelKnownColors.White;
                        headerStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        headerStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        headerStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        //headerStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thick;

                        headerStyle.WrapText = true;

                        headerStyle.EndUpdate();

                        var Style = workbook.Styles.Add("bodyStyle");

                        Style.BeginUpdate();
                        Style.HorizontalAlignment = ExcelHAlign.HAlignLeft;
                        Style.VerticalAlignment = ExcelVAlign.VAlignTop;
                        Style.Font.Bold = false;
                        Style.Font.FontName = "Arial";
                        Style.Font.Size = 8f;
                        Style.Font.Color = ExcelKnownColors.Black;
                        Style.WrapText = true;
                        Style.Borders.Color = ExcelKnownColors.Black;
                        Style.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        Style.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        Style.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        Style.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        Style.EndUpdate();


                        var CategoryStyle = workbook.Styles.Add("CategoryStyle");

                        CategoryStyle.BeginUpdate();
                        CategoryStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        CategoryStyle.Color = Syncfusion.Drawing.Color.FromArgb(255, 195, 0);
                        /*CategoryStyle.Color = Syncfusion.Drawing.Color.FromArgb(105, 59, 88);*/ //AUBERGINE
                        CategoryStyle.Font.Bold = true;
                        CategoryStyle.Font.FontName = "Arial";
                        CategoryStyle.Font.Size = 10f;
                        CategoryStyle.Font.Color = ExcelKnownColors.White;
                        CategoryStyle.WrapText = true;
                        CategoryStyle.Borders.Color = ExcelKnownColors.White;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.EndUpdate();

                        var CategoryTotalStyle = workbook.Styles.Add("CategoryTotalStyle");

                        CategoryTotalStyle.BeginUpdate();
                        CategoryTotalStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        CategoryTotalStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        CategoryTotalStyle.Color = Syncfusion.Drawing.Color.Black;
                        CategoryTotalStyle.Font.Bold = true;
                        CategoryTotalStyle.Font.FontName = "Arial";
                        CategoryTotalStyle.Font.Size = 8f;
                        CategoryTotalStyle.Font.Color = ExcelKnownColors.White;
                        CategoryTotalStyle.WrapText = true;
                        CategoryTotalStyle.Borders.Color = ExcelKnownColors.White;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.EndUpdate();

                        var DivisionStyle = workbook.Styles.Add("DivisionStyle");

                        DivisionStyle.BeginUpdate();
                        DivisionStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        DivisionStyle.Color = Syncfusion.Drawing.Color.FromArgb(255, 0, 0); //RED
                        DivisionStyle.Font.Bold = true;
                        DivisionStyle.Font.FontName = "Arial";
                        DivisionStyle.Font.Size = 8f;
                        DivisionStyle.Font.Color = ExcelKnownColors.White;
                        DivisionStyle.WrapText = true;
                        DivisionStyle.Borders.Color = ExcelKnownColors.White;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.EndUpdate();

                        var DivisionTotalStyle = workbook.Styles.Add("DivisionTotalStyle");

                        DivisionTotalStyle.BeginUpdate();
                        DivisionTotalStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        DivisionTotalStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        DivisionTotalStyle.Color = Syncfusion.Drawing.Color.Black;
                        DivisionTotalStyle.Font.Bold = true;
                        DivisionTotalStyle.Font.FontName = "Arial";
                        DivisionTotalStyle.Font.Size = 8f;
                        DivisionTotalStyle.Font.Color = ExcelKnownColors.White;
                        DivisionTotalStyle.WrapText = true;
                        DivisionTotalStyle.Borders.Color = ExcelKnownColors.White;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.EndUpdate();


                        var TopicStyle = workbook.Styles.Add("TopicStyle");

                        TopicStyle.BeginUpdate();
                        TopicStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        TopicStyle.Color = Syncfusion.Drawing.Color.FromArgb(105, 59, 88); //AUBERGINE
                        TopicStyle.Font.Bold = true;
                        TopicStyle.Font.FontName = "Arial";
                        TopicStyle.Font.Size = 8f;
                        TopicStyle.Font.Color = ExcelKnownColors.White;
                        TopicStyle.WrapText = true;
                        TopicStyle.Borders.Color = ExcelKnownColors.White;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.EndUpdate();

                        var TopicTotalStyle = workbook.Styles.Add("TopicTotalStyle");

                        TopicTotalStyle.BeginUpdate();
                        TopicTotalStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        TopicTotalStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        TopicTotalStyle.Color = Syncfusion.Drawing.Color.Black;
                        TopicTotalStyle.Font.Bold = true;
                        TopicTotalStyle.Font.FontName = "Arial";
                        TopicTotalStyle.Font.Size = 8f;
                        TopicTotalStyle.Font.Color = ExcelKnownColors.White;
                        TopicTotalStyle.WrapText = true;
                        TopicTotalStyle.Borders.Color = ExcelKnownColors.White;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.EndUpdate();
                        #endregion

                        int row = 1;

                        #region Header row
                        worksheet.Range["A" + row].Text = "HH UiD";
                        worksheet.Range["A" + row].ColumnWidth = 15;

                        worksheet.Range["B" + row].Text = "District";
                        worksheet.Range["B" + row].ColumnWidth = 20;

                        worksheet.Range["C" + row].Text = "Sub county";
                        worksheet.Range["C" + row].ColumnWidth = 20;

                        worksheet.Range["D" + row].Text = "Parish";
                        worksheet.Range["D" + row].ColumnWidth = 20;

                        worksheet.Range["E" + row].Text = "Village";
                        worksheet.Range["E" + row].ColumnWidth = 20;

                        worksheet.Range["F" + row].Text = "Individual UiD";
                        worksheet.Range["F" + row].ColumnWidth = 15;

                        worksheet.Range["G" + row].Text = "Name of HH member";
                        worksheet.Range["G" + row].ColumnWidth = 20;

                        worksheet.Range["H" + row].Text = "Sex";
                        worksheet.Range["H" + row].ColumnWidth = 10;

                        worksheet.Range["I" + row].Text = "Date of birth";
                        worksheet.Range["I" + row].ColumnWidth = 13;

                        worksheet.Range["J" + row].Text = "Age";
                        worksheet.Range["J" + row].ColumnWidth = 10;

                        worksheet.Range["K" + row].Text = "Known Risk Factor";
                        worksheet.Range["K" + row].ColumnWidth = 15;

                        worksheet.Range["L" + row].Text = "Program Participation";
                        worksheet.Range["L" + row].ColumnWidth = 15;

                        worksheet.Range["M" + row].Text = "Facility";
                        worksheet.Range["M" + row].ColumnWidth = 15;

                        worksheet.Range["N" + row].Text = "ART Number";
                        worksheet.Range["N" + row].ColumnWidth = 15;

                        worksheet.Range["A" + row + ":N" + row].CellStyle = headerStyle;
                        #endregion Header row

                        row++;

                        foreach (var item in data)
                        {
                            worksheet.Range["A" + row].Text = item.HouseHoldMemberCode.Substring(0,10);

                            worksheet.Range["B" + row].Text = item.DistrictDescription;

                            worksheet.Range["C" + row].Text = item.SubcountyDescription;

                            worksheet.Range["D" + row].Text = item.ParishDescription;

                            worksheet.Range["E" + row].Text = item.VillageDescription;

                            worksheet.Range["F" + row].Text = item.HouseHoldMemberCode;

                            worksheet.Range["G" + row].Text = $"{item.Surname} {item.Givenname}";

                            worksheet.Range["H" + row].Text = item.GenderId;
                            if (item.DoB.HasValue)
                            {
                                worksheet.Range["I" + row].Text = item.DoB.Value.ToString("dd/MM/yyyy");
                            }
                            if (item.Age.HasValue)
                            {
                                worksheet.Range["J" + row].Number = item.Age.Value;
                            }
                            worksheet.Range["K" + row].Text = item.KnownRiskFactorDescription;

                            worksheet.Range["L" + row].Text = item.ProgramParticipationDescription;

                            worksheet.Range["M" + row].Text = item.FacilityName;

                            worksheet.Range["N" + row].Text = item.ArtNumber;

                            worksheet.Range["A" + row + ":N" + row].CellStyle = Style;

                            row++;
                        }

                        MemoryStream ms = new MemoryStream();
                        // Save and close the document.
                        workbook.SaveAs(ms);
                        //Reset the memory stream position.
                        ms.Position = 0;


                        string subject = "Missed service Or Household visit";
                        string message = $"<p>Dear all,</p> <p>Please find attached the list of all household members who have missed a service or are not yet visited</p>" +
                            $"<p>Regards</p> <p>System notification,</p><p>{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}</p>";
                        List<string> EmailList = new List<string>();
                      //  EmailList.Add("wokwerahenry@gmail.com");
                        var contacts = await db.AContacts
                        .Where(o=> o.PositionId == 2 || o.PositionId==3 ||  o.PositionId==9 || o.PositionId == 4 || o.PositionId == 1 
                        || o.PositionId == 10 || o.PositionId == 24 || o.PositionId == 25 || o.PositionId == 5 || 
                        o.PositionId == 32 || o.PositionId == 33).ToListAsync();
                        if(contacts != null && contacts.Count>0)
                        {
                            foreach (var contact in contacts)
                            {
                                if (!string.IsNullOrEmpty(contact.ContactEmail))
                                {
                                    EmailList.Add(contact.ContactEmail);
                                }
                            }
                        }
                        //Attachment file = new Attachment(ms, "Invoice.pdf", "application/pdf");
                        Attachment mailattachment = new Attachment(ms, "Missed service Or Household visit.xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

                        if(EmailList.Count > 0)
                        {
                            await email.sendMessage(EmailList[0], subject, message, mailattachment, EmailList);
                        }

                        ms.Dispose();
                        workbook.Close();
                    }
                }
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        private async Task GetMembersDueForVlAppointment()
        {
            try
            {
                DateTime CurrentDate = DateTime.Now;
                DateTime? StartDate = null;
                DateTime? EndDate = null;

                if (CurrentDate.Month >= 10 && CurrentDate.Month <= 12)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 10, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 12, DateTime.DaysInMonth(DateTime.Now.Year, 12));
                }
                else if (CurrentDate.Month >= 1 && CurrentDate.Month <= 3)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 1, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 3, DateTime.DaysInMonth(DateTime.Now.Year, 3));
                }
                else if (CurrentDate.Month >= 4 && CurrentDate.Month <= 6)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 4, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 6, DateTime.DaysInMonth(DateTime.Now.Year, 6));
                }
                else if (CurrentDate.Month >= 7 && CurrentDate.Month <= 9)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 7, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 9, DateTime.DaysInMonth(DateTime.Now.Year, 9));
                }

                var data = await db.spSystemalertsGetAllAsync(StartDate, EndDate, 2);
                if (data != null && data.Count > 0)
                {
                    using (ExcelEngine excelEngine = new ExcelEngine())
                    {
                        IApplication application = excelEngine.Excel;
                        application.DefaultVersion = ExcelVersion.Excel2013;
                        IWorkbook workbook = application.Workbooks.Create(1);
                        IWorksheet worksheet = workbook.Worksheets[0];
                        worksheet.Name = "Household members due for Vl Appointment";

                        #region Styles
                        var headerStyle = workbook.Styles.Add("headerStyle");

                        headerStyle.BeginUpdate();
                        headerStyle.Color = Syncfusion.Drawing.Color.Black; //Syncfusion.Drawing.Color.FromArgb(255, 0, 0);
                        headerStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        headerStyle.Font.Bold = true;
                        headerStyle.Font.FontName = "Arial";
                        headerStyle.Font.Size = 8f;
                        headerStyle.Font.Color = ExcelKnownColors.White;

                        headerStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        headerStyle.Borders.Color = ExcelKnownColors.White;
                        headerStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        headerStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        headerStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        //headerStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thick;

                        headerStyle.WrapText = true;

                        headerStyle.EndUpdate();

                        var Style = workbook.Styles.Add("bodyStyle");

                        Style.BeginUpdate();
                        Style.HorizontalAlignment = ExcelHAlign.HAlignLeft;
                        Style.VerticalAlignment = ExcelVAlign.VAlignTop;
                        Style.Font.Bold = false;
                        Style.Font.FontName = "Arial";
                        Style.Font.Size = 8f;
                        Style.Font.Color = ExcelKnownColors.Black;
                        Style.WrapText = true;
                        Style.Borders.Color = ExcelKnownColors.Black;
                        Style.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        Style.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        Style.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        Style.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        Style.EndUpdate();


                        var CategoryStyle = workbook.Styles.Add("CategoryStyle");

                        CategoryStyle.BeginUpdate();
                        CategoryStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        CategoryStyle.Color = Syncfusion.Drawing.Color.FromArgb(255, 195, 0);
                        /*CategoryStyle.Color = Syncfusion.Drawing.Color.FromArgb(105, 59, 88);*/ //AUBERGINE
                        CategoryStyle.Font.Bold = true;
                        CategoryStyle.Font.FontName = "Arial";
                        CategoryStyle.Font.Size = 10f;
                        CategoryStyle.Font.Color = ExcelKnownColors.White;
                        CategoryStyle.WrapText = true;
                        CategoryStyle.Borders.Color = ExcelKnownColors.White;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.EndUpdate();

                        var CategoryTotalStyle = workbook.Styles.Add("CategoryTotalStyle");

                        CategoryTotalStyle.BeginUpdate();
                        CategoryTotalStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        CategoryTotalStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        CategoryTotalStyle.Color = Syncfusion.Drawing.Color.Black;
                        CategoryTotalStyle.Font.Bold = true;
                        CategoryTotalStyle.Font.FontName = "Arial";
                        CategoryTotalStyle.Font.Size = 8f;
                        CategoryTotalStyle.Font.Color = ExcelKnownColors.White;
                        CategoryTotalStyle.WrapText = true;
                        CategoryTotalStyle.Borders.Color = ExcelKnownColors.White;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.EndUpdate();

                        var DivisionStyle = workbook.Styles.Add("DivisionStyle");

                        DivisionStyle.BeginUpdate();
                        DivisionStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        DivisionStyle.Color = Syncfusion.Drawing.Color.FromArgb(255, 0, 0); //RED
                        DivisionStyle.Font.Bold = true;
                        DivisionStyle.Font.FontName = "Arial";
                        DivisionStyle.Font.Size = 8f;
                        DivisionStyle.Font.Color = ExcelKnownColors.White;
                        DivisionStyle.WrapText = true;
                        DivisionStyle.Borders.Color = ExcelKnownColors.White;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.EndUpdate();

                        var DivisionTotalStyle = workbook.Styles.Add("DivisionTotalStyle");

                        DivisionTotalStyle.BeginUpdate();
                        DivisionTotalStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        DivisionTotalStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        DivisionTotalStyle.Color = Syncfusion.Drawing.Color.Black;
                        DivisionTotalStyle.Font.Bold = true;
                        DivisionTotalStyle.Font.FontName = "Arial";
                        DivisionTotalStyle.Font.Size = 8f;
                        DivisionTotalStyle.Font.Color = ExcelKnownColors.White;
                        DivisionTotalStyle.WrapText = true;
                        DivisionTotalStyle.Borders.Color = ExcelKnownColors.White;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.EndUpdate();


                        var TopicStyle = workbook.Styles.Add("TopicStyle");

                        TopicStyle.BeginUpdate();
                        TopicStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        TopicStyle.Color = Syncfusion.Drawing.Color.FromArgb(105, 59, 88); //AUBERGINE
                        TopicStyle.Font.Bold = true;
                        TopicStyle.Font.FontName = "Arial";
                        TopicStyle.Font.Size = 8f;
                        TopicStyle.Font.Color = ExcelKnownColors.White;
                        TopicStyle.WrapText = true;
                        TopicStyle.Borders.Color = ExcelKnownColors.White;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.EndUpdate();

                        var TopicTotalStyle = workbook.Styles.Add("TopicTotalStyle");

                        TopicTotalStyle.BeginUpdate();
                        TopicTotalStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        TopicTotalStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        TopicTotalStyle.Color = Syncfusion.Drawing.Color.Black;
                        TopicTotalStyle.Font.Bold = true;
                        TopicTotalStyle.Font.FontName = "Arial";
                        TopicTotalStyle.Font.Size = 8f;
                        TopicTotalStyle.Font.Color = ExcelKnownColors.White;
                        TopicTotalStyle.WrapText = true;
                        TopicTotalStyle.Borders.Color = ExcelKnownColors.White;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.EndUpdate();
                        #endregion

                        int row = 1;

                        #region Header row
                        worksheet.Range["A" + row].Text = "HH UiD";
                        worksheet.Range["A" + row].ColumnWidth = 15;

                        worksheet.Range["B" + row].Text = "District";
                        worksheet.Range["B" + row].ColumnWidth = 20;

                        worksheet.Range["C" + row].Text = "Sub county";
                        worksheet.Range["C" + row].ColumnWidth = 20;

                        worksheet.Range["D" + row].Text = "Parish";
                        worksheet.Range["D" + row].ColumnWidth = 20;

                        worksheet.Range["E" + row].Text = "Village";
                        worksheet.Range["E" + row].ColumnWidth = 20;

                        worksheet.Range["F" + row].Text = "Individual UiD";
                        worksheet.Range["F" + row].ColumnWidth = 15;

                        worksheet.Range["G" + row].Text = "Name of HH member";
                        worksheet.Range["G" + row].ColumnWidth = 20;

                        worksheet.Range["H" + row].Text = "Sex";
                        worksheet.Range["H" + row].ColumnWidth = 10;

                        worksheet.Range["I" + row].Text = "Date of birth";
                        worksheet.Range["I" + row].ColumnWidth = 13;

                        worksheet.Range["J" + row].Text = "Age";
                        worksheet.Range["J" + row].ColumnWidth = 10;

                        worksheet.Range["K" + row].Text = "Known Risk Factor";
                        worksheet.Range["K" + row].ColumnWidth = 15;

                        worksheet.Range["L" + row].Text = "Program Participation";
                        worksheet.Range["L" + row].ColumnWidth = 15;

                        worksheet.Range["M" + row].Text = "Appointment Date";
                        worksheet.Range["M" + row].ColumnWidth = 15;

                        worksheet.Range["N" + row].Text = "ART Number";
                        worksheet.Range["N" + row].ColumnWidth = 15;

                        worksheet.Range["O" + row].Text = "Facility";
                        worksheet.Range["O" + row].ColumnWidth = 15;

                        worksheet.Range["A" + row + ":O" + row].CellStyle = headerStyle;
                        #endregion Header row

                        row++;

                        foreach (var item in data)
                        {
                            worksheet.Range["A" + row].Text = item.HouseHoldMemberCode.Substring(0, 10);

                            worksheet.Range["B" + row].Text = item.DistrictDescription;

                            worksheet.Range["C" + row].Text = item.SubcountyDescription;

                            worksheet.Range["D" + row].Text = item.ParishDescription;

                            worksheet.Range["E" + row].Text = item.VillageDescription;

                            worksheet.Range["F" + row].Text = item.HouseHoldMemberCode;

                            worksheet.Range["G" + row].Text = $"{item.Surname} {item.Givenname}";

                            worksheet.Range["H" + row].Text = item.GenderId;
                            if (item.DoB.HasValue)
                            {
                                worksheet.Range["I" + row].Text = item.DoB.Value.ToString("dd/MM/yyyy");
                            }
                            if (item.Age.HasValue)
                            {
                                worksheet.Range["J" + row].Number = item.Age.Value;
                            }
                            worksheet.Range["K" + row].Text = item.KnownRiskFactorDescription;
                            worksheet.Range["L" + row].Text = item.ProgramParticipationDescription;
                            if (item.DoB.HasValue)
                            {
                                worksheet.Range["M" + row].Text = item.NextAppointmentDate.Value.ToString("dd/MM/yyyy");
                            }
                            worksheet.Range["N" + row].Text = item.ArtNumber;
                            worksheet.Range["O" + row].Text = item.FacilityName;
                            worksheet.Range["A" + row + ":O" + row].CellStyle = Style;

                            row++;
                        }

                        MemoryStream ms = new MemoryStream();
                        // Save and close the document.
                        workbook.SaveAs(ms);
                        //Reset the memory stream position.
                        ms.Position = 0;


                        string subject = "Household members due for Vl Appointment";
                        string message = $"<p>Dear all,</p> <p>Please find attached the list of all household members that are due for Viralload appointment</p>" +
                            
                            $"<p>Regards</p> <p>System notification,</p><p>{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}</p>";
                        List<string> EmailList = new List<string>();
                       // EmailList.Add("wokwerahenry@gmail.com");
                        var contacts = await db.AContacts
                       .Where(o => o.PositionId == 2 || o.PositionId == 3 || o.PositionId == 9 || o.PositionId == 4 || o.PositionId == 1 
                       || o.PositionId == 10 || o.PositionId == 24 || o.PositionId == 25 || o.PositionId == 5 ||
                       o.PositionId == 32 || o.PositionId == 33).ToListAsync();
                        if (contacts != null && contacts.Count > 0)
                        {
                            foreach (var contact in contacts)
                            {
                                if (!string.IsNullOrEmpty(contact.ContactEmail))
                                {
                                    EmailList.Add(contact.ContactEmail);
                                }
                            }
                        }
                        //Attachment file = new Attachment(ms, "Invoice.pdf", "application/pdf");
                        Attachment mailattachment = new Attachment(ms, "Household members due for Vl Appointment.xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

                        if (EmailList.Count > 0)
                        {
                            await email.sendMessage(EmailList[0], subject, message, mailattachment, EmailList);
                        }

                        ms.Dispose();
                        workbook.Close();
                    }
                }
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        private async Task GetMembersMissedVlAppointment()
        {
            try
            {
                DateTime CurrentDate = DateTime.Now;
                DateTime? StartDate = null;
                DateTime? EndDate = null;

                if (CurrentDate.Month >= 10 && CurrentDate.Month <= 12)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 10, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 12, DateTime.DaysInMonth(DateTime.Now.Year, 12));
                }
                else if (CurrentDate.Month >= 1 && CurrentDate.Month <= 3)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 1, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 3, DateTime.DaysInMonth(DateTime.Now.Year, 3));
                }
                else if (CurrentDate.Month >= 4 && CurrentDate.Month <= 6)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 4, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 6, DateTime.DaysInMonth(DateTime.Now.Year, 6));
                }
                else if (CurrentDate.Month >= 7 && CurrentDate.Month <= 9)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 7, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 9, DateTime.DaysInMonth(DateTime.Now.Year, 9));
                }

                var data = await db.spSystemalertsGetAllAsync(StartDate, EndDate, 3);
                if (data != null && data.Count > 0)
                {
                    using (ExcelEngine excelEngine = new ExcelEngine())
                    {
                        IApplication application = excelEngine.Excel;
                        application.DefaultVersion = ExcelVersion.Excel2013;
                        IWorkbook workbook = application.Workbooks.Create(1);
                        IWorksheet worksheet = workbook.Worksheets[0];
                        worksheet.Name = "Household members that missed their Vl Appointment";

                        #region Styles
                        var headerStyle = workbook.Styles.Add("headerStyle");

                        headerStyle.BeginUpdate();
                        headerStyle.Color = Syncfusion.Drawing.Color.Black; //Syncfusion.Drawing.Color.FromArgb(255, 0, 0);
                        headerStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        headerStyle.Font.Bold = true;
                        headerStyle.Font.FontName = "Arial";
                        headerStyle.Font.Size = 8f;
                        headerStyle.Font.Color = ExcelKnownColors.White;

                        headerStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        headerStyle.Borders.Color = ExcelKnownColors.White;
                        headerStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        headerStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        headerStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        //headerStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thick;

                        headerStyle.WrapText = true;

                        headerStyle.EndUpdate();

                        var Style = workbook.Styles.Add("bodyStyle");

                        Style.BeginUpdate();
                        Style.HorizontalAlignment = ExcelHAlign.HAlignLeft;
                        Style.VerticalAlignment = ExcelVAlign.VAlignTop;
                        Style.Font.Bold = false;
                        Style.Font.FontName = "Arial";
                        Style.Font.Size = 8f;
                        Style.Font.Color = ExcelKnownColors.Black;
                        Style.WrapText = true;
                        Style.Borders.Color = ExcelKnownColors.Black;
                        Style.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        Style.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        Style.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        Style.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        Style.EndUpdate();


                        var CategoryStyle = workbook.Styles.Add("CategoryStyle");

                        CategoryStyle.BeginUpdate();
                        CategoryStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        CategoryStyle.Color = Syncfusion.Drawing.Color.FromArgb(255, 195, 0);
                        /*CategoryStyle.Color = Syncfusion.Drawing.Color.FromArgb(105, 59, 88);*/ //AUBERGINE
                        CategoryStyle.Font.Bold = true;
                        CategoryStyle.Font.FontName = "Arial";
                        CategoryStyle.Font.Size = 10f;
                        CategoryStyle.Font.Color = ExcelKnownColors.White;
                        CategoryStyle.WrapText = true;
                        CategoryStyle.Borders.Color = ExcelKnownColors.White;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.EndUpdate();

                        var CategoryTotalStyle = workbook.Styles.Add("CategoryTotalStyle");

                        CategoryTotalStyle.BeginUpdate();
                        CategoryTotalStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        CategoryTotalStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        CategoryTotalStyle.Color = Syncfusion.Drawing.Color.Black;
                        CategoryTotalStyle.Font.Bold = true;
                        CategoryTotalStyle.Font.FontName = "Arial";
                        CategoryTotalStyle.Font.Size = 8f;
                        CategoryTotalStyle.Font.Color = ExcelKnownColors.White;
                        CategoryTotalStyle.WrapText = true;
                        CategoryTotalStyle.Borders.Color = ExcelKnownColors.White;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.EndUpdate();

                        var DivisionStyle = workbook.Styles.Add("DivisionStyle");

                        DivisionStyle.BeginUpdate();
                        DivisionStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        DivisionStyle.Color = Syncfusion.Drawing.Color.FromArgb(255, 0, 0); //RED
                        DivisionStyle.Font.Bold = true;
                        DivisionStyle.Font.FontName = "Arial";
                        DivisionStyle.Font.Size = 8f;
                        DivisionStyle.Font.Color = ExcelKnownColors.White;
                        DivisionStyle.WrapText = true;
                        DivisionStyle.Borders.Color = ExcelKnownColors.White;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.EndUpdate();

                        var DivisionTotalStyle = workbook.Styles.Add("DivisionTotalStyle");

                        DivisionTotalStyle.BeginUpdate();
                        DivisionTotalStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        DivisionTotalStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        DivisionTotalStyle.Color = Syncfusion.Drawing.Color.Black;
                        DivisionTotalStyle.Font.Bold = true;
                        DivisionTotalStyle.Font.FontName = "Arial";
                        DivisionTotalStyle.Font.Size = 8f;
                        DivisionTotalStyle.Font.Color = ExcelKnownColors.White;
                        DivisionTotalStyle.WrapText = true;
                        DivisionTotalStyle.Borders.Color = ExcelKnownColors.White;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.EndUpdate();


                        var TopicStyle = workbook.Styles.Add("TopicStyle");

                        TopicStyle.BeginUpdate();
                        TopicStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        TopicStyle.Color = Syncfusion.Drawing.Color.FromArgb(105, 59, 88); //AUBERGINE
                        TopicStyle.Font.Bold = true;
                        TopicStyle.Font.FontName = "Arial";
                        TopicStyle.Font.Size = 8f;
                        TopicStyle.Font.Color = ExcelKnownColors.White;
                        TopicStyle.WrapText = true;
                        TopicStyle.Borders.Color = ExcelKnownColors.White;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.EndUpdate();

                        var TopicTotalStyle = workbook.Styles.Add("TopicTotalStyle");

                        TopicTotalStyle.BeginUpdate();
                        TopicTotalStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        TopicTotalStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        TopicTotalStyle.Color = Syncfusion.Drawing.Color.Black;
                        TopicTotalStyle.Font.Bold = true;
                        TopicTotalStyle.Font.FontName = "Arial";
                        TopicTotalStyle.Font.Size = 8f;
                        TopicTotalStyle.Font.Color = ExcelKnownColors.White;
                        TopicTotalStyle.WrapText = true;
                        TopicTotalStyle.Borders.Color = ExcelKnownColors.White;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.EndUpdate();
                        #endregion

                        int row = 1;

                        #region Header row
                        worksheet.Range["A" + row].Text = "HH UiD";
                        worksheet.Range["A" + row].ColumnWidth = 15;

                        worksheet.Range["B" + row].Text = "District";
                        worksheet.Range["B" + row].ColumnWidth = 20;

                        worksheet.Range["C" + row].Text = "Sub county";
                        worksheet.Range["C" + row].ColumnWidth = 20;

                        worksheet.Range["D" + row].Text = "Parish";
                        worksheet.Range["D" + row].ColumnWidth = 20;

                        worksheet.Range["E" + row].Text = "Village";
                        worksheet.Range["E" + row].ColumnWidth = 20;

                        worksheet.Range["F" + row].Text = "Individual UiD";
                        worksheet.Range["F" + row].ColumnWidth = 15;

                        worksheet.Range["G" + row].Text = "Name of HH member";
                        worksheet.Range["G" + row].ColumnWidth = 20;

                        worksheet.Range["H" + row].Text = "Sex";
                        worksheet.Range["H" + row].ColumnWidth = 10;

                        worksheet.Range["I" + row].Text = "Date of birth";
                        worksheet.Range["I" + row].ColumnWidth = 13;

                        worksheet.Range["J" + row].Text = "Age";
                        worksheet.Range["J" + row].ColumnWidth = 10;

                        worksheet.Range["K" + row].Text = "Known Risk Factor";
                        worksheet.Range["K" + row].ColumnWidth = 15;

                        worksheet.Range["L" + row].Text = "Program Participation";
                        worksheet.Range["L" + row].ColumnWidth = 15;
                        worksheet.Range["M" + row].Text = "Appointment Date";
                        worksheet.Range["M" + row].ColumnWidth = 15;
                        worksheet.Range["N" + row].Text = "ART Number";
                        worksheet.Range["N" + row].ColumnWidth = 15;

                        worksheet.Range["O" + row].Text = "Facility";
                        worksheet.Range["O" + row].ColumnWidth = 15;
                        worksheet.Range["A" + row + ":0" + row].CellStyle = headerStyle;
                        #endregion Header row

                        row++;

                        foreach (var item in data)
                        {
                            worksheet.Range["A" + row].Text = item.HouseHoldMemberCode.Substring(0, 10);

                            worksheet.Range["B" + row].Text = item.DistrictDescription;

                            worksheet.Range["C" + row].Text = item.SubcountyDescription;

                            worksheet.Range["D" + row].Text = item.ParishDescription;

                            worksheet.Range["E" + row].Text = item.VillageDescription;

                            worksheet.Range["F" + row].Text = item.HouseHoldMemberCode;

                            worksheet.Range["G" + row].Text = $"{item.Surname} {item.Givenname}";

                            worksheet.Range["H" + row].Text = item.GenderId;
                            if (item.DoB.HasValue)
                            {
                                worksheet.Range["I" + row].Text = item.DoB.Value.ToString("dd/MM/yyyy");
                            }
                            if (item.Age.HasValue)
                            {
                                worksheet.Range["J" + row].Number = item.Age.Value;
                            }
                            worksheet.Range["K" + row].Text = item.KnownRiskFactorDescription;
                            worksheet.Range["L" + row].Text = item.ProgramParticipationDescription;
                            if (item.NextAppointmentDate.HasValue)
                            {
                                worksheet.Range["M" + row].Text = item.NextAppointmentDate.Value.ToString("dd/MM/yyyy");
                            }
                            worksheet.Range["N" + row].Text = item.ArtNumber;
                            worksheet.Range["O" + row].Text = item.FacilityName;
                            worksheet.Range["A" + row + ":O" + row].CellStyle = Style;

                            row++;
                        }

                        MemoryStream ms = new MemoryStream();
                        // Save and close the document.
                        workbook.SaveAs(ms);
                        //Reset the memory stream position.
                        ms.Position = 0;


                        string subject = "Household members that missed their Vl Appointment";
                        string message = $"<p>Dear all,</p> <p>Please find attached the list of all household members that have missed their Viralload appointment</p>" +
                            
                            $"<p>Regards</p> <p>System notification,</p><p>{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}</p>";
                        List<string> EmailList = new List<string>();
                      //  EmailList.Add("wokwerahenry@gmail.com");
                        var contacts = await db.AContacts
                        .Where(o => o.PositionId == 2 || o.PositionId == 3 || o.PositionId == 9 || o.PositionId == 4 ||
                        o.PositionId == 1 || o.PositionId == 10 || o.PositionId == 24 || o.PositionId == 25 || o.PositionId == 5
                        || o.PositionId == 32 || o.PositionId == 33).ToListAsync();
                        if (contacts != null && contacts.Count > 0)
                        {
                            foreach (var contact in contacts)
                            {
                                if (!string.IsNullOrEmpty(contact.ContactEmail))
                                {
                                    EmailList.Add(contact.ContactEmail);
                                }
                            }
                        }
                        //Attachment file = new Attachment(ms, "Invoice.pdf", "application/pdf");
                        Attachment mailattachment = new Attachment(ms, "Household members that missed their Vl Appointment.xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

                        if (EmailList.Count > 0)
                        {
                            await email.sendMessage(EmailList[0], subject, message, mailattachment, EmailList);
                        }

                        ms.Dispose();
                        workbook.Close();
                    }
                }
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        private async Task GetNonsuppressing()
        {
            try
            {
                DateTime CurrentDate = DateTime.Now;
                DateTime? StartDate = null;
                DateTime? EndDate = null;

                if (CurrentDate.Month >= 10 && CurrentDate.Month <= 12)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 10, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 12, DateTime.DaysInMonth(DateTime.Now.Year, 12));
                }
                else if (CurrentDate.Month >= 1 && CurrentDate.Month <= 3)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 1, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 3, DateTime.DaysInMonth(DateTime.Now.Year, 3));
                }
                else if (CurrentDate.Month >= 4 && CurrentDate.Month <= 6)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 4, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 6, DateTime.DaysInMonth(DateTime.Now.Year, 6));
                }
                else if (CurrentDate.Month >= 7 && CurrentDate.Month <= 9)
                {
                    StartDate = new DateTime(DateTime.Now.Year, 7, 1);
                    EndDate = new DateTime(DateTime.Now.Year, 9, DateTime.DaysInMonth(DateTime.Now.Year, 9));
                }

                var data = await db.spSystemalertsGetAllAsync(StartDate, EndDate, 4);
                if (data != null && data.Count > 0)
                {
                    using (ExcelEngine excelEngine = new ExcelEngine())
                    {
                        IApplication application = excelEngine.Excel;
                        application.DefaultVersion = ExcelVersion.Excel2013;
                        IWorkbook workbook = application.Workbooks.Create(1);
                        IWorksheet worksheet = workbook.Worksheets[0];
                        worksheet.Name = "Household members that are Non-suppression";

                        #region Styles
                        var headerStyle = workbook.Styles.Add("headerStyle");

                        headerStyle.BeginUpdate();
                        headerStyle.Color = Syncfusion.Drawing.Color.Black; //Syncfusion.Drawing.Color.FromArgb(255, 0, 0);
                        headerStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        headerStyle.Font.Bold = true;
                        headerStyle.Font.FontName = "Arial";
                        headerStyle.Font.Size = 8f;
                        headerStyle.Font.Color = ExcelKnownColors.White;

                        headerStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        headerStyle.Borders.Color = ExcelKnownColors.White;
                        headerStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        headerStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        headerStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        //headerStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thick;

                        headerStyle.WrapText = true;

                        headerStyle.EndUpdate();

                        var Style = workbook.Styles.Add("bodyStyle");

                        Style.BeginUpdate();
                        Style.HorizontalAlignment = ExcelHAlign.HAlignLeft;
                        Style.VerticalAlignment = ExcelVAlign.VAlignTop;
                        Style.Font.Bold = false;
                        Style.Font.FontName = "Arial";
                        Style.Font.Size = 8f;
                        Style.Font.Color = ExcelKnownColors.Black;
                        Style.WrapText = true;
                        Style.Borders.Color = ExcelKnownColors.Black;
                        Style.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        Style.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        Style.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        Style.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        Style.EndUpdate();


                        var CategoryStyle = workbook.Styles.Add("CategoryStyle");

                        CategoryStyle.BeginUpdate();
                        CategoryStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        CategoryStyle.Color = Syncfusion.Drawing.Color.FromArgb(255, 195, 0);
                        /*CategoryStyle.Color = Syncfusion.Drawing.Color.FromArgb(105, 59, 88);*/ //AUBERGINE
                        CategoryStyle.Font.Bold = true;
                        CategoryStyle.Font.FontName = "Arial";
                        CategoryStyle.Font.Size = 10f;
                        CategoryStyle.Font.Color = ExcelKnownColors.White;
                        CategoryStyle.WrapText = true;
                        CategoryStyle.Borders.Color = ExcelKnownColors.White;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        CategoryStyle.EndUpdate();

                        var CategoryTotalStyle = workbook.Styles.Add("CategoryTotalStyle");

                        CategoryTotalStyle.BeginUpdate();
                        CategoryTotalStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        CategoryTotalStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        CategoryTotalStyle.Color = Syncfusion.Drawing.Color.Black;
                        CategoryTotalStyle.Font.Bold = true;
                        CategoryTotalStyle.Font.FontName = "Arial";
                        CategoryTotalStyle.Font.Size = 8f;
                        CategoryTotalStyle.Font.Color = ExcelKnownColors.White;
                        CategoryTotalStyle.WrapText = true;
                        CategoryTotalStyle.Borders.Color = ExcelKnownColors.White;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        CategoryTotalStyle.EndUpdate();

                        var DivisionStyle = workbook.Styles.Add("DivisionStyle");

                        DivisionStyle.BeginUpdate();
                        DivisionStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        DivisionStyle.Color = Syncfusion.Drawing.Color.FromArgb(255, 0, 0); //RED
                        DivisionStyle.Font.Bold = true;
                        DivisionStyle.Font.FontName = "Arial";
                        DivisionStyle.Font.Size = 8f;
                        DivisionStyle.Font.Color = ExcelKnownColors.White;
                        DivisionStyle.WrapText = true;
                        DivisionStyle.Borders.Color = ExcelKnownColors.White;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        DivisionStyle.EndUpdate();

                        var DivisionTotalStyle = workbook.Styles.Add("DivisionTotalStyle");

                        DivisionTotalStyle.BeginUpdate();
                        DivisionTotalStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        DivisionTotalStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        DivisionTotalStyle.Color = Syncfusion.Drawing.Color.Black;
                        DivisionTotalStyle.Font.Bold = true;
                        DivisionTotalStyle.Font.FontName = "Arial";
                        DivisionTotalStyle.Font.Size = 8f;
                        DivisionTotalStyle.Font.Color = ExcelKnownColors.White;
                        DivisionTotalStyle.WrapText = true;
                        DivisionTotalStyle.Borders.Color = ExcelKnownColors.White;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        DivisionTotalStyle.EndUpdate();


                        var TopicStyle = workbook.Styles.Add("TopicStyle");

                        TopicStyle.BeginUpdate();
                        TopicStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        TopicStyle.Color = Syncfusion.Drawing.Color.FromArgb(105, 59, 88); //AUBERGINE
                        TopicStyle.Font.Bold = true;
                        TopicStyle.Font.FontName = "Arial";
                        TopicStyle.Font.Size = 8f;
                        TopicStyle.Font.Color = ExcelKnownColors.White;
                        TopicStyle.WrapText = true;
                        TopicStyle.Borders.Color = ExcelKnownColors.White;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        TopicStyle.EndUpdate();

                        var TopicTotalStyle = workbook.Styles.Add("TopicTotalStyle");

                        TopicTotalStyle.BeginUpdate();
                        TopicTotalStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        TopicTotalStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                        TopicTotalStyle.Color = Syncfusion.Drawing.Color.Black;
                        TopicTotalStyle.Font.Bold = true;
                        TopicTotalStyle.Font.FontName = "Arial";
                        TopicTotalStyle.Font.Size = 8f;
                        TopicTotalStyle.Font.Color = ExcelKnownColors.White;
                        TopicTotalStyle.WrapText = true;
                        TopicTotalStyle.Borders.Color = ExcelKnownColors.White;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        TopicTotalStyle.EndUpdate();
                        #endregion

                        int row = 1;

                        #region Header row
                        worksheet.Range["A" + row].Text = "HH UiD";
                        worksheet.Range["A" + row].ColumnWidth = 15;

                        worksheet.Range["B" + row].Text = "District";
                        worksheet.Range["B" + row].ColumnWidth = 20;

                        worksheet.Range["C" + row].Text = "Sub county";
                        worksheet.Range["C" + row].ColumnWidth = 20;

                        worksheet.Range["D" + row].Text = "Parish";
                        worksheet.Range["D" + row].ColumnWidth = 20;

                        worksheet.Range["E" + row].Text = "Village";
                        worksheet.Range["E" + row].ColumnWidth = 20;

                        worksheet.Range["F" + row].Text = "Individual UiD";
                        worksheet.Range["F" + row].ColumnWidth = 15;

                        worksheet.Range["G" + row].Text = "Name of HH member";
                        worksheet.Range["G" + row].ColumnWidth = 20;

                        worksheet.Range["H" + row].Text = "Sex";
                        worksheet.Range["H" + row].ColumnWidth = 10;

                        worksheet.Range["I" + row].Text = "Date of birth";
                        worksheet.Range["I" + row].ColumnWidth = 13;

                        worksheet.Range["J" + row].Text = "Age";
                        worksheet.Range["J" + row].ColumnWidth = 10;

                        worksheet.Range["K" + row].Text = "Known Risk Factor";
                        worksheet.Range["K" + row].ColumnWidth = 15;

                        worksheet.Range["L" + row].Text = "Program Participation";
                        worksheet.Range["L" + row].ColumnWidth = 15;
                        worksheet.Range["M" + row].Text = "No of copies";
                        worksheet.Range["M" + row].ColumnWidth = 15;

                        worksheet.Range["N" + row].Text = "ART Number";
                        worksheet.Range["N" + row].ColumnWidth = 15;

                        worksheet.Range["O" + row].Text = "Facility";
                        worksheet.Range["O" + row].ColumnWidth = 15;

                        worksheet.Range["A" + row + ":O" + row].CellStyle = headerStyle;
                        #endregion Header row

                        row++;

                        foreach (var item in data)
                        {
                            worksheet.Range["A" + row].Text = item.HouseHoldMemberCode.Substring(0, 10);

                            worksheet.Range["B" + row].Text = item.DistrictDescription;

                            worksheet.Range["C" + row].Text = item.SubcountyDescription;

                            worksheet.Range["D" + row].Text = item.ParishDescription;

                            worksheet.Range["E" + row].Text = item.VillageDescription;

                            worksheet.Range["F" + row].Text = item.HouseHoldMemberCode;

                            worksheet.Range["G" + row].Text = $"{item.Surname} {item.Givenname}";

                            worksheet.Range["H" + row].Text = item.GenderId;
                            if (item.DoB.HasValue)
                            {
                                worksheet.Range["I" + row].Text = item.DoB.Value.ToString("dd/MM/yyyy");
                            }
                            if (item.Age.HasValue)
                            {
                                worksheet.Range["J" + row].Number = item.Age.Value;
                            }
                            worksheet.Range["K" + row].Text = item.KnownRiskFactorDescription;

                            worksheet.Range["L" + row].Text = item.ProgramParticipationDescription;
                            if (item.ViralloadTestResults.HasValue)
                            {
                                worksheet.Range["M" + row].Number = item.ViralloadTestResults.Value;
                            }
                            worksheet.Range["N" + row].Text = item.ArtNumber;
                            worksheet.Range["O" + row].Text = item.FacilityName;
                            worksheet.Range["A" + row + ":O" + row].CellStyle = Style;

                            row++;
                        }

                        MemoryStream ms = new MemoryStream();
                        // Save and close the document.
                        workbook.SaveAs(ms);
                        //Reset the memory stream position.
                        ms.Position = 0;


                        string subject = "Household members that are Non-suppression";
                        string message = $"<p>Dear all,</p> <p>Please find attached the list of all C/ALHIV household members that are Non-suppression </p>" +
                            
                            $"<p>Regards</p> <p>System notification,</p><p>{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}</p>";
                        List<string> EmailList = new List<string>();
                        //EmailList.Add("wokwerahenry@gmail.com");
                        var contacts = await db.AContacts
                        .Where(o => o.PositionId == 2 || o.PositionId == 3 || o.PositionId == 4 || o.PositionId == 7 || o.PositionId == 18 
                        || o.PositionId == 9 || o.PositionId == 13 || o.PositionId == 1 || o.PositionId == 20 ||
                        o.PositionId == 12 || o.PositionId == 21 || o.PositionId == 24 || o.PositionId == 25 || 
                        o.PositionId == 5 || o.PositionId == 32 || o.PositionId == 33).ToListAsync();
                        if (contacts != null && contacts.Count > 0)
                        {
                            foreach (var contact in contacts)
                            {
                                if (!string.IsNullOrEmpty(contact.ContactEmail))
                                {
                                    EmailList.Add(contact.ContactEmail);
                                }
                            }
                        }
                        //Attachment file = new Attachment(ms, "Invoice.pdf", "application/pdf");
                        Attachment mailattachment = new Attachment(ms, "Household members that are Non-suppression.xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

                        if (EmailList.Count > 0)
                        {
                            await email.sendMessage(EmailList[0], subject, message, mailattachment, EmailList);
                        }

                        ms.Dispose();
                        workbook.Close();
                    }
                }
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
