
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestTheme2
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
    public static class RequestTheme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTheme2 value)
        {
            return value switch
            {
                RequestTheme2.Orange => "orange",
                RequestTheme2.Blue => "blue",
                RequestTheme2.Green => "green",
                RequestTheme2.Purple => "purple",
                RequestTheme2.Pink => "pink",
                RequestTheme2.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestTheme2? ToEnum(string value)
        {
            return value switch
            {
                "orange" => RequestTheme2.Orange,
                "blue" => RequestTheme2.Blue,
                "green" => RequestTheme2.Green,
                "purple" => RequestTheme2.Purple,
                "pink" => RequestTheme2.Pink,
                "indigo" => RequestTheme2.Indigo,
                _ => null,
            };
        }
    }
}