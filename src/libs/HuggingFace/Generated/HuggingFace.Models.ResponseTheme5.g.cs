
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseTheme5
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
    public static class ResponseTheme5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTheme5 value)
        {
            return value switch
            {
                ResponseTheme5.Orange => "orange",
                ResponseTheme5.Blue => "blue",
                ResponseTheme5.Green => "green",
                ResponseTheme5.Purple => "purple",
                ResponseTheme5.Pink => "pink",
                ResponseTheme5.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTheme5? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseTheme5.Orange,
                "blue" => ResponseTheme5.Blue,
                "green" => ResponseTheme5.Green,
                "purple" => ResponseTheme5.Purple,
                "pink" => ResponseTheme5.Pink,
                "indigo" => ResponseTheme5.Indigo,
                _ => null,
            };
        }
    }
}