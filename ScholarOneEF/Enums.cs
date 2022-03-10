namespace ScholarOne
{
    /// <summary>
    /// The ScholarOne environments for services
    /// </summary>
    public enum EnvironmentEnum
    {
        /// <summary>
        /// Specifies ScholarOne integration environment for development
        /// </summary>
        Integration,
        /// <summary>
        /// Specifies ScholarOne production environment
        /// </summary>
        Production
    }

    /// <summary>
    /// The response types available from scholar one services
    /// </summary>
    public enum ResponseTypeEnum
    {
        /// <summary>
        /// Specifies XML response from ScholarOne
        /// </summary>
        xml,
        /// <summary>
        /// Specifies JSON response from ScholarOne
        /// </summary>
        json
    }

    /// <summary>
    /// The locale_id values available from scholar one services
    /// </summary>
    public enum LocaleIdEnum
    {
        /// <summary>
        /// Specifies English as the account language
        /// </summary>
        English = 1,
        /// <summary>
        /// Specifies Chinese as the account language
        /// </summary>
        Chinese = 2,
        /// <summary>
        /// Specifies French as the account language
        /// </summary>
        French = 3
    }
}
