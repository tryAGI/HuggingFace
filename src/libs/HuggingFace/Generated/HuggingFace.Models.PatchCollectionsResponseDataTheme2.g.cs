
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataTheme2
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
    public static class PatchCollectionsResponseDataTheme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataTheme2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataTheme2.Blue => "blue",
                PatchCollectionsResponseDataTheme2.Green => "green",
                PatchCollectionsResponseDataTheme2.Indigo => "indigo",
                PatchCollectionsResponseDataTheme2.Orange => "orange",
                PatchCollectionsResponseDataTheme2.Pink => "pink",
                PatchCollectionsResponseDataTheme2.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataTheme2? ToEnum(string value)
        {
            return value switch
            {
                "blue" => PatchCollectionsResponseDataTheme2.Blue,
                "green" => PatchCollectionsResponseDataTheme2.Green,
                "indigo" => PatchCollectionsResponseDataTheme2.Indigo,
                "orange" => PatchCollectionsResponseDataTheme2.Orange,
                "pink" => PatchCollectionsResponseDataTheme2.Pink,
                "purple" => PatchCollectionsResponseDataTheme2.Purple,
                _ => null,
            };
        }
    }
}