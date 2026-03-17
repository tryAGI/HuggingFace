
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemAcceleratorType2
    {
        /// <summary>
        /// 
        /// </summary>
        Gpu,
        /// <summary>
        /// 
        /// </summary>
        Neuron,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemAcceleratorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemAcceleratorType2 value)
        {
            return value switch
            {
                ResponseItemAcceleratorType2.Gpu => "gpu",
                ResponseItemAcceleratorType2.Neuron => "neuron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemAcceleratorType2? ToEnum(string value)
        {
            return value switch
            {
                "gpu" => ResponseItemAcceleratorType2.Gpu,
                "neuron" => ResponseItemAcceleratorType2.Neuron,
                _ => null,
            };
        }
    }
}