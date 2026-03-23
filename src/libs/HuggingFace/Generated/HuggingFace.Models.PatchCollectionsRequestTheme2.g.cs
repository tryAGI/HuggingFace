
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsRequestTheme2
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
    public static class PatchCollectionsRequestTheme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsRequestTheme2 value)
        {
            return value switch
            {
                PatchCollectionsRequestTheme2.Blue => "blue",
                PatchCollectionsRequestTheme2.Green => "green",
                PatchCollectionsRequestTheme2.Indigo => "indigo",
                PatchCollectionsRequestTheme2.Orange => "orange",
                PatchCollectionsRequestTheme2.Pink => "pink",
                PatchCollectionsRequestTheme2.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsRequestTheme2? ToEnum(string value)
        {
            return value switch
            {
                "blue" => PatchCollectionsRequestTheme2.Blue,
                "green" => PatchCollectionsRequestTheme2.Green,
                "indigo" => PatchCollectionsRequestTheme2.Indigo,
                "orange" => PatchCollectionsRequestTheme2.Orange,
                "pink" => PatchCollectionsRequestTheme2.Pink,
                "purple" => PatchCollectionsRequestTheme2.Purple,
                _ => null,
            };
        }
    }
}