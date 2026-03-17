
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemTheme
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
    public static class ResponseVariant1ItemThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemTheme value)
        {
            return value switch
            {
                ResponseVariant1ItemTheme.Orange => "orange",
                ResponseVariant1ItemTheme.Blue => "blue",
                ResponseVariant1ItemTheme.Green => "green",
                ResponseVariant1ItemTheme.Purple => "purple",
                ResponseVariant1ItemTheme.Pink => "pink",
                ResponseVariant1ItemTheme.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemTheme? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseVariant1ItemTheme.Orange,
                "blue" => ResponseVariant1ItemTheme.Blue,
                "green" => ResponseVariant1ItemTheme.Green,
                "purple" => ResponseVariant1ItemTheme.Purple,
                "pink" => ResponseVariant1ItemTheme.Pink,
                "indigo" => ResponseVariant1ItemTheme.Indigo,
                _ => null,
            };
        }
    }
}