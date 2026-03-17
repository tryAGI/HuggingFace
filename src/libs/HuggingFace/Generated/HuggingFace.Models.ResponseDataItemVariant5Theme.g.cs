
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant5Theme
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
    public static class ResponseDataItemVariant5ThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant5Theme value)
        {
            return value switch
            {
                ResponseDataItemVariant5Theme.Orange => "orange",
                ResponseDataItemVariant5Theme.Blue => "blue",
                ResponseDataItemVariant5Theme.Green => "green",
                ResponseDataItemVariant5Theme.Purple => "purple",
                ResponseDataItemVariant5Theme.Pink => "pink",
                ResponseDataItemVariant5Theme.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant5Theme? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseDataItemVariant5Theme.Orange,
                "blue" => ResponseDataItemVariant5Theme.Blue,
                "green" => ResponseDataItemVariant5Theme.Green,
                "purple" => ResponseDataItemVariant5Theme.Purple,
                "pink" => ResponseDataItemVariant5Theme.Pink,
                "indigo" => ResponseDataItemVariant5Theme.Indigo,
                _ => null,
            };
        }
    }
}