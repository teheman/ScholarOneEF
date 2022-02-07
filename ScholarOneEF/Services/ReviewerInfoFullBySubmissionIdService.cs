using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class ReviewerInfoFullBySubmissionIdService : BaseService
    {
        private string _queryString;

        internal override string GetQueryParameters() => _queryString;

        internal ReviewerInfoFullBySubmissionIdService(IEnumerable<string> ids) : base(ServiceEndpoints.ReviewerInfoFullBySubmissionId)
        {
            _queryString = FormatIds(ids);
        }
    }
}
