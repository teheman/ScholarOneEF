using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class AuthorBasicByDocumentIdService : BaseIdsService
    {
        internal AuthorBasicByDocumentIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.AuthorBasicByDocumentId) { }
    }
}
