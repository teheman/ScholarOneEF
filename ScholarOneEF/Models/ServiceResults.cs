using System.Collections.Generic;

namespace ScholarOneEF.Models
{
    /// <summary>
    /// Results of consuming ScholarOne API service AuthorBasicByDocumentId
    /// </summary>
    public class AuthorBasicByDocumentIdResult : BaseIdsServiceResult
    {
        internal AuthorBasicByDocumentIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.AuthorBasicByDocumentId) { }
    }
    /// <summary>
    /// Results of consuming ScholarOne API service AuthorBasicBySubmissionId
    /// </summary>
    public class AuthorBasicBySubmissionIdResult : BaseIdsServiceResult
    {
        internal AuthorBasicBySubmissionIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.AuthorBasicBySubmissionId) { }
    }
    /// <summary>
    /// Results of consuming ScholarOne API service AuthorFullByDocumentId
    /// </summary>
    public class AuthorFullByDocumentIdResult : BaseIdsServiceResult
    {
        internal AuthorFullByDocumentIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.AuthorFullByDocumentId) { }
    }
    /// <summary>
    /// Results of consuming ScholarOne API service AuthorFullBySubmissionId
    /// </summary>
    public class AuthorFullBySubmissionIdResult : BaseIdsServiceResult
    {
        internal AuthorFullBySubmissionIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.AuthorFullBySubmissionId) { }
    }
    /// <summary>
    /// Results of consuming ScholarOne API service ReviewerInfoFullByDocumentId
    /// </summary>
    public class ReviewerInfoFullByDocumentIdResult : BaseIdsServiceResult
    {
        internal ReviewerInfoFullByDocumentIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.ReviewerInfoFullByDocumentId) { }
    }
    /// <summary>
    /// Results of consuming ScholarOne API service ReviewerInfoFullBySubmissionId
    /// </summary>
    public class ReviewerInfoFullBySubmissionIdResult : BaseIdsServiceResult
    {
        internal ReviewerInfoFullBySubmissionIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.ReviewerInfoFullBySubmissionId) { }
    }
    /// <summary>
    /// Results of consuming ScholarOne API service StaffInfoFullByDocumentId
    /// </summary>
    public class StaffInfoFullByDocumentIdResult : BaseIdsServiceResult
    {
        internal StaffInfoFullByDocumentIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.StaffInfoFullByDocumentId) { }
    }
    /// <summary>
    /// Results of consuming ScholarOne API service StaffInfoFullBySubmissionId
    /// </summary>
    public class StaffInfoFullBySubmissionIdResult : BaseIdsServiceResult
    {
        internal StaffInfoFullBySubmissionIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.StaffInfoFullBySubmissionId) { }
    }
    /// <summary>
    /// Results of consuming ScholarOne API service SubmissionFullByDocumentId
    /// </summary>
    public class SubmissionFullByDocumentIdResult : BaseIdsServiceResult
    {
        internal SubmissionFullByDocumentIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.SubmissionFullDocumentId) { }
    }
    /// <summary>
    /// Results of consuming ScholarOne API service SubmissionFullBySubmissionId
    /// </summary>
    public class SubmissionFullBySubmissionIdResult : BaseIdsServiceResult
    {
        internal SubmissionFullBySubmissionIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.SubmissionFullSubmissionId) { }
    }
    /// <summary>
    /// Results of consuming ScholarOne API service SubmissionInfoBasicByDocumentId
    /// </summary>
    public class SubmissionInfoBasicByDocumentIdResult : BaseIdsServiceResult
    {
        internal SubmissionInfoBasicByDocumentIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.SubmissionInfoBasicDocumentId) { }
    }
    /// <summary>
    /// Results of consuming ScholarOne API service SubmissionInfoBasicBySubmissionId
    /// </summary>
    public class SubmissionInfoBasicBySubmissionIdResult : BaseIdsServiceResult
    {
        internal SubmissionInfoBasicBySubmissionIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.SubmissionInfoBasicSubmissionId) { }
    }
    /// <summary>
    /// Results of consuming ScholarOne API service SubmissionVersionsByDocumentId
    /// </summary>
    public class SubmissionVersionsByDocumentIdResult : BaseIdsServiceResult
    {
        internal SubmissionVersionsByDocumentIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.SubmissionVersionsDocumentId) { }
    }
    /// <summary>
    /// Results of consuming ScholarOne API service SubmissionVersionsBySubmissionId
    /// </summary>
    public class SubmissionVersionsBySubmissionIdResult : BaseIdsServiceResult
    {
        internal SubmissionVersionsBySubmissionIdResult(IEnumerable<string> ids) : base(ids, ServiceEndpoints.SubmissionVersionsSubmissionId) { }
    }
}
