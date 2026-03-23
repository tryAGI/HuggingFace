
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetDiscussionsType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Discussion,
        /// <summary>
        /// 
        /// </summary>
        PullRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDiscussionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsType value)
        {
            return value switch
            {
                GetDiscussionsType.All => "all",
                GetDiscussionsType.Discussion => "discussion",
                GetDiscussionsType.PullRequest => "pull_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetDiscussionsType.All,
                "discussion" => GetDiscussionsType.Discussion,
                "pull_request" => GetDiscussionsType.PullRequest,
                _ => null,
            };
        }
    }
}