using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class ReviewerInfoFullByDocumentIdService : BaseService
    {
        private string _queryString;

        internal override string GetQueryParameters() => _queryString;

        internal ReviewerInfoFullByDocumentIdService(IEnumerable<string> ids) : base(ServiceEndpoints.ReviewerInfoFullByDocumentId)
        {
            _queryString = FormatIds(ids);
        }
    }
}
