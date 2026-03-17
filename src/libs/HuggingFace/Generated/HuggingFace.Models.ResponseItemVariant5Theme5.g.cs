
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant5Theme5
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
    public static class ResponseItemVariant5Theme5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant5Theme5 value)
        {
            return value switch
            {
                ResponseItemVariant5Theme5.Orange => "orange",
                ResponseItemVariant5Theme5.Blue => "blue",
                ResponseItemVariant5Theme5.Green => "green",
                ResponseItemVariant5Theme5.Purple => "purple",
                ResponseItemVariant5Theme5.Pink => "pink",
                ResponseItemVariant5Theme5.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant5Theme5? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseItemVariant5Theme5.Orange,
                "blue" => ResponseItemVariant5Theme5.Blue,
                "green" => ResponseItemVariant5Theme5.Green,
                "purple" => ResponseItemVariant5Theme5.Purple,
                "pink" => ResponseItemVariant5Theme5.Pink,
                "indigo" => ResponseItemVariant5Theme5.Indigo,
                _ => null,
            };
        }
    }
}