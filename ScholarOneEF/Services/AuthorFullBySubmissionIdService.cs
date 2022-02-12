using System.Collections.Generic;

namespace ScholarOneEF.Services
{
    public class AuthorFullBySubmissionIdService : BaseIdsService
    {
        internal AuthorFullBySubmissionIdService(IEnumerable<string> ids) : base(ids, ServiceEndpoints.AuthorFullBySubmissionId) { }
    }
}
