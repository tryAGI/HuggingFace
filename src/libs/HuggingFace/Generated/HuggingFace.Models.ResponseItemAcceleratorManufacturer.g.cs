
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemAcceleratorManufacturer
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
    public static class ResponseItemAcceleratorManufacturerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemAcceleratorManufacturer value)
        {
            return value switch
            {
                ResponseItemAcceleratorManufacturer.Nvidia => "Nvidia",
                ResponseItemAcceleratorManufacturer.Aws => "AWS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemAcceleratorManufacturer? ToEnum(string value)
        {
            return value switch
            {
                "Nvidia" => ResponseItemAcceleratorManufacturer.Nvidia,
                "AWS" => ResponseItemAcceleratorManufacturer.Aws,
                _ => null,
            };
        }
    }
}