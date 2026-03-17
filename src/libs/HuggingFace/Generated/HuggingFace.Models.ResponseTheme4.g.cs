
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseTheme4
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
    public static class ResponseTheme4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTheme4 value)
        {
            return value switch
            {
                ResponseTheme4.Orange => "orange",
                ResponseTheme4.Blue => "blue",
                ResponseTheme4.Green => "green",
                ResponseTheme4.Purple => "purple",
                ResponseTheme4.Pink => "pink",
                ResponseTheme4.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTheme4? ToEnum(string value)
        {
            return value switch
            {
                "orange" => ResponseTheme4.Orange,
                "blue" => ResponseTheme4.Blue,
                "green" => ResponseTheme4.Green,
                "purple" => ResponseTheme4.Purple,
                "pink" => ResponseTheme4.Pink,
                "indigo" => ResponseTheme4.Indigo,
                _ => null,
            };
        }
    }
}