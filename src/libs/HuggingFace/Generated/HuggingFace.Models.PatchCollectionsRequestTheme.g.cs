
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsRequestTheme
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
    public static class PatchCollectionsRequestThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsRequestTheme value)
        {
            return value switch
            {
                PatchCollectionsRequestTheme.Blue => "blue",
                PatchCollectionsRequestTheme.Green => "green",
                PatchCollectionsRequestTheme.Indigo => "indigo",
                PatchCollectionsRequestTheme.Orange => "orange",
                PatchCollectionsRequestTheme.Pink => "pink",
                PatchCollectionsRequestTheme.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsRequestTheme? ToEnum(string value)
        {
            return value switch
            {
                "blue" => PatchCollectionsRequestTheme.Blue,
                "green" => PatchCollectionsRequestTheme.Green,
                "indigo" => PatchCollectionsRequestTheme.Indigo,
                "orange" => PatchCollectionsRequestTheme.Orange,
                "pink" => PatchCollectionsRequestTheme.Pink,
                "purple" => PatchCollectionsRequestTheme.Purple,
                _ => null,
            };
        }
    }
}