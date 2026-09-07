
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces. Cannot be specified along with private.
    /// </summary>
    public enum CreateReposCreateRequestVariant1Visibility
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
    public static class CreateReposCreateRequestVariant1VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant1Visibility value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant1Visibility.Private => "private",
                CreateReposCreateRequestVariant1Visibility.Protected => "protected",
                CreateReposCreateRequestVariant1Visibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant1Visibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateReposCreateRequestVariant1Visibility.Private,
                "protected" => CreateReposCreateRequestVariant1Visibility.Protected,
                "public" => CreateReposCreateRequestVariant1Visibility.Public,
                _ => null,
            };
        }
    }
}