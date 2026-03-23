
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemTheme
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
    public static class GetCollectionsResponseVariant1ItemThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemTheme value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemTheme.Blue => "blue",
                GetCollectionsResponseVariant1ItemTheme.Green => "green",
                GetCollectionsResponseVariant1ItemTheme.Indigo => "indigo",
                GetCollectionsResponseVariant1ItemTheme.Orange => "orange",
                GetCollectionsResponseVariant1ItemTheme.Pink => "pink",
                GetCollectionsResponseVariant1ItemTheme.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemTheme? ToEnum(string value)
        {
            return value switch
            {
                "blue" => GetCollectionsResponseVariant1ItemTheme.Blue,
                "green" => GetCollectionsResponseVariant1ItemTheme.Green,
                "indigo" => GetCollectionsResponseVariant1ItemTheme.Indigo,
                "orange" => GetCollectionsResponseVariant1ItemTheme.Orange,
                "pink" => GetCollectionsResponseVariant1ItemTheme.Pink,
                "purple" => GetCollectionsResponseVariant1ItemTheme.Purple,
                _ => null,
            };
        }
    }
}