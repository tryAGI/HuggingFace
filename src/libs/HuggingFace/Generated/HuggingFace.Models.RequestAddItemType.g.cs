
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestAddItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Repo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestAddItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestAddItemType value)
        {
            return value switch
            {
                RequestAddItemType.Org => "org",
                RequestAddItemType.User => "user",
                RequestAddItemType.Repo => "repo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestAddItemType? ToEnum(string value)
        {
            return value switch
            {
                "org" => RequestAddItemType.Org,
                "user" => RequestAddItemType.User,
                "repo" => RequestAddItemType.Repo,
                _ => null,
            };
        }
    }
}