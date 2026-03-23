
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsCancelResponseArch
    {
        /// <summary>
        /// 
        /// </summary>
        Amd64,
        /// <summary>
        /// 
        /// </summary>
        Arm64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateJobsCancelResponseArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsCancelResponseArch value)
        {
            return value switch
            {
                CreateJobsCancelResponseArch.Amd64 => "amd64",
                CreateJobsCancelResponseArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsCancelResponseArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => CreateJobsCancelResponseArch.Amd64,
                "arm64" => CreateJobsCancelResponseArch.Arm64,
                _ => null,
            };
        }
    }
}