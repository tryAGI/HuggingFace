
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant5Theme
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
    public static class GetCollectionsResponseItemVariant5ThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant5Theme value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant5Theme.Blue => "blue",
                GetCollectionsResponseItemVariant5Theme.Green => "green",
                GetCollectionsResponseItemVariant5Theme.Indigo => "indigo",
                GetCollectionsResponseItemVariant5Theme.Orange => "orange",
                GetCollectionsResponseItemVariant5Theme.Pink => "pink",
                GetCollectionsResponseItemVariant5Theme.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant5Theme? ToEnum(string value)
        {
            return value switch
            {
                "blue" => GetCollectionsResponseItemVariant5Theme.Blue,
                "green" => GetCollectionsResponseItemVariant5Theme.Green,
                "indigo" => GetCollectionsResponseItemVariant5Theme.Indigo,
                "orange" => GetCollectionsResponseItemVariant5Theme.Orange,
                "pink" => GetCollectionsResponseItemVariant5Theme.Pink,
                "purple" => GetCollectionsResponseItemVariant5Theme.Purple,
                _ => null,
            };
        }
    }
}