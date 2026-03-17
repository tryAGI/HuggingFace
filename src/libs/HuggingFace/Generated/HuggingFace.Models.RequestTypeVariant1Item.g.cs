
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestTypeVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Space,
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Paper,
        /// <summary>
        /// 
        /// </summary>
        Collection,
        /// <summary>
        /// 
        /// </summary>
        Bucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestTypeVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTypeVariant1Item value)
        {
            return value switch
            {
                RequestTypeVariant1Item.Model => "model",
                RequestTypeVariant1Item.Dataset => "dataset",
                RequestTypeVariant1Item.Space => "space",
                RequestTypeVariant1Item.Org => "org",
                RequestTypeVariant1Item.User => "user",
                RequestTypeVariant1Item.Paper => "paper",
                RequestTypeVariant1Item.Collection => "collection",
                RequestTypeVariant1Item.Bucket => "bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestTypeVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "model" => RequestTypeVariant1Item.Model,
                "dataset" => RequestTypeVariant1Item.Dataset,
                "space" => RequestTypeVariant1Item.Space,
                "org" => RequestTypeVariant1Item.Org,
                "user" => RequestTypeVariant1Item.User,
                "paper" => RequestTypeVariant1Item.Paper,
                "collection" => RequestTypeVariant1Item.Collection,
                "bucket" => RequestTypeVariant1Item.Bucket,
                _ => null,
            };
        }
    }
}