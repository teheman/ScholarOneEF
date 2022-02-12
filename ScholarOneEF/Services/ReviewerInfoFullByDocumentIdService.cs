using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class ReviewerInfoFullByDocumentIdService : BaseIdsService
    {
        internal ReviewerInfoFullByDocumentIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.ReviewerInfoFullByDocumentId) { }
    }
}
