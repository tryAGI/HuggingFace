
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant5Theme
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
    public static class CreateCollectionsResponseItemVariant5ThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant5Theme value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant5Theme.Blue => "blue",
                CreateCollectionsResponseItemVariant5Theme.Green => "green",
                CreateCollectionsResponseItemVariant5Theme.Indigo => "indigo",
                CreateCollectionsResponseItemVariant5Theme.Orange => "orange",
                CreateCollectionsResponseItemVariant5Theme.Pink => "pink",
                CreateCollectionsResponseItemVariant5Theme.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant5Theme? ToEnum(string value)
        {
            return value switch
            {
                "blue" => CreateCollectionsResponseItemVariant5Theme.Blue,
                "green" => CreateCollectionsResponseItemVariant5Theme.Green,
                "indigo" => CreateCollectionsResponseItemVariant5Theme.Indigo,
                "orange" => CreateCollectionsResponseItemVariant5Theme.Orange,
                "pink" => CreateCollectionsResponseItemVariant5Theme.Pink,
                "purple" => CreateCollectionsResponseItemVariant5Theme.Purple,
                _ => null,
            };
        }
    }
}