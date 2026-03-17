
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseTheme3
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
    public static class ResponseTheme3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTheme3 value)
        {
            return value switch
            {
                ResponseTheme3.Orange => "orange",
                ResponseTheme3.Blue => "blue",
                ResponseTheme3.Green => "green",
                ResponseTheme3.Purple => "purple",
                ResponseTheme3.Pink => "pink",
                ResponseTheme3.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTheme3? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseTheme3.Orange,
                "blue" => ResponseTheme3.Blue,
                "green" => ResponseTheme3.Green,
                "purple" => ResponseTheme3.Purple,
                "pink" => ResponseTheme3.Pink,
                "indigo" => ResponseTheme3.Indigo,
                _ => null,
            };
        }
    }
}