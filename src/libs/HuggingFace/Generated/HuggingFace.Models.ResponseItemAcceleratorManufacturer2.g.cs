
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemAcceleratorManufacturer2
    {
        /// <summary>
        /// 
        /// </summary>
        Nvidia,
        /// <summary>
        /// 
        /// </summary>
        Aws,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemAcceleratorManufacturer2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemAcceleratorManufacturer2 value)
        {
            return value switch
            {
                ResponseItemAcceleratorManufacturer2.Nvidia => "Nvidia",
                ResponseItemAcceleratorManufacturer2.Aws => "AWS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemAcceleratorManufacturer2? ToEnum(string value)
        {
            return value switch
            {
                "Nvidia" => ResponseItemAcceleratorManufacturer2.Nvidia,
                "AWS" => ResponseItemAcceleratorManufacturer2.Aws,
                _ => null,
            };
        }
    }
}