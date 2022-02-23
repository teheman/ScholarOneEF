namespace ScholarOne
{
    /// <summary>
    /// The ScholarOne environments for services
    /// </summary>
    public enum EnvironmentEnum
    {
        Integration,
        Production
    }

    /// <summary>
    /// The response types available from scholar one services
    /// </summary>
    public enum ResponseTypeEnum
    {
        xml,
        json
    }

    /// <summary>
    /// The locale_id values available from scholar one services
    /// </summary>
    public enum LocaleIdEnum
    {
        English = 1,
        Chinese = 2,
        French = 3
    }
}
