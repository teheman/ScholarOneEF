using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class SubmissionFullByDocumentIdService : BaseService
    {
        private string _queryString;

        internal override string GetQueryParameters() => _queryString;

        internal SubmissionFullByDocumentIdService(IEnumerable<string> ids) : base(ServiceEndpoints.SubmissionFullDocumentId)
        {
            _queryString = FormatIds(ids);
        }
    }
}
