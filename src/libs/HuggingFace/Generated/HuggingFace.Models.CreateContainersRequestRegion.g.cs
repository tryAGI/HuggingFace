
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// The region where the bucket is hosted.
    /// </summary>
    public enum CreateContainersRequestRegion
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
    public static class CreateContainersRequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContainersRequestRegion value)
        {
            return value switch
            {
                CreateContainersRequestRegion.Eu => "eu",
                CreateContainersRequestRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContainersRequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => CreateContainersRequestRegion.Eu,
                "us" => CreateContainersRequestRegion.Us,
                _ => null,
            };
        }
    }
}