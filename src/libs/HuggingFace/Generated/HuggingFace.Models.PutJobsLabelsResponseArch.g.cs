
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJobsLabelsResponseArch
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
    public static class PutJobsLabelsResponseArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJobsLabelsResponseArch value)
        {
            return value switch
            {
                PutJobsLabelsResponseArch.Amd64 => "amd64",
                PutJobsLabelsResponseArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJobsLabelsResponseArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => PutJobsLabelsResponseArch.Amd64,
                "arm64" => PutJobsLabelsResponseArch.Arm64,
                _ => null,
            };
        }
    }
}