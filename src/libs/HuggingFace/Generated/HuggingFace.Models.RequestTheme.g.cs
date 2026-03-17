
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestTheme
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
    public static class RequestThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTheme value)
        {
            return value switch
            {
                RequestTheme.Orange => "orange",
                RequestTheme.Blue => "blue",
                RequestTheme.Green => "green",
                RequestTheme.Purple => "purple",
                RequestTheme.Pink => "pink",
                RequestTheme.Indigo => "indigo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestTheme? ToEnum(string value)
        {
            return value switch
            {
                "orange" => RequestTheme.Orange,
                "blue" => RequestTheme.Blue,
                "green" => RequestTheme.Green,
                "purple" => RequestTheme.Purple,
                "pink" => RequestTheme.Pink,
                "indigo" => RequestTheme.Indigo,
                _ => null,
            };
        }
    }
}