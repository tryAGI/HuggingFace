
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsDuplicateResponseArch
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
    public static class CreateJobsDuplicateResponseArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsDuplicateResponseArch value)
        {
            return value switch
            {
                CreateJobsDuplicateResponseArch.Amd64 => "amd64",
                CreateJobsDuplicateResponseArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsDuplicateResponseArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => CreateJobsDuplicateResponseArch.Amd64,
                "arm64" => CreateJobsDuplicateResponseArch.Arm64,
                _ => null,
            };
        }
    }
}