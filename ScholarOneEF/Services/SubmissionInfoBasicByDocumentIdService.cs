using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class SubmissionInfoBasicByDocumentIdService : BaseService
    {
        private string _queryString;

        internal override string GetQueryParameters() => _queryString;

        internal SubmissionInfoBasicByDocumentIdService(IEnumerable<string> ids) : base(ServiceEndpoints.SubmissionInfoBasicDocumentId)
        {
            _queryString = FormatIds(ids);
        }
    }
}
