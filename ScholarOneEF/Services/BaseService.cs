using System;
using System.Collections.Generic;
using System.Linq;

namespace ScholarOneEF.Services
{
    /// <summary>
    /// Base class for ScholarOne API service
    /// </summary>
    public abstract class BaseService
    {
        #region public properties

        /// <summary>
        /// The raw XML or JSON returned by the service
        /// </summary>
        public string Response { get; internal set; }
        /// <summary>
        /// The type of the service response - xml or json
        /// </summary>
        public ResponseTypeEnum ReturnType { get; internal set; }
        /// <summary>
        /// The environment the response was retrieved from
        /// </summary>
        public EnvironmentEnum Environment { get; internal set; }
        /// <summary>
        /// The Uri that was queried
        /// </summary>
        public Uri Uri { get; internal set; }
        /// <summary>
        /// The elapsed time from start to finish of getting the API response
        /// </summary>
        public TimeSpan Duration
        {
            get
            {
                return _stop.Value - _start.Value;
            }
        }
        /// <summary>
        /// Indicates if getting the response from the service was successful
        /// </summary>
        public bool Success { get; internal set; }
        /// <summary>
        /// If an error occurs while consuming the service, the exception will be set in this property
        /// </summary>
        public Exception Error { get; internal set; }

        #endregion

        #region Fields

        private string _endpoint;
        private DateTime? _start;
        private DateTime? _stop;

        #endregion

        #region Methods

        /// <summary>
        /// Get the service endpoint found in ServiceEndpoints constants
        /// </summary>
        /// <returns></returns>
        internal string GetEndpoint() => _endpoint;

        /// <summary>
        /// Get the service specific query parameters for the URL
        /// </summary>
        /// <returns></returns>
        internal abstract string GetQueryParameters();

        /// <summary>
        /// Method called when the process to consume the service begins
        /// </summary>
        internal void Begin()
        {
            _start = DateTime.UtcNow;
            _stop = null;
        }

        /// <summary>
        /// Method called when the process to consume the service finishes
        /// </summary>
        internal void Finish()
        {
            _stop = DateTime.UtcNow;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for base api service
        /// </summary>
        /// <param name="endpoint">service enpoint found in ServiceEndpoints constants</param>
        internal BaseService(string endpoint)
        {
            _endpoint = endpoint;
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Format "ids" query parameter
        /// </summary>
        /// <param name="ids">collection of ids</param>
        /// <returns>query parameter as string, including "&amp;ids="</returns>
        protected static string FormatIds(IEnumerable<string> ids)
        {
            return (ids == null || !ids.Any()) ? "" : ("&ids=" + string.Join(",", ids.Select(t => "'" + t + "'")));
        }

        #endregion
    }
}
