
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// The region where the repository is hosted.
    /// </summary>
    public enum CreateReposCreateRequestVariant3Region
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
    public static class CreateReposCreateRequestVariant3RegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant3Region value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant3Region.Eu => "eu",
                CreateReposCreateRequestVariant3Region.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant3Region? ToEnum(string value)
        {
            return value switch
            {
                "eu" => CreateReposCreateRequestVariant3Region.Eu,
                "us" => CreateReposCreateRequestVariant3Region.Us,
                _ => null,
            };
        }
    }
}