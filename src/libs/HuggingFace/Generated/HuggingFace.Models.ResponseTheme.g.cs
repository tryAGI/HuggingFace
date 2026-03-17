
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseTheme
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
    public static class ResponseThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTheme value)
        {
            return value switch
            {
                ResponseTheme.Orange => "orange",
                ResponseTheme.Blue => "blue",
                ResponseTheme.Green => "green",
                ResponseTheme.Purple => "purple",
                ResponseTheme.Pink => "pink",
                ResponseTheme.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTheme? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseTheme.Orange,
                "blue" => ResponseTheme.Blue,
                "green" => ResponseTheme.Green,
                "purple" => ResponseTheme.Purple,
                "pink" => ResponseTheme.Pink,
                "indigo" => ResponseTheme.Indigo,
                _ => null,
            };
        }
    }
}