using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class StaffInfoFullBySubmissionIdService : BaseIdsService
    {
        internal StaffInfoFullBySubmissionIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.StaffInfoFullBySubmissionId) { }
    }
}
