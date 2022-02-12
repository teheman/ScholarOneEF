using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class StaffInfoFullByDocumentIdService : BaseIdsService
    {
        internal StaffInfoFullByDocumentIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.StaffInfoFullByDocumentId) { }
    }
}
