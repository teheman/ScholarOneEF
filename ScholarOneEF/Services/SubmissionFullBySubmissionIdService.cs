using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class SubmissionFullBySubmissionIdService : BaseIdsService
    {
       internal SubmissionFullBySubmissionIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.SubmissionFullSubmissionId) { }
    }
}
