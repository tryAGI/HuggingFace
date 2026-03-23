
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces. Cannot be specified along with private.
    /// </summary>
    public enum CreateReposCreateRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Protected,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateReposCreateRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVisibility value)
        {
            return value switch
            {
                CreateReposCreateRequestVisibility.Private => "private",
                CreateReposCreateRequestVisibility.Protected => "protected",
                CreateReposCreateRequestVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateReposCreateRequestVisibility.Private,
                "protected" => CreateReposCreateRequestVisibility.Protected,
                "public" => CreateReposCreateRequestVisibility.Public,
                _ => null,
            };
        }
    }
}