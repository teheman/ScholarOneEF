using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class SubmissionVersionsByDocumentIdService : BaseIdsService
    {
        internal SubmissionVersionsByDocumentIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.SubmissionVersionsDocumentId) { }
    }
}
