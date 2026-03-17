
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// `remove` operation is not supported for non-managed organizations
    /// </summary>
    public enum RequestOperationOp
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Remove,
        /// <summary>
        /// 
        /// </summary>
        Replace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestOperationOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestOperationOp value)
        {
            return value switch
            {
                RequestOperationOp.Add => "add",
                RequestOperationOp.Remove => "remove",
                RequestOperationOp.Replace => "replace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestOperationOp? ToEnum(string value)
        {
            return value switch
            {
                "add" => RequestOperationOp.Add,
                "remove" => RequestOperationOp.Remove,
                "replace" => RequestOperationOp.Replace,
                _ => null,
            };
        }
    }
}