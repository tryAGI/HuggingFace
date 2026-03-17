
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant5Theme3
    {
        /// <summary>
        /// 
        /// </summary>
        Orange,
        /// <summary>
        /// 
        /// </summary>
        Blue,
        /// <summary>
        /// 
        /// </summary>
        Green,
        /// <summary>
        /// 
        /// </summary>
        Purple,
        /// <summary>
        /// 
        /// </summary>
        Pink,
        /// <summary>
        /// 
        /// </summary>
        Indigo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemVariant5Theme3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant5Theme3 value)
        {
            return value switch
            {
                ResponseItemVariant5Theme3.Orange => "orange",
                ResponseItemVariant5Theme3.Blue => "blue",
                ResponseItemVariant5Theme3.Green => "green",
                ResponseItemVariant5Theme3.Purple => "purple",
                ResponseItemVariant5Theme3.Pink => "pink",
                ResponseItemVariant5Theme3.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant5Theme3? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseItemVariant5Theme3.Orange,
                "blue" => ResponseItemVariant5Theme3.Blue,
                "green" => ResponseItemVariant5Theme3.Green,
                "purple" => ResponseItemVariant5Theme3.Purple,
                "pink" => ResponseItemVariant5Theme3.Pink,
                "indigo" => ResponseItemVariant5Theme3.Indigo,
                _ => null,
            };
        }
    }
}