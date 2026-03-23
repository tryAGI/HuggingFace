
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataTheme
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
    public static class PatchCollectionsResponseDataThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataTheme value)
        {
            return value switch
            {
                PatchCollectionsResponseDataTheme.Blue => "blue",
                PatchCollectionsResponseDataTheme.Green => "green",
                PatchCollectionsResponseDataTheme.Indigo => "indigo",
                PatchCollectionsResponseDataTheme.Orange => "orange",
                PatchCollectionsResponseDataTheme.Pink => "pink",
                PatchCollectionsResponseDataTheme.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataTheme? ToEnum(string value)
        {
            return value switch
            {
                "blue" => PatchCollectionsResponseDataTheme.Blue,
                "green" => PatchCollectionsResponseDataTheme.Green,
                "indigo" => PatchCollectionsResponseDataTheme.Indigo,
                "orange" => PatchCollectionsResponseDataTheme.Orange,
                "pink" => PatchCollectionsResponseDataTheme.Pink,
                "purple" => PatchCollectionsResponseDataTheme.Purple,
                _ => null,
            };
        }
    }
}