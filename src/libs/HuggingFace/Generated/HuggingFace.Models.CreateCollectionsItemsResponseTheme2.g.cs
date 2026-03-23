
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseTheme2
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
    public static class CreateCollectionsItemsResponseTheme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseTheme2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseTheme2.Blue => "blue",
                CreateCollectionsItemsResponseTheme2.Green => "green",
                CreateCollectionsItemsResponseTheme2.Indigo => "indigo",
                CreateCollectionsItemsResponseTheme2.Orange => "orange",
                CreateCollectionsItemsResponseTheme2.Pink => "pink",
                CreateCollectionsItemsResponseTheme2.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseTheme2? ToEnum(string value)
        {
            return value switch
            {
                "blue" => CreateCollectionsItemsResponseTheme2.Blue,
                "green" => CreateCollectionsItemsResponseTheme2.Green,
                "indigo" => CreateCollectionsItemsResponseTheme2.Indigo,
                "orange" => CreateCollectionsItemsResponseTheme2.Orange,
                "pink" => CreateCollectionsItemsResponseTheme2.Pink,
                "purple" => CreateCollectionsItemsResponseTheme2.Purple,
                _ => null,
            };
        }
    }
}