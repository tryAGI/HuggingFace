
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant5Theme
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
    public static class GetCollectionsResponseVariant1ItemItemVariant5ThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant5Theme value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant5Theme.Blue => "blue",
                GetCollectionsResponseVariant1ItemItemVariant5Theme.Green => "green",
                GetCollectionsResponseVariant1ItemItemVariant5Theme.Indigo => "indigo",
                GetCollectionsResponseVariant1ItemItemVariant5Theme.Orange => "orange",
                GetCollectionsResponseVariant1ItemItemVariant5Theme.Pink => "pink",
                GetCollectionsResponseVariant1ItemItemVariant5Theme.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant5Theme? ToEnum(string value)
        {
            return value switch
            {
                "blue" => GetCollectionsResponseVariant1ItemItemVariant5Theme.Blue,
                "green" => GetCollectionsResponseVariant1ItemItemVariant5Theme.Green,
                "indigo" => GetCollectionsResponseVariant1ItemItemVariant5Theme.Indigo,
                "orange" => GetCollectionsResponseVariant1ItemItemVariant5Theme.Orange,
                "pink" => GetCollectionsResponseVariant1ItemItemVariant5Theme.Pink,
                "purple" => GetCollectionsResponseVariant1ItemItemVariant5Theme.Purple,
                _ => null,
            };
        }
    }
}