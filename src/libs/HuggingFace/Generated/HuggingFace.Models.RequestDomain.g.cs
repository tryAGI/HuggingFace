
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestDomain
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
    public static class RequestDomainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestDomain value)
        {
            return value switch
            {
                RequestDomain.Repo => "repo",
                RequestDomain.Discussion => "discussion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestDomain? ToEnum(string value)
        {
            return value switch
            {
                "repo" => RequestDomain.Repo,
                "discussion" => RequestDomain.Discussion,
                _ => null,
            };
        }
    }
}