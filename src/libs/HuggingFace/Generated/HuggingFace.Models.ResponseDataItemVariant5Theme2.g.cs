
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant5Theme2
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
    public static class ResponseDataItemVariant5Theme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant5Theme2 value)
        {
            return value switch
            {
                ResponseDataItemVariant5Theme2.Orange => "orange",
                ResponseDataItemVariant5Theme2.Blue => "blue",
                ResponseDataItemVariant5Theme2.Green => "green",
                ResponseDataItemVariant5Theme2.Purple => "purple",
                ResponseDataItemVariant5Theme2.Pink => "pink",
                ResponseDataItemVariant5Theme2.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant5Theme2? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseDataItemVariant5Theme2.Orange,
                "blue" => ResponseDataItemVariant5Theme2.Blue,
                "green" => ResponseDataItemVariant5Theme2.Green,
                "purple" => ResponseDataItemVariant5Theme2.Purple,
                "pink" => ResponseDataItemVariant5Theme2.Pink,
                "indigo" => ResponseDataItemVariant5Theme2.Indigo,
                _ => null,
            };
        }
    }
}