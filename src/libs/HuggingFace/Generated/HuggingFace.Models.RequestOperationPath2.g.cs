
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestOperationPath2
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        ExternalId,
        /// <summary>
        /// 
        /// </summary>
        UserName,
        /// <summary>
        /// 
        /// </summary>
        EmailstypeEq_work_Value,
        /// <summary>
        /// 
        /// </summary>
        NameGivenName,
        /// <summary>
        /// 
        /// </summary>
        NameFamilyName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestOperationPath2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestOperationPath2 value)
        {
            return value switch
            {
                RequestOperationPath2.Active => "active",
                RequestOperationPath2.ExternalId => "externalId",
                RequestOperationPath2.UserName => "userName",
                RequestOperationPath2.EmailstypeEq_work_Value => "emails[type eq "work"].value",
                RequestOperationPath2.NameGivenName => "name.givenName",
                RequestOperationPath2.NameFamilyName => "name.familyName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestOperationPath2? ToEnum(string value)
        {
            return value switch
            {
                "active" => RequestOperationPath2.Active,
                "externalId" => RequestOperationPath2.ExternalId,
                "userName" => RequestOperationPath2.UserName,
                "emails[type eq "work"].value" => RequestOperationPath2.EmailstypeEq_work_Value,
                "name.givenName" => RequestOperationPath2.NameGivenName,
                "name.familyName" => RequestOperationPath2.NameFamilyName,
                _ => null,
            };
        }
    }
}