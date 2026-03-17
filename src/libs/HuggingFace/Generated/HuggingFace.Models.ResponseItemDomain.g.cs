
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemDomain
    {
        /// <summary>
        /// 
        /// </summary>
        Repo,
        /// <summary>
        /// 
        /// </summary>
        Discussion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemDomainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemDomain value)
        {
            return value switch
            {
                ResponseItemDomain.Repo => "repo",
                ResponseItemDomain.Discussion => "discussion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemDomain? ToEnum(string value)
        {
            return value switch
            {
                "repo" => ResponseItemDomain.Repo,
                "discussion" => ResponseItemDomain.Discussion,
                _ => null,
            };
        }
    }
}