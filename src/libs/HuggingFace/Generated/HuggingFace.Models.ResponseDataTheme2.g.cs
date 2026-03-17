
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataTheme2
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
    public static class ResponseDataTheme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataTheme2 value)
        {
            return value switch
            {
                ResponseDataTheme2.Orange => "orange",
                ResponseDataTheme2.Blue => "blue",
                ResponseDataTheme2.Green => "green",
                ResponseDataTheme2.Purple => "purple",
                ResponseDataTheme2.Pink => "pink",
                ResponseDataTheme2.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataTheme2? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseDataTheme2.Orange,
                "blue" => ResponseDataTheme2.Blue,
                "green" => ResponseDataTheme2.Green,
                "purple" => ResponseDataTheme2.Purple,
                "pink" => ResponseDataTheme2.Pink,
                "indigo" => ResponseDataTheme2.Indigo,
                _ => null,
            };
        }
    }
}