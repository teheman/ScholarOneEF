using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class AuthorFullBySubmissionIdService : BaseService
    {
        private string _queryString;

        internal override string GetQueryParameters() => _queryString;

        internal AuthorFullBySubmissionIdService(IEnumerable<string> ids) : base(ServiceEndpoints.AuthorFullBySubmissionId)
        {
            _queryString = FormatIds(ids);
        }
    }
}
