
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// The region where the repository is hosted.
    /// </summary>
    public enum CreateReposCreateRequestVariant2Region
    {
        /// <summary>
        ///
        /// </summary>
        Eu,
        /// <summary>
        ///
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateReposCreateRequestVariant2RegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant2Region value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant2Region.Eu => "eu",
                CreateReposCreateRequestVariant2Region.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant2Region? ToEnum(string value)
        {
            return value switch
            {
                "eu" => CreateReposCreateRequestVariant2Region.Eu,
                "us" => CreateReposCreateRequestVariant2Region.Us,
                _ => null,
            };
        }
    }
}