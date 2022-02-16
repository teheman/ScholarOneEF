using System.Collections.Generic;
using System.Linq;

namespace ScholarOneEF.Models
{
    /// <summary>
    /// Service that takes document or submission ids as its parameter
    /// </summary>
    public abstract class BaseIdsServiceResult : BaseServiceResult
    {
        private string _queryString;

        internal override string GetQueryParameters() => _queryString;

        internal BaseIdsServiceResult(IEnumerable<string> ids, string endPoint) : base(endPoint)
        {
            _queryString = FormatIds(ids);
        }

        /// <summary>
        /// Format "ids" query parameter
        /// </summary>
        /// <param name="ids">collection of ids</param>
        /// <returns>query parameter as string, including "&amp;ids="</returns>
        private static string FormatIds(IEnumerable<string> ids)
        {
            return (ids == null || !ids.Any()) ? "" : ("&ids=" + string.Join(",", ids.Select(t => "'" + t + "'")));
        }
    }
}
