
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseTheme2
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
    public static class GetCollectionsResponseTheme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseTheme2 value)
        {
            return value switch
            {
                GetCollectionsResponseTheme2.Blue => "blue",
                GetCollectionsResponseTheme2.Green => "green",
                GetCollectionsResponseTheme2.Indigo => "indigo",
                GetCollectionsResponseTheme2.Orange => "orange",
                GetCollectionsResponseTheme2.Pink => "pink",
                GetCollectionsResponseTheme2.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseTheme2? ToEnum(string value)
        {
            return value switch
            {
                "blue" => GetCollectionsResponseTheme2.Blue,
                "green" => GetCollectionsResponseTheme2.Green,
                "indigo" => GetCollectionsResponseTheme2.Indigo,
                "orange" => GetCollectionsResponseTheme2.Orange,
                "pink" => GetCollectionsResponseTheme2.Pink,
                "purple" => GetCollectionsResponseTheme2.Purple,
                _ => null,
            };
        }
    }
}