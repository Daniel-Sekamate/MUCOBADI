using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ErrorLog
    {
        public int ErrorLogId { get; set; }
        public DateTime? ErrorDateTime { get; set; }
        public string ErrorMessage { get; set; }
        public int? ErrorSeverity { get; set; }
        public int? ErrorState { get; set; }
    }
}
