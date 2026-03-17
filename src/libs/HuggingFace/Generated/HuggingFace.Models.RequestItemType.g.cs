
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestItemType
    {
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
        Space,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestItemType value)
        {
            return value switch
            {
                RequestItemType.Paper => "paper",
                RequestItemType.Collection => "collection",
                RequestItemType.Space => "space",
                RequestItemType.Model => "model",
                RequestItemType.Dataset => "dataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestItemType? ToEnum(string value)
        {
            return value switch
            {
                "paper" => RequestItemType.Paper,
                "collection" => RequestItemType.Collection,
                "space" => RequestItemType.Space,
                "model" => RequestItemType.Model,
                "dataset" => RequestItemType.Dataset,
                _ => null,
            };
        }
    }
}