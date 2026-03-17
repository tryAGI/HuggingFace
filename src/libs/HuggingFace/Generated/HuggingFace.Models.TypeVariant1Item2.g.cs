
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum TypeVariant1Item2
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
    public static class TypeVariant1Item2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TypeVariant1Item2 value)
        {
            return value switch
            {
                TypeVariant1Item2.Model => "model",
                TypeVariant1Item2.Dataset => "dataset",
                TypeVariant1Item2.Space => "space",
                TypeVariant1Item2.Org => "org",
                TypeVariant1Item2.User => "user",
                TypeVariant1Item2.Paper => "paper",
                TypeVariant1Item2.Collection => "collection",
                TypeVariant1Item2.Bucket => "bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TypeVariant1Item2? ToEnum(string value)
        {
            return value switch
            {
                "model" => TypeVariant1Item2.Model,
                "dataset" => TypeVariant1Item2.Dataset,
                "space" => TypeVariant1Item2.Space,
                "org" => TypeVariant1Item2.Org,
                "user" => TypeVariant1Item2.User,
                "paper" => TypeVariant1Item2.Paper,
                "collection" => TypeVariant1Item2.Collection,
                "bucket" => TypeVariant1Item2.Bucket,
                _ => null,
            };
        }
    }
}