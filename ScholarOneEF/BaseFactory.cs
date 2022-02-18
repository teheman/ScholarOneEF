﻿using ScholarOneEF.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScholarOneEF
{
    public abstract class BaseFactory
    {
        #region Fields

        private string _user;
        private string _password;
        private EnvironmentEnum _environment;

        private string _siteName;
        private string _externalId = null;
        private ResponseTypeEnum _type = ResponseTypeEnum.xml;
        private LocaleIdEnum _localeId = LocaleIdEnum.English;

        private const string REALM = "realm";
        private const string NONCE = "nonce";
        private const string NEXTNONCE = "nextnonce";

        private bool _propogateErrors;

        #endregion

        #region Properties

        /// <summary>
        /// Indicates the type of response to request from ScholarOne<br />
        /// Responses may be "xml" or "json", the default is "xml"
        /// </summary>
        public ResponseTypeEnum ResponseType
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        /// <summary>
        /// The locale_id is the unique identifier for a specific language.The value of the locale_id must match to the language specified in the caller’s profile as defined in the ScholarOne Manuscripts database.<br />
        /// Options are: "1" (United States English), "2" (Simplified Chinese, Pinyin ordering), "3" (French)
        /// </summary>
        public LocaleIdEnum LocaleId
        {
            get
            {
                return _localeId;
            }
            set
            {
                _localeId = value;
            }
        }

        /// <summary>
        /// Id used for audit purposes
        /// </summary>
        public string ExternalId
        {
            get
            {
                return _externalId;
            }
            set
            {
                _externalId = value;
            }
        }

        /// <summary>
        /// Determines if scholar one is queried using integration or production URL<br />
        /// The default is integration
        /// </summary>
        public EnvironmentEnum Environment
        {
            get
            {
                return _environment;
            }
            set
            {
                _environment = value;
            }
        }

        /// <summary>
        /// Indicates if errors should be caught or allowed to propogate<br />
        /// If false, any errors consuming the service will be caught and assigned to the service result's Error property<br />
        /// Default value is true
        /// </summary>
        public bool PropogateErrors
        {
            get
            {
                return _propogateErrors;
            }
            set
            {
                _propogateErrors = value;
            }
        }

        #endregion

        #region Constructor

        protected BaseFactory(string user, string password, string siteName)
        {
            _user = user;
            _password = password;
            _environment = EnvironmentEnum.Integration;
            _siteName = siteName;
            _propogateErrors = true;
        }

        #endregion

        #region Services

        /// <summary>
        /// Use getAuthorFullBySubmissionId service
        /// </summary>
        /// <param name="ids">submission ids</param>
        /// <returns>service object</returns>
        public async Task<AuthorFullBySubmissionIdResult> getAuthorFullBySubmissionId(IEnumerable<string> ids)
        {
            var service = new AuthorFullBySubmissionIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getAuthorFullByDocumentId service
        /// </summary>
        /// <param name="ids">document ids</param>
        /// <returns>service object</returns>
        public async Task<AuthorFullByDocumentIdResult> getAuthorFullByDocumentId(IEnumerable<string> ids)
        {
            var service = new AuthorFullByDocumentIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getAuthorBasicBySubmissionId service
        /// </summary>
        /// <param name="ids">submission ids</param>
        /// <returns>service object</returns>
        public async Task<AuthorBasicBySubmissionIdResult> getAuthorBasicBySubmissionId(IEnumerable<string> ids)
        {
            var service = new AuthorBasicBySubmissionIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getAuthorBasicByDocumentId service
        /// </summary>
        /// <param name="ids">document ids</param>
        /// <returns>service object</returns>
        public async Task<AuthorBasicByDocumentIdResult> getAuthorBasicByDocumentId(IEnumerable<string> ids)
        {
            var service = new AuthorBasicByDocumentIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getReviewerInfoFullBySubmissionId service
        /// </summary>
        /// <param name="ids">submission ids</param>
        /// <returns>service object</returns>
        public async Task<ReviewerInfoFullBySubmissionIdResult> getReviewerInfoFullBySubmissionId(IEnumerable<string> ids)
        {
            var service = new ReviewerInfoFullBySubmissionIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getReviewerInfoFullByDocumentId service
        /// </summary>
        /// <param name="ids">document ids</param>
        /// <returns>service object</returns>
        public async Task<ReviewerInfoFullByDocumentIdResult> getReviewerInfoFullByDocumentId(IEnumerable<string> ids)
        {
            var service = new ReviewerInfoFullByDocumentIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getSubmissionInfoBasicBySubmissionId service
        /// </summary>
        /// <param name="ids">submission ids</param>
        /// <returns>service object</returns>
        public async Task<SubmissionInfoBasicBySubmissionIdResult> getSubmissionInfoBasicBySubmissionId(IEnumerable<string> ids)
        {
            var service = new SubmissionInfoBasicBySubmissionIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getSubmissionInfoBasicByDocumentId service
        /// </summary>
        /// <param name="ids">document ids</param>
        /// <returns>service object</returns>
        public async Task<SubmissionInfoBasicByDocumentIdResult> getSubmissionInfoBasicByDocumentId(IEnumerable<string> ids)
        {
            var service = new SubmissionInfoBasicByDocumentIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getSubmissionFullBySubmissionId service
        /// </summary>
        /// <param name="ids">submission ids</param>
        /// <returns>service object</returns>
        public async Task<SubmissionFullBySubmissionIdResult> getSubmissionFullBySubmissionId(IEnumerable<string> ids)
        {
            var service = new SubmissionFullBySubmissionIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getSubmissionFullByDocumentId service
        /// </summary>
        /// <param name="ids">document ids</param>
        /// <returns>service object</returns>
        public async Task<SubmissionFullByDocumentIdResult> getSubmissionFullByDocumentId(IEnumerable<string> ids)
        {
            var service = new SubmissionFullByDocumentIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getStaffInfoFullBySubmissionId service
        /// </summary>
        /// <param name="ids">submission ids</param>
        /// <returns>service object</returns>
        public async Task<StaffInfoFullBySubmissionIdResult> getStaffInfoFullBySubmissionId(IEnumerable<string> ids)
        {
            var service = new StaffInfoFullBySubmissionIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getStaffInfoFullByDocumentId service
        /// </summary>
        /// <param name="ids">document ids</param>
        /// <returns>service object</returns>
        public async Task<StaffInfoFullByDocumentIdResult> getStaffInfoFullByDocumentId(IEnumerable<string> ids)
        {
            var service = new StaffInfoFullByDocumentIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getSubmissionVersionsBySubmissionId service
        /// </summary>
        /// <param name="ids">submission ids</param>
        /// <returns>service object</returns>
        public async Task<SubmissionVersionsBySubmissionIdResult> getSubmissionVersionsBySubmissionId(IEnumerable<string> ids)
        {
            var service = new SubmissionVersionsBySubmissionIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getSubmissionVersionsByDocumentId service
        /// </summary>
        /// <param name="ids">document ids</param>
        /// <returns>service object</returns>
        public async Task<SubmissionVersionsByDocumentIdResult> getSubmissionVersionsByDocumentId(IEnumerable<string> ids)
        {
            var service = new SubmissionVersionsByDocumentIdResult(ids);
            await ConsumeApi(service);
            return service;
        }

        /// <summary>
        /// Use getExternalDocumentIdsFull service
        /// </summary>
        /// <param name="from">Beginning date of the time period being requested</param>
        /// <param name="to">Ending date of the time period being requested</param>
        /// <param name="integrationKey">The submission integration key uniquely identifying integration. This is the value contained in the &lt;clientkey&gt; element in the header of the .go file</param> 
        /// <returns>service object</returns>
        public async Task<ExternalDocumentIdsResult> getExternalDocumentIdsFull(DateTime from, DateTime to, string integrationKey)
        {
            var service = new ExternalDocumentIdsResult(from, to, integrationKey);
            await ConsumeApi(service);
            return service;
        }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// Performs initial request that will be challenged for credentials
        /// </summary>
        /// <param name="uri">Uri of a digest API</param>
        /// <returns>authorization header of the response as a string</returns>
        protected abstract Task<string> GetInitialAuthorizationHeader(Uri uri);
        /// <summary>
        /// Performs second request of digest API method with full authorization header and returns the response content
        /// </summary>
        /// <param name="uri">Uri of a digest API</param>
        /// <param name="authorizationHeader">Authorization header to be used by the request</param>
        /// <returns>content as a string</returns>
        protected abstract Task<string> GetAuthorizedResponse(Uri uri, string authorizationHeader);

        #endregion

        #region Generic Service Methods

        /// <summary>
        /// Consume the service and update the service object
        /// </summary>
        /// <param name="service">ScholarOne service</param>
        protected async Task ConsumeApi(BaseServiceResult service)
        {
            service.Begin();
            service.Response = null;
            service.ReturnType = _type;
            service.Environment = _environment;
            service.Uri = null;
            service.Success = false;
            service.Error = null;

            string url = ServiceEndpoints.Protocol
                + (_environment == EnvironmentEnum.Production ? ServiceEndpoints.ProductionHost : ServiceEndpoints.IntegrationHost)
                + service.GetEndpoint()
                + $"?site_name={_siteName}&_type={_type}&locale_id={((int)_localeId)}" 
                + (string.IsNullOrWhiteSpace(_externalId) ? "" : $"&external_id={_externalId}")
                + service.GetQueryParameters();

            service.Uri = new Uri(url);

            if (_propogateErrors)
            {
                service.Response = await Get(service.Uri);
                service.Success = true;
            }
            else
            {
                try
                {
                    service.Response = await Get(service.Uri);
                    service.Success = true;
                }
                catch (Exception e)
                {
                    service.Error = e;
                }
            }

            service.Finish();
        }

        /// <summary>
        /// Method to get the response from the ScholarOne Uri and return the raw response
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        private async Task<string> Get(Uri uri)
        {
            #region Initial Request and Challenge

            // Perform the initial request to get the authorization challenge
            string challengeHeader = await GetInitialAuthorizationHeader(uri);
            
            // Extract nonce and realm from response
            string nonce = GetHeaderValue(challengeHeader, NONCE);
            string realm = GetHeaderValue(challengeHeader, REALM);

            // If next nonce header is present, update nonce
            string nextNonce = GetHeaderValue(challengeHeader, NEXTNONCE);
            if (!string.IsNullOrWhiteSpace(nextNonce))
                nonce = nextNonce;

            // If nonce is missing, something has gone wrong
            if (string.IsNullOrWhiteSpace(nonce))
                throw new FormatException("Missing nonce from authorization header");

            // Realm, should never be null, but we'll default just in case
            if (string.IsNullOrWhiteSpace(realm))
                realm = "ScholarOneApiService";

            #endregion

            #region Format Authorization Header

            // calculate response based on Specs for digest authentication
            // https://httpwg.org/specs/rfc7616.html#response

            string uriEscaped = WebUtility.UrlEncode(uri.PathAndQuery);
            
            string ha1 = ComputeMd5Hash($"{_user}:{realm}:{_password}");
            string ha2 = ComputeMd5Hash($"{WebRequestMethods.Http.Get}:{uriEscaped}");

            string digestResponse = ComputeMd5Hash($"{ha1}:{nonce}:{ha2}");

            string newAuthorizationHeader = $"Digest username=\"{_user}\", {REALM}=\"{realm}\", {NONCE}=\"{nonce}\", uri=\"{uriEscaped}\", response=\"{digestResponse}\"";

            #endregion

            // lastly return response using formatted authorization header
            return await GetAuthorizedResponse(uri, newAuthorizationHeader);
        }

        #endregion

        #region Helper Methods

        private static string GetHeaderValue(string header, string attributeName)
        {
            var regHeader = new Regex(string.Format(@"{0}=""([^""]*)""", attributeName));
            var matchHeader = regHeader.Match(header);
            if (matchHeader.Success)
                return matchHeader.Groups[1].Value;

            return null;
        }

        private static string ComputeMd5Hash(string input)
        {
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hash = MD5.Create().ComputeHash(inputBytes);
            var sb = new StringBuilder();
            foreach (var b in hash)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        #endregion
    }
}
