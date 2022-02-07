using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class AuthorBasicByDocumentIdService : BaseService
    {
        private string _queryString;

        internal override string GetQueryParameters() => _queryString;

        internal AuthorBasicByDocumentIdService(IEnumerable<string> ids) : base(ServiceEndpoints.AuthorBasicByDocumentId)
        {
            _queryString = FormatIds(ids);
        }
    }
}
