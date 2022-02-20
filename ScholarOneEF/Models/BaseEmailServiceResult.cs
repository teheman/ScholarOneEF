namespace ScholarOneEF.Models
{
    /// <summary>
    /// Service that takes primary email as its parameter
    /// </summary>
    public abstract class BaseEmailServiceResult : BaseServiceResult
    {
        private readonly string _queryString;

        internal override string GetQueryParameters() => _queryString;

        internal BaseEmailServiceResult(string email, string endPoint) : base(endPoint)
        {
            _queryString = string.IsNullOrWhiteSpace(email)
                ? ""
                : "&primary_email=" + email;
        }
    }
}
