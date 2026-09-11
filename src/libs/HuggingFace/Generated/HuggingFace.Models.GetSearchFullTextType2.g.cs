
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSearchFullTextType2
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
    public static class GetSearchFullTextType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSearchFullTextType2 value)
        {
            return value switch
            {
                GetSearchFullTextType2.Bucket => "bucket",
                GetSearchFullTextType2.Dataset => "dataset",
                GetSearchFullTextType2.Kernel => "kernel",
                GetSearchFullTextType2.Model => "model",
                GetSearchFullTextType2.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSearchFullTextType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetSearchFullTextType2.Bucket,
                "dataset" => GetSearchFullTextType2.Dataset,
                "kernel" => GetSearchFullTextType2.Kernel,
                "model" => GetSearchFullTextType2.Model,
                "space" => GetSearchFullTextType2.Space,
                _ => null,
            };
        }
    }
}