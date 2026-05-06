
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBucketsRequestCdnItemRegion
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
    public static class CreateBucketsRequestCdnItemRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBucketsRequestCdnItemRegion value)
        {
            return value switch
            {
                CreateBucketsRequestCdnItemRegion.Eu => "eu",
                CreateBucketsRequestCdnItemRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBucketsRequestCdnItemRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => CreateBucketsRequestCdnItemRegion.Eu,
                "us" => CreateBucketsRequestCdnItemRegion.Us,
                _ => null,
            };
        }
    }
}