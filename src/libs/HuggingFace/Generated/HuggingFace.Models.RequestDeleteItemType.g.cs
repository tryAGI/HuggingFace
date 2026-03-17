
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestDeleteItemType
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
    public static class RequestDeleteItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestDeleteItemType value)
        {
            return value switch
            {
                RequestDeleteItemType.Org => "org",
                RequestDeleteItemType.User => "user",
                RequestDeleteItemType.Repo => "repo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestDeleteItemType? ToEnum(string value)
        {
            return value switch
            {
                "org" => RequestDeleteItemType.Org,
                "user" => RequestDeleteItemType.User,
                "repo" => RequestDeleteItemType.Repo,
                _ => null,
            };
        }
    }
}