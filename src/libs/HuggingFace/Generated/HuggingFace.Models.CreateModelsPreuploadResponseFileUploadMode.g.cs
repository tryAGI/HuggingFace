
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsPreuploadResponseFileUploadMode
    {
        /// <summary>
        /// 
        /// </summary>
        Lfs,
        /// <summary>
        /// 
        /// </summary>
        Regular,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelsPreuploadResponseFileUploadModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsPreuploadResponseFileUploadMode value)
        {
            return value switch
            {
                CreateModelsPreuploadResponseFileUploadMode.Lfs => "lfs",
                CreateModelsPreuploadResponseFileUploadMode.Regular => "regular",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsPreuploadResponseFileUploadMode? ToEnum(string value)
        {
            return value switch
            {
                "lfs" => CreateModelsPreuploadResponseFileUploadMode.Lfs,
                "regular" => CreateModelsPreuploadResponseFileUploadMode.Regular,
                _ => null,
            };
        }
    }
}