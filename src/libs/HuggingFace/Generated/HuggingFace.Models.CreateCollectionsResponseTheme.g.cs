
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseTheme
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
    public static class CreateCollectionsResponseThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseTheme value)
        {
            return value switch
            {
                CreateCollectionsResponseTheme.Blue => "blue",
                CreateCollectionsResponseTheme.Green => "green",
                CreateCollectionsResponseTheme.Indigo => "indigo",
                CreateCollectionsResponseTheme.Orange => "orange",
                CreateCollectionsResponseTheme.Pink => "pink",
                CreateCollectionsResponseTheme.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseTheme? ToEnum(string value)
        {
            return value switch
            {
                "blue" => CreateCollectionsResponseTheme.Blue,
                "green" => CreateCollectionsResponseTheme.Green,
                "indigo" => CreateCollectionsResponseTheme.Indigo,
                "orange" => CreateCollectionsResponseTheme.Orange,
                "pink" => CreateCollectionsResponseTheme.Pink,
                "purple" => CreateCollectionsResponseTheme.Purple,
                _ => null,
            };
        }
    }
}