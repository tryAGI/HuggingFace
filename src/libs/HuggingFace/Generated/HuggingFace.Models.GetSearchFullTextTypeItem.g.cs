
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSearchFullTextTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        Bucket,
        /// <summary>
        ///
        /// </summary>
        Dataset,
        /// <summary>
        ///
        /// </summary>
        Kernel,
        /// <summary>
        ///
        /// </summary>
        Model,
        /// <summary>
        ///
        /// </summary>
        Space,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSearchFullTextTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSearchFullTextTypeItem value)
        {
            return value switch
            {
                GetSearchFullTextTypeItem.Bucket => "bucket",
                GetSearchFullTextTypeItem.Dataset => "dataset",
                GetSearchFullTextTypeItem.Kernel => "kernel",
                GetSearchFullTextTypeItem.Model => "model",
                GetSearchFullTextTypeItem.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSearchFullTextTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetSearchFullTextTypeItem.Bucket,
                "dataset" => GetSearchFullTextTypeItem.Dataset,
                "kernel" => GetSearchFullTextTypeItem.Kernel,
                "model" => GetSearchFullTextTypeItem.Model,
                "space" => GetSearchFullTextTypeItem.Space,
                _ => null,
            };
        }
    }
}