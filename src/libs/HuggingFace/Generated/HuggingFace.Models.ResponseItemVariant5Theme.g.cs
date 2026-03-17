
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant5Theme
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
    public static class ResponseItemVariant5ThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant5Theme value)
        {
            return value switch
            {
                ResponseItemVariant5Theme.Orange => "orange",
                ResponseItemVariant5Theme.Blue => "blue",
                ResponseItemVariant5Theme.Green => "green",
                ResponseItemVariant5Theme.Purple => "purple",
                ResponseItemVariant5Theme.Pink => "pink",
                ResponseItemVariant5Theme.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant5Theme? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseItemVariant5Theme.Orange,
                "blue" => ResponseItemVariant5Theme.Blue,
                "green" => ResponseItemVariant5Theme.Green,
                "purple" => ResponseItemVariant5Theme.Purple,
                "pink" => ResponseItemVariant5Theme.Pink,
                "indigo" => ResponseItemVariant5Theme.Indigo,
                _ => null,
            };
        }
    }
}