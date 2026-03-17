
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant5Theme
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
    public static class ResponseVariant1ItemItemVariant5ThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant5Theme value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant5Theme.Orange => "orange",
                ResponseVariant1ItemItemVariant5Theme.Blue => "blue",
                ResponseVariant1ItemItemVariant5Theme.Green => "green",
                ResponseVariant1ItemItemVariant5Theme.Purple => "purple",
                ResponseVariant1ItemItemVariant5Theme.Pink => "pink",
                ResponseVariant1ItemItemVariant5Theme.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant5Theme? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseVariant1ItemItemVariant5Theme.Orange,
                "blue" => ResponseVariant1ItemItemVariant5Theme.Blue,
                "green" => ResponseVariant1ItemItemVariant5Theme.Green,
                "purple" => ResponseVariant1ItemItemVariant5Theme.Purple,
                "pink" => ResponseVariant1ItemItemVariant5Theme.Pink,
                "indigo" => ResponseVariant1ItemItemVariant5Theme.Indigo,
                _ => null,
            };
        }
    }
}