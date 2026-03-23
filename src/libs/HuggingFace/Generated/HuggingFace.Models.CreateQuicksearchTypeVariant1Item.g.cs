
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQuicksearchTypeVariant1Item
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
    public static class CreateQuicksearchTypeVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchTypeVariant1Item value)
        {
            return value switch
            {
                CreateQuicksearchTypeVariant1Item.Bucket => "bucket",
                CreateQuicksearchTypeVariant1Item.Collection => "collection",
                CreateQuicksearchTypeVariant1Item.Dataset => "dataset",
                CreateQuicksearchTypeVariant1Item.Model => "model",
                CreateQuicksearchTypeVariant1Item.Org => "org",
                CreateQuicksearchTypeVariant1Item.Paper => "paper",
                CreateQuicksearchTypeVariant1Item.Space => "space",
                CreateQuicksearchTypeVariant1Item.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchTypeVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateQuicksearchTypeVariant1Item.Bucket,
                "collection" => CreateQuicksearchTypeVariant1Item.Collection,
                "dataset" => CreateQuicksearchTypeVariant1Item.Dataset,
                "model" => CreateQuicksearchTypeVariant1Item.Model,
                "org" => CreateQuicksearchTypeVariant1Item.Org,
                "paper" => CreateQuicksearchTypeVariant1Item.Paper,
                "space" => CreateQuicksearchTypeVariant1Item.Space,
                "user" => CreateQuicksearchTypeVariant1Item.User,
                _ => null,
            };
        }
    }
}