
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetQuicksearchTypeVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        Bucket,
        /// <summary>
        /// 
        /// </summary>
        Collection,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        Paper,
        /// <summary>
        /// 
        /// </summary>
        Space,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetQuicksearchTypeVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetQuicksearchTypeVariant1Item value)
        {
            return value switch
            {
                GetQuicksearchTypeVariant1Item.Bucket => "bucket",
                GetQuicksearchTypeVariant1Item.Collection => "collection",
                GetQuicksearchTypeVariant1Item.Dataset => "dataset",
                GetQuicksearchTypeVariant1Item.Model => "model",
                GetQuicksearchTypeVariant1Item.Org => "org",
                GetQuicksearchTypeVariant1Item.Paper => "paper",
                GetQuicksearchTypeVariant1Item.Space => "space",
                GetQuicksearchTypeVariant1Item.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetQuicksearchTypeVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetQuicksearchTypeVariant1Item.Bucket,
                "collection" => GetQuicksearchTypeVariant1Item.Collection,
                "dataset" => GetQuicksearchTypeVariant1Item.Dataset,
                "model" => GetQuicksearchTypeVariant1Item.Model,
                "org" => GetQuicksearchTypeVariant1Item.Org,
                "paper" => GetQuicksearchTypeVariant1Item.Paper,
                "space" => GetQuicksearchTypeVariant1Item.Space,
                "user" => GetQuicksearchTypeVariant1Item.User,
                _ => null,
            };
        }
    }
}