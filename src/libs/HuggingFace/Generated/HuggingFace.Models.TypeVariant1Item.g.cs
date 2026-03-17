
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum TypeVariant1Item
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
    public static class TypeVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TypeVariant1Item value)
        {
            return value switch
            {
                TypeVariant1Item.Model => "model",
                TypeVariant1Item.Dataset => "dataset",
                TypeVariant1Item.Space => "space",
                TypeVariant1Item.Org => "org",
                TypeVariant1Item.User => "user",
                TypeVariant1Item.Paper => "paper",
                TypeVariant1Item.Collection => "collection",
                TypeVariant1Item.Bucket => "bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TypeVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "model" => TypeVariant1Item.Model,
                "dataset" => TypeVariant1Item.Dataset,
                "space" => TypeVariant1Item.Space,
                "org" => TypeVariant1Item.Org,
                "user" => TypeVariant1Item.User,
                "paper" => TypeVariant1Item.Paper,
                "collection" => TypeVariant1Item.Collection,
                "bucket" => TypeVariant1Item.Bucket,
                _ => null,
            };
        }
    }
}