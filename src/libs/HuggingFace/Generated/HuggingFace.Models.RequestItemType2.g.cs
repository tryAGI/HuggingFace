
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestItemType2
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
    public static class RequestItemType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestItemType2 value)
        {
            return value switch
            {
                RequestItemType2.Paper => "paper",
                RequestItemType2.Collection => "collection",
                RequestItemType2.Space => "space",
                RequestItemType2.Model => "model",
                RequestItemType2.Dataset => "dataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestItemType2? ToEnum(string value)
        {
            return value switch
            {
                "paper" => RequestItemType2.Paper,
                "collection" => RequestItemType2.Collection,
                "space" => RequestItemType2.Space,
                "model" => RequestItemType2.Model,
                "dataset" => RequestItemType2.Dataset,
                _ => null,
            };
        }
    }
}