using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class AuthorFullByDocumentIdService : BaseService
    {
        private string _queryString;

        internal override string GetQueryParameters() => _queryString;

        internal AuthorFullByDocumentIdService(IEnumerable<string> ids) : base(ServiceEndpoints.AuthorFullByDocumentId)
        {
            _queryString = FormatIds(ids);
        }
    }
}
