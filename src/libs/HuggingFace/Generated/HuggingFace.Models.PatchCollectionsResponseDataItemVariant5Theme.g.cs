
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant5Theme
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
    public static class PatchCollectionsResponseDataItemVariant5ThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant5Theme value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant5Theme.Blue => "blue",
                PatchCollectionsResponseDataItemVariant5Theme.Green => "green",
                PatchCollectionsResponseDataItemVariant5Theme.Indigo => "indigo",
                PatchCollectionsResponseDataItemVariant5Theme.Orange => "orange",
                PatchCollectionsResponseDataItemVariant5Theme.Pink => "pink",
                PatchCollectionsResponseDataItemVariant5Theme.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant5Theme? ToEnum(string value)
        {
            return value switch
            {
                "blue" => PatchCollectionsResponseDataItemVariant5Theme.Blue,
                "green" => PatchCollectionsResponseDataItemVariant5Theme.Green,
                "indigo" => PatchCollectionsResponseDataItemVariant5Theme.Indigo,
                "orange" => PatchCollectionsResponseDataItemVariant5Theme.Orange,
                "pink" => PatchCollectionsResponseDataItemVariant5Theme.Pink,
                "purple" => PatchCollectionsResponseDataItemVariant5Theme.Purple,
                _ => null,
            };
        }
    }
}