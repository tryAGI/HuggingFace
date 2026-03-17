
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataTheme
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
    public static class ResponseDataThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataTheme value)
        {
            return value switch
            {
                ResponseDataTheme.Orange => "orange",
                ResponseDataTheme.Blue => "blue",
                ResponseDataTheme.Green => "green",
                ResponseDataTheme.Purple => "purple",
                ResponseDataTheme.Pink => "pink",
                ResponseDataTheme.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataTheme? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseDataTheme.Orange,
                "blue" => ResponseDataTheme.Blue,
                "green" => ResponseDataTheme.Green,
                "purple" => ResponseDataTheme.Purple,
                "pink" => ResponseDataTheme.Pink,
                "indigo" => ResponseDataTheme.Indigo,
                _ => null,
            };
        }
    }
}