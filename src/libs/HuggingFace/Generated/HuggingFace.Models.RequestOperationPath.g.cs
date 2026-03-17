
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestOperationPath
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
        EmailstypeEqworkValue,
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
    public static class RequestOperationPathExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestOperationPath value)
        {
            return value switch
            {
                RequestOperationPath.Active => "active",
                RequestOperationPath.ExternalId => "externalId",
                RequestOperationPath.UserName => "userName",
                RequestOperationPath.EmailstypeEqworkValue => "emails[type eq 'work'].value",
                RequestOperationPath.NameGivenName => "name.givenName",
                RequestOperationPath.NameFamilyName => "name.familyName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestOperationPath? ToEnum(string value)
        {
            return value switch
            {
                "active" => RequestOperationPath.Active,
                "externalId" => RequestOperationPath.ExternalId,
                "userName" => RequestOperationPath.UserName,
                "emails[type eq 'work'].value" => RequestOperationPath.EmailstypeEqworkValue,
                "name.givenName" => RequestOperationPath.NameGivenName,
                "name.familyName" => RequestOperationPath.NameFamilyName,
                _ => null,
            };
        }
    }
}