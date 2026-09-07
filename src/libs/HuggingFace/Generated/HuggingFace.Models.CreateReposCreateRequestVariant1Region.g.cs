
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// The region where the repository is hosted.
    /// </summary>
    public enum CreateReposCreateRequestVariant1Region
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
    public static class CreateReposCreateRequestVariant1RegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant1Region value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant1Region.Eu => "eu",
                CreateReposCreateRequestVariant1Region.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant1Region? ToEnum(string value)
        {
            return value switch
            {
                "eu" => CreateReposCreateRequestVariant1Region.Eu,
                "us" => CreateReposCreateRequestVariant1Region.Us,
                _ => null,
            };
        }
    }
}