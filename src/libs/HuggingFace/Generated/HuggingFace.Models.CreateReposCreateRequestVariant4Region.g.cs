
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// The region where the repository is hosted.
    /// </summary>
    public enum CreateReposCreateRequestVariant4Region
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
    public static class CreateReposCreateRequestVariant4RegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant4Region value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant4Region.Eu => "eu",
                CreateReposCreateRequestVariant4Region.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant4Region? ToEnum(string value)
        {
            return value switch
            {
                "eu" => CreateReposCreateRequestVariant4Region.Eu,
                "us" => CreateReposCreateRequestVariant4Region.Us,
                _ => null,
            };
        }
    }
}