namespace ScholarOne.Models
{
    /// <summary>
    /// Service locations provided by ScholarOne
    /// </summary>
    internal static class ServiceEndpoints
    {
        /// <summary>
        /// host for development environment
        /// </summary>
        public const string IntegrationHost = "mc-beta-api.manuscriptcentral.com";
        /// <summary>
        /// host for production environment
        /// </summary>
        public const string ProductionHost = "mc-api.manuscriptcentral.com";
        /// <summary>
        /// Protocol used by scholar one API (https)
        /// </summary>
        public const string Protocol = "https://";

        /// <summary>
        /// ScholarOne API location for SubmissionInfoBasicDocumentId
        /// </summary>
        public const string SubmissionInfoBasicDocumentId = "/api/s1m/v3/submissions/basic/metadata/documentids";
        /// <summary>
        /// ScholarOne API location for SubmissionFullDocumentId
        /// </summary>
        public const string SubmissionFullDocumentId = "/api/s1m/v3/submissions/full/metadata/documentids";
        /// <summary>
        /// ScholarOne API location for SubmissionInfoBasicSubmissionId
        /// </summary>
        public const string SubmissionInfoBasicSubmissionId = "/api/s1m/v3/submissions/basic/metadata/submissionids";
        /// <summary>
        /// ScholarOne API location for SubmissionFullSubmissionId
        /// </summary>
        public const string SubmissionFullSubmissionId = "/api/s1m/v3/submissions/full/metadata/submissionids";
        /// <summary>
        /// ScholarOne API location for AuthorBasicByDocumentId
        /// </summary>
        public const string AuthorBasicByDocumentId = "/api/s1m/v2/submissions/basic/contributors/authors/documentids";
        /// <summary>
        /// ScholarOne API location for AuthorFullByDocumentId
        /// </summary>
        public const string AuthorFullByDocumentId = "/api/s1m/v2/submissions/full/contributors/authors/documentids";
        /// <summary>
        /// ScholarOne API location for AuthorBasicBySubmissionId
        /// </summary>
        public const string AuthorBasicBySubmissionId = "/api/s1m/v2/submissions/basic/contributors/authors/submissionids";
        /// <summary>
        /// ScholarOne API location for AuthorFullBySubmissionId
        /// </summary>
        public const string AuthorFullBySubmissionId = "/api/s1m/v2/submissions/full/contributors/authors/submissionids";
        /// <summary>
        /// ScholarOne API location for ReviewerInfoFullByDocumentId
        /// </summary>
        public const string ReviewerInfoFullByDocumentId = "/api/s1m/v2/submissions/full/reviewer/documentids";
        /// <summary>
        /// ScholarOne API location for ReviewerInfoFullBySubmissionId
        /// </summary>
        public const string ReviewerInfoFullBySubmissionId = "/api/s1m/v2/submissions/full/reviewer/submissionids";
        /// <summary>
        /// ScholarOne API location for StaffInfoFullByDocumentId
        /// </summary>
        public const string StaffInfoFullByDocumentId = "/api/s1m/v1/submissions/full/staff_users/documentids";
        /// <summary>
        /// ScholarOne API location for StaffInfoFullBySubmissionId
        /// </summary>
        public const string StaffInfoFullBySubmissionId = "/api/s1m/v1/submissions/full/staff_users/submissionids";
        /// <summary>
        /// ScholarOne API location for SubmissionVersionsDocumentId
        /// </summary>
        public const string SubmissionVersionsDocumentId = "/api/s1m/v1/submissions/full/revisions/documentids";
        /// <summary>
        /// ScholarOne API location for SubmissionVersionsSubmissionId
        /// </summary>
        public const string SubmissionVersionsSubmissionId = "/api/s1m/v1/submissions/full/revisions/submissionids";
        /// <summary>
        /// ScholarOne API location for PersonInfoBasicById
        /// </summary>
        public const string PersonInfoBasicById = "/api/s1m/v1/person/basic/personid/search";
        /// <summary>
        /// ScholarOne API location for PersonInfoBasicByEmail
        /// </summary>
        public const string PersonInfoBasicByEmail = "/api/s1m/v1/person/basic/email/search";
        /// <summary>
        /// ScholarOne API location for PersonInfoFullById
        /// </summary>
        public const string PersonInfoFullById = "/api/s1m/v3/person/full/personid/search";
        /// <summary>
        /// ScholarOne API location for PersonInfoFullByEmail
        /// </summary>
        public const string PersonInfoFullByEmail = "/api/s1m/v3/person/full/email/search";
        /// <summary>
        /// ScholarOne API location for DecisionCorrespondenceFullDocumentId
        /// </summary>
        public const string DecisionCorrespondenceFullDocumentId = "/api/s1m/v2/submissions/full/decisioncorrespondence/documentids";
        /// <summary>
        /// ScholarOne API location for DecisionCorrespondenceFullSubmissionId
        /// </summary>
        public const string DecisionCorrespondenceFullSubmissionId = "/api/s1m/v2/submissions/full/decisioncorrespondence/submissionids";
        /// <summary>
        /// ScholarOne API location for ExternalDocumentIdsFull
        /// </summary>
        public const string ExternalDocumentIdsFull = "/api/s1m/v2/submissions/full/externaldocids";
    }
}
