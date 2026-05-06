
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBucketsRequestCdnItemProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Aws,
        /// <summary>
        /// 
        /// </summary>
        Gcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBucketsRequestCdnItemProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBucketsRequestCdnItemProvider value)
        {
            return value switch
            {
                CreateBucketsRequestCdnItemProvider.Aws => "aws",
                CreateBucketsRequestCdnItemProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBucketsRequestCdnItemProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => CreateBucketsRequestCdnItemProvider.Aws,
                "gcp" => CreateBucketsRequestCdnItemProvider.Gcp,
                _ => null,
            };
        }
    }
}