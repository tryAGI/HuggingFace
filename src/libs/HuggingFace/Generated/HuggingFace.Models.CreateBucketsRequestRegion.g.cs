
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// The region where the bucket is hosted.
    /// </summary>
    public enum CreateBucketsRequestRegion
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
    public static class CreateBucketsRequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBucketsRequestRegion value)
        {
            return value switch
            {
                CreateBucketsRequestRegion.Eu => "eu",
                CreateBucketsRequestRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBucketsRequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => CreateBucketsRequestRegion.Eu,
                "us" => CreateBucketsRequestRegion.Us,
                _ => null,
            };
        }
    }
}