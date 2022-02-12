using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class AuthorFullByDocumentIdService : BaseIdsService
    {
        internal AuthorFullByDocumentIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.AuthorFullByDocumentId) { }
    }
}
