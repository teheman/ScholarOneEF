using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class SubmissionInfoBasicByDocumentIdService : BaseIdsService
    {
        internal SubmissionInfoBasicByDocumentIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.SubmissionInfoBasicDocumentId) { }
    }
}
