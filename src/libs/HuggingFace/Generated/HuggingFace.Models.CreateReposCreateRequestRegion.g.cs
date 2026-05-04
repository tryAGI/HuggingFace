
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// The region where the repository is hosted.
    /// </summary>
    public enum CreateReposCreateRequestRegion
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
    public static class CreateReposCreateRequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestRegion value)
        {
            return value switch
            {
                CreateReposCreateRequestRegion.Eu => "eu",
                CreateReposCreateRequestRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => CreateReposCreateRequestRegion.Eu,
                "us" => CreateReposCreateRequestRegion.Us,
                _ => null,
            };
        }
    }
}