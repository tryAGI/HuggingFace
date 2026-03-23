
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQuicksearchRequestTypeVariant1Item
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
    public static class CreateQuicksearchRequestTypeVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchRequestTypeVariant1Item value)
        {
            return value switch
            {
                CreateQuicksearchRequestTypeVariant1Item.Bucket => "bucket",
                CreateQuicksearchRequestTypeVariant1Item.Collection => "collection",
                CreateQuicksearchRequestTypeVariant1Item.Dataset => "dataset",
                CreateQuicksearchRequestTypeVariant1Item.Model => "model",
                CreateQuicksearchRequestTypeVariant1Item.Org => "org",
                CreateQuicksearchRequestTypeVariant1Item.Paper => "paper",
                CreateQuicksearchRequestTypeVariant1Item.Space => "space",
                CreateQuicksearchRequestTypeVariant1Item.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchRequestTypeVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateQuicksearchRequestTypeVariant1Item.Bucket,
                "collection" => CreateQuicksearchRequestTypeVariant1Item.Collection,
                "dataset" => CreateQuicksearchRequestTypeVariant1Item.Dataset,
                "model" => CreateQuicksearchRequestTypeVariant1Item.Model,
                "org" => CreateQuicksearchRequestTypeVariant1Item.Org,
                "paper" => CreateQuicksearchRequestTypeVariant1Item.Paper,
                "space" => CreateQuicksearchRequestTypeVariant1Item.Space,
                "user" => CreateQuicksearchRequestTypeVariant1Item.User,
                _ => null,
            };
        }
    }
}