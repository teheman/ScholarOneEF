using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class AuthorBasicBySubmissionIdService : BaseIdsService
    {
        internal AuthorBasicBySubmissionIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.AuthorBasicBySubmissionId) { }
    }
}
