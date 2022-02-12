using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class SubmissionFullBySubmissionIdService : BaseService
    {
        private string _queryString;

        internal override string GetQueryParameters() => _queryString;

        internal SubmissionFullBySubmissionIdService(IEnumerable<string> ids) : base(ServiceEndpoints.SubmissionFullSubmissionId)
        {
            _queryString = FormatIds(ids);
        }
    }
}
