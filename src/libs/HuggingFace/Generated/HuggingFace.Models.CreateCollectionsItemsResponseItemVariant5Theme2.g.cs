
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant5Theme2
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
    public static class CreateCollectionsItemsResponseItemVariant5Theme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant5Theme2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant5Theme2.Blue => "blue",
                CreateCollectionsItemsResponseItemVariant5Theme2.Green => "green",
                CreateCollectionsItemsResponseItemVariant5Theme2.Indigo => "indigo",
                CreateCollectionsItemsResponseItemVariant5Theme2.Orange => "orange",
                CreateCollectionsItemsResponseItemVariant5Theme2.Pink => "pink",
                CreateCollectionsItemsResponseItemVariant5Theme2.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant5Theme2? ToEnum(string value)
        {
            return value switch
            {
                "blue" => CreateCollectionsItemsResponseItemVariant5Theme2.Blue,
                "green" => CreateCollectionsItemsResponseItemVariant5Theme2.Green,
                "indigo" => CreateCollectionsItemsResponseItemVariant5Theme2.Indigo,
                "orange" => CreateCollectionsItemsResponseItemVariant5Theme2.Orange,
                "pink" => CreateCollectionsItemsResponseItemVariant5Theme2.Pink,
                "purple" => CreateCollectionsItemsResponseItemVariant5Theme2.Purple,
                _ => null,
            };
        }
    }
}