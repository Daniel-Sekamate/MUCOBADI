using MUCOBADI.Data;
using MUCOBADI.DTOs;
using MUCOBADI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces
{
    public interface INmnService
    {
        public Task<NmnPrimaryData?> GetPrimaryData();
        public Task<List<InterventionAttendanceForm>?> GetInterventionAttendanceForm(int? InterventionTypeId, string? DistrictId, string? SubcountyId, int? SampledForId, int? DeliveryMethodId, string? Startdate, string? Enddate);
        public Task<Response?> SaveInterventionAttendanceForm(InterventionAttendanceForm Record);

        public Task<List<Nmnquestionaire>?> GetNmnquestionaire(string? DistrictId, string? SubcountyId, int? SampledForId, int? DeliveryMethodId, int? ImplementationMethodId, string? Startdate, string? Enddate);
        public Task<Response?> SaveNmnquestionaire(Nmnquestionaire Record);
    }
}
