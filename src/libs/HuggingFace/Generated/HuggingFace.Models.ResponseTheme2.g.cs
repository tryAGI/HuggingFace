
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseTheme2
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
    public static class ResponseTheme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTheme2 value)
        {
            return value switch
            {
                ResponseTheme2.Orange => "orange",
                ResponseTheme2.Blue => "blue",
                ResponseTheme2.Green => "green",
                ResponseTheme2.Purple => "purple",
                ResponseTheme2.Pink => "pink",
                ResponseTheme2.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTheme2? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseTheme2.Orange,
                "blue" => ResponseTheme2.Blue,
                "green" => ResponseTheme2.Green,
                "purple" => ResponseTheme2.Purple,
                "pink" => ResponseTheme2.Pink,
                "indigo" => ResponseTheme2.Indigo,
                _ => null,
            };
        }
    }
}