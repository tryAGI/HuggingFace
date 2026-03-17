
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestItemType3
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
    public static class RequestItemType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestItemType3 value)
        {
            return value switch
            {
                RequestItemType3.Paper => "paper",
                RequestItemType3.Collection => "collection",
                RequestItemType3.Space => "space",
                RequestItemType3.Model => "model",
                RequestItemType3.Dataset => "dataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestItemType3? ToEnum(string value)
        {
            return value switch
            {
                "paper" => RequestItemType3.Paper,
                "collection" => RequestItemType3.Collection,
                "space" => RequestItemType3.Space,
                "model" => RequestItemType3.Model,
                "dataset" => RequestItemType3.Dataset,
                _ => null,
            };
        }
    }
}