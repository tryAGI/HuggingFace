
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant5Theme4
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
    public static class ResponseItemVariant5Theme4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant5Theme4 value)
        {
            return value switch
            {
                ResponseItemVariant5Theme4.Orange => "orange",
                ResponseItemVariant5Theme4.Blue => "blue",
                ResponseItemVariant5Theme4.Green => "green",
                ResponseItemVariant5Theme4.Purple => "purple",
                ResponseItemVariant5Theme4.Pink => "pink",
                ResponseItemVariant5Theme4.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant5Theme4? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseItemVariant5Theme4.Orange,
                "blue" => ResponseItemVariant5Theme4.Blue,
                "green" => ResponseItemVariant5Theme4.Green,
                "purple" => ResponseItemVariant5Theme4.Purple,
                "pink" => ResponseItemVariant5Theme4.Pink,
                "indigo" => ResponseItemVariant5Theme4.Indigo,
                _ => null,
            };
        }
    }
}