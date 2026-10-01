
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Bucket visibility. Cannot be specified along with private.
    /// </summary>
    public enum CreateContainersRequestVisibility
    {
        /// <summary>
        ///
        /// </summary>
        Private,
        /// <summary>
        ///
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateContainersRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContainersRequestVisibility value)
        {
            return value switch
            {
                CreateContainersRequestVisibility.Private => "private",
                CreateContainersRequestVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContainersRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateContainersRequestVisibility.Private,
                "public" => CreateContainersRequestVisibility.Public,
                _ => null,
            };
        }
    }
}