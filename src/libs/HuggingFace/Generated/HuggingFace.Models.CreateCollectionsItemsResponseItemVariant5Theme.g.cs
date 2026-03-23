
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant5Theme
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
    public static class CreateCollectionsItemsResponseItemVariant5ThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant5Theme value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant5Theme.Blue => "blue",
                CreateCollectionsItemsResponseItemVariant5Theme.Green => "green",
                CreateCollectionsItemsResponseItemVariant5Theme.Indigo => "indigo",
                CreateCollectionsItemsResponseItemVariant5Theme.Orange => "orange",
                CreateCollectionsItemsResponseItemVariant5Theme.Pink => "pink",
                CreateCollectionsItemsResponseItemVariant5Theme.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant5Theme? ToEnum(string value)
        {
            return value switch
            {
                "blue" => CreateCollectionsItemsResponseItemVariant5Theme.Blue,
                "green" => CreateCollectionsItemsResponseItemVariant5Theme.Green,
                "indigo" => CreateCollectionsItemsResponseItemVariant5Theme.Indigo,
                "orange" => CreateCollectionsItemsResponseItemVariant5Theme.Orange,
                "pink" => CreateCollectionsItemsResponseItemVariant5Theme.Pink,
                "purple" => CreateCollectionsItemsResponseItemVariant5Theme.Purple,
                _ => null,
            };
        }
    }
}