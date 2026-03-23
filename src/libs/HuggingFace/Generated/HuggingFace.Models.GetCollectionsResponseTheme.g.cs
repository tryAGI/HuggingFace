
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseTheme
    {
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
        Indigo,
        /// <summary>
        /// 
        /// </summary>
        Orange,
        /// <summary>
        /// 
        /// </summary>
        Pink,
        /// <summary>
        /// 
        /// </summary>
        Purple,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCollectionsResponseThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseTheme value)
        {
            return value switch
            {
                GetCollectionsResponseTheme.Blue => "blue",
                GetCollectionsResponseTheme.Green => "green",
                GetCollectionsResponseTheme.Indigo => "indigo",
                GetCollectionsResponseTheme.Orange => "orange",
                GetCollectionsResponseTheme.Pink => "pink",
                GetCollectionsResponseTheme.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseTheme? ToEnum(string value)
        {
            return value switch
            {
                "blue" => GetCollectionsResponseTheme.Blue,
                "green" => GetCollectionsResponseTheme.Green,
                "indigo" => GetCollectionsResponseTheme.Indigo,
                "orange" => GetCollectionsResponseTheme.Orange,
                "pink" => GetCollectionsResponseTheme.Pink,
                "purple" => GetCollectionsResponseTheme.Purple,
                _ => null,
            };
        }
    }
}