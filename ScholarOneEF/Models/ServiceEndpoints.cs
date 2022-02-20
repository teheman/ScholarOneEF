namespace ScholarOneEF.Models
{
    public static class ServiceEndpoints
    {
        public const string IntegrationHost = "mc-beta-api.manuscriptcentral.com";
        public const string ProductionHost = "mc-api.manuscriptcentral.com";
        public const string Protocol = "https://";

        public const string SubmissionInfoBasicDocumentId = "/api/s1m/v3/submissions/basic/metadata/documentids";
        public const string SubmissionFullDocumentId = "/api/s1m/v3/submissions/full/metadata/documentids";
        public const string SubmissionInfoBasicSubmissionId = "/api/s1m/v3/submissions/basic/metadata/submissionids";
        public const string SubmissionFullSubmissionId = "/api/s1m/v3/submissions/full/metadata/submissionids";
        public const string AuthorBasicByDocumentId = "/api/s1m/v2/submissions/basic/contributors/authors/documentids";
        public const string AuthorFullByDocumentId = "/api/s1m/v2/submissions/full/contributors/authors/documentids";
        public const string AuthorBasicBySubmissionId = "/api/s1m/v2/submissions/basic/contributors/authors/submissionids";
        public const string AuthorFullBySubmissionId = "/api/s1m/v2/submissions/full/contributors/authors/submissionids";
        public const string ReviewerInfoFullByDocumentId = "/api/s1m/v2/submissions/full/reviewer/documentids";
        public const string ReviewerInfoFullBySubmissionId = "/api/s1m/v2/submissions/full/reviewer/submissionids";
        public const string StaffInfoFullByDocumentId = "/api/s1m/v1/submissions/full/staff_users/documentids";
        public const string StaffInfoFullBySubmissionId = "/api/s1m/v1/submissions/full/staff_users/submissionids";
        public const string SubmissionVersionsDocumentId = "/api/s1m/v1/submissions/full/revisions/documentids";
        public const string SubmissionVersionsSubmissionId = "/api/s1m/v1/submissions/full/revisions/submissionids";
        public const string PersonInfoBasicById = "/api/s1m/v1/person/basic/personid/search";
        public const string PersonInfoBasicByEmail = "/api/s1m/v1/person/basic/email/search";
        public const string PersonInfoFullById = "/api/s1m/v3/person/full/personid/search";
        public const string PersonInfoFullByEmail = "/api/s1m/v3/person/full/email/search";
        public const string DecisionCorrespondenceFullDocumentId = "/api/s1m/v2/submissions/full/decisioncorrespondence/documentids";
        public const string DecisionCorrespondenceFullSubmissionId = "/api/s1m/v2/submissions/full/decisioncorrespondence/submissionids";
        public const string ExternalDocumentIdsFull = "/api/s1m/v2/submissions/full/externaldocids";
    }
}
