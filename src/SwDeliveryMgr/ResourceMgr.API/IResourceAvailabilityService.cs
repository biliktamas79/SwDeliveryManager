using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResourceMgr.API
{
    using Domain.Model;
    using Request;
    using Response;

    public interface IResourceAvailabilityService
    {
        Task<GetEmployeeAvailabilityResponse> GetEmployeeAvailability(GetEmployeeAvailabilityRequest request, CancellationToken cancellationToken);

        Task<GetEmployeeDailyAvailabilityResponse> GetEmployeeDailyAvailability(GetEmployeeAvailabilityRequest request, CancellationToken cancellationToken);
    }
}
