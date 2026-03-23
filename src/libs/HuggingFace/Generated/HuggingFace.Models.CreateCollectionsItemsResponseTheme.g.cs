
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseTheme
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
    public static class CreateCollectionsItemsResponseThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseTheme value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseTheme.Blue => "blue",
                CreateCollectionsItemsResponseTheme.Green => "green",
                CreateCollectionsItemsResponseTheme.Indigo => "indigo",
                CreateCollectionsItemsResponseTheme.Orange => "orange",
                CreateCollectionsItemsResponseTheme.Pink => "pink",
                CreateCollectionsItemsResponseTheme.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseTheme? ToEnum(string value)
        {
            return value switch
            {
                "blue" => CreateCollectionsItemsResponseTheme.Blue,
                "green" => CreateCollectionsItemsResponseTheme.Green,
                "indigo" => CreateCollectionsItemsResponseTheme.Indigo,
                "orange" => CreateCollectionsItemsResponseTheme.Orange,
                "pink" => CreateCollectionsItemsResponseTheme.Pink,
                "purple" => CreateCollectionsItemsResponseTheme.Purple,
                _ => null,
            };
        }
    }
}