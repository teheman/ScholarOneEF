using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class AuthorBasicBySubmissionIdService : BaseService
    {
        private string _queryString;

        internal override string GetQueryParameters() => _queryString;

        internal AuthorBasicBySubmissionIdService(IEnumerable<string> ids) : base(ServiceEndpoints.AuthorBasicBySubmissionId)
        {
            _queryString = FormatIds(ids);
        }
    }
}
