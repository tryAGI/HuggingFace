
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateContainersRequestCdnItemProvider
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
    public static class CreateContainersRequestCdnItemProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContainersRequestCdnItemProvider value)
        {
            return value switch
            {
                CreateContainersRequestCdnItemProvider.Aws => "aws",
                CreateContainersRequestCdnItemProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContainersRequestCdnItemProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => CreateContainersRequestCdnItemProvider.Aws,
                "gcp" => CreateContainersRequestCdnItemProvider.Gcp,
                _ => null,
            };
        }
    }
}