using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class SubmissionVersionsBySubmissionIdService : BaseIdsService
    {
        internal SubmissionVersionsBySubmissionIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.SubmissionVersionsSubmissionId) { }
    }
}
