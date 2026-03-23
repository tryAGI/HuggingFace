
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant5Theme2
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
    public static class GetCollectionsResponseItemVariant5Theme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant5Theme2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant5Theme2.Blue => "blue",
                GetCollectionsResponseItemVariant5Theme2.Green => "green",
                GetCollectionsResponseItemVariant5Theme2.Indigo => "indigo",
                GetCollectionsResponseItemVariant5Theme2.Orange => "orange",
                GetCollectionsResponseItemVariant5Theme2.Pink => "pink",
                GetCollectionsResponseItemVariant5Theme2.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant5Theme2? ToEnum(string value)
        {
            return value switch
            {
                "blue" => GetCollectionsResponseItemVariant5Theme2.Blue,
                "green" => GetCollectionsResponseItemVariant5Theme2.Green,
                "indigo" => GetCollectionsResponseItemVariant5Theme2.Indigo,
                "orange" => GetCollectionsResponseItemVariant5Theme2.Orange,
                "pink" => GetCollectionsResponseItemVariant5Theme2.Pink,
                "purple" => GetCollectionsResponseItemVariant5Theme2.Purple,
                _ => null,
            };
        }
    }
}