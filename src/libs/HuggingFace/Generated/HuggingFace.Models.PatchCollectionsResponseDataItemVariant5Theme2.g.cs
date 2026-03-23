
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant5Theme2
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
    public static class PatchCollectionsResponseDataItemVariant5Theme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant5Theme2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant5Theme2.Blue => "blue",
                PatchCollectionsResponseDataItemVariant5Theme2.Green => "green",
                PatchCollectionsResponseDataItemVariant5Theme2.Indigo => "indigo",
                PatchCollectionsResponseDataItemVariant5Theme2.Orange => "orange",
                PatchCollectionsResponseDataItemVariant5Theme2.Pink => "pink",
                PatchCollectionsResponseDataItemVariant5Theme2.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant5Theme2? ToEnum(string value)
        {
            return value switch
            {
                "blue" => PatchCollectionsResponseDataItemVariant5Theme2.Blue,
                "green" => PatchCollectionsResponseDataItemVariant5Theme2.Green,
                "indigo" => PatchCollectionsResponseDataItemVariant5Theme2.Indigo,
                "orange" => PatchCollectionsResponseDataItemVariant5Theme2.Orange,
                "pink" => PatchCollectionsResponseDataItemVariant5Theme2.Pink,
                "purple" => PatchCollectionsResponseDataItemVariant5Theme2.Purple,
                _ => null,
            };
        }
    }
}