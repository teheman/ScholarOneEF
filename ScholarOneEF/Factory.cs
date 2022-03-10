using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ScholarOne
{
    /// <summary>
    /// Factory to retrieve service responses from ScholarOne API
    /// </summary>
    public class Factory : BaseFactory
    {
        private readonly HttpClient _client;

        #region Implement Factory

        /// <summary>
        /// Performs second request of digest API method with full authorization header and returns the response content
        /// </summary>
        /// <param name="uri">Uri of a digest API</param>
        /// <param name="authorizationHeader">Authorization header to be used by the request</param>
        /// <returns>content as a string</returns>
        protected override async Task<string> GetAuthorizedResponse(Uri uri, string authorizationHeader)
        {
            if (_client != null)
            {
                var request = new HttpRequestMessage(HttpMethod.Get, uri);
                request.Headers.Add("Authorization", authorizationHeader);

                var result = await _client.SendAsync(request);

                var bytes = await result.Content.ReadAsByteArrayAsync();
                string response =  Encoding.UTF8.GetString(bytes, 0, bytes.Length);

                if (result.IsSuccessStatusCode)
                    return response;

                throw new WebException($"The request could not be completed. The server returned Status: {(int)result.StatusCode}; Message: {(string.IsNullOrWhiteSpace(response) ? "(empty)" : response)}");
            }
            else
            {
                string response;
                using (var client = new WebClient())
                {
                    client.Headers.Add("Authorization", authorizationHeader);
                    client.Encoding = Encoding.UTF8;
                    response = await Task.Run(() => client.DownloadString(uri));
                }

                return response;
            }
        }

        /// <summary>
        /// Performs initial request that will be challenged for credentials
        /// </summary>
        /// <param name="uri">Uri of a digest API</param>
        /// <returns>authorization header of the response as a string</returns>
        protected override async Task<string> GetInitialAuthorizationHeader(Uri uri)
        {
            if (_client != null)
            {
                var request = new HttpRequestMessage(HttpMethod.Get, uri);
                HttpResponseMessage response = await _client.SendAsync(request);
                return response.Headers.GetValues("WWW-Authenticate").First();
            }
            else
            {
                using (var client = new WebClient())
                {
                    try
                    {
                        client.DownloadString(uri);
                    }
                    catch (WebException webException) when (((HttpWebResponse)webException.Response).StatusCode == HttpStatusCode.Unauthorized)
                    {
                        // Expected challenge for credentials
                        return webException.Response.Headers.Get("WWW-Authenticate");
                    }
                }
            }

            // this shouldn't happen
            throw new Exception("Unexpected OK response from Scholar One API. An unauthorized response was expected.");
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initialize factory that will use HttpClient to consume ScholarOne Api
        /// </summary>
        /// <param name="user">API user name</param>
        /// <param name="password">API key</param>
        /// <param name="siteName">Site name for ScholarOne API</param>
        /// <param name="client">HttpClient to be used for service requests</param>
        public Factory(string user, string password, string siteName, HttpClient client) : base(user, password, siteName)
        {
            _client = client;
        }

        /// <summary>
        /// Initialize factory that will use HttpClient to consume ScholarOne Api
        /// </summary>
        /// <param name="user">API user name</param>
        /// <param name="password">API key</param>
        /// <param name="siteName">Site name for ScholarOne API</param>
        /// <param name="externalId">id used for auditing when consuming the API</param>
        /// <param name="client">HttpClient to be used for service requests</param>
        public Factory(string user, string password, string siteName, string externalId, HttpClient client) : base(user, password, siteName)
        {
            this.ExternalId = externalId;
            _client = client;
        }

        /// <summary>
        /// Initialize factory that will use HttpClient to consume ScholarOne Api
        /// </summary>
        /// <param name="user">API user name</param>
        /// <param name="password">API key</param>
        /// <param name="siteName">Site name for ScholarOne API</param>
        /// <param name="externalId">id used for auditing when consuming the API</param>
        /// <param name="environment">the ScholarOne environment to use - integration or production</param>
        /// <param name="client">HttpClient to be used for service requests</param>
        public Factory(string user, string password, string siteName, string externalId, EnvironmentEnum environment, HttpClient client) : base(user, password, siteName)
        {
            this.ExternalId = externalId;
            this.Environment = environment;
            _client = client;
        }

        /// <summary>
        /// Initialize factory that will use WebClient to consume ScholarOne Api
        /// </summary>
        /// <param name="user">API user name</param>
        /// <param name="password">API key</param>
        /// <param name="siteName">Site name for ScholarOne API</param>
        public Factory(string user, string password, string siteName) : base(user, password, siteName)
        {
            _client = null;
        }

        /// <summary>
        /// Initialize factory that will use WebClient to consume ScholarOne Api
        /// </summary>
        /// <param name="user">API user name</param>
        /// <param name="password">API key</param>
        /// <param name="siteName">Site name for ScholarOne API</param>
        /// <param name="externalId">id used for auditing when consuming the API</param>
        public Factory(string user, string password, string siteName, string externalId) : base(user, password, siteName)
        {
            this.ExternalId = externalId;
            _client = null;
        }

        /// <summary>
        /// Initialize factory that will use WebClient to consume ScholarOne Api
        /// </summary>
        /// <param name="user">API user name</param>
        /// <param name="password">API key</param>
        /// <param name="siteName">Site name for ScholarOne API</param>
        /// <param name="externalId">id used for auditing when consuming the API</param>
        /// <param name="environment">the ScholarOne environment to use - integration or production</param>
        public Factory(string user, string password, string siteName, string externalId, EnvironmentEnum environment) : base(user, password, siteName)
        {
            this.ExternalId = externalId;
            this.Environment = environment;
            _client = null;
        }

        #endregion
    }
}
