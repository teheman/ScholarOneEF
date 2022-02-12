using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class SubmissionInfoBasicBySubmissionIdService : BaseIdsService
    {
        internal SubmissionInfoBasicBySubmissionIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.SubmissionInfoBasicSubmissionId) { }
    }
}
