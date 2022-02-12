using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class SubmissionInfoBasicBySubmissionIdService : BaseService
    {
        private string _queryString;

        internal override string GetQueryParameters() => _queryString;

        internal SubmissionInfoBasicBySubmissionIdService(IEnumerable<string> ids) : base(ServiceEndpoints.SubmissionInfoBasicSubmissionId)
        {
            _queryString = FormatIds(ids);
        }
    }
}
