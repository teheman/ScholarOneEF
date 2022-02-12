using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class SubmissionFullByDocumentIdService : BaseIdsService
    {
        internal SubmissionFullByDocumentIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.SubmissionFullDocumentId) { }
    }
}
