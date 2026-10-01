
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Bucket visibility. Cannot be specified along with private.
    /// </summary>
    public enum CreateBucketsRequestVisibility
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
    public static class CreateBucketsRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBucketsRequestVisibility value)
        {
            return value switch
            {
                CreateBucketsRequestVisibility.Private => "private",
                CreateBucketsRequestVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBucketsRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateBucketsRequestVisibility.Private,
                "public" => CreateBucketsRequestVisibility.Public,
                _ => null,
            };
        }
    }
}