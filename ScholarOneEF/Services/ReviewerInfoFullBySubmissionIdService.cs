using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class ReviewerInfoFullBySubmissionIdService : BaseIdsService
    {
        internal ReviewerInfoFullBySubmissionIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.ReviewerInfoFullBySubmissionId) { }
    }
}
