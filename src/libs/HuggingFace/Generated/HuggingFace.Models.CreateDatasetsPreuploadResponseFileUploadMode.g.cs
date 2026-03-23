
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsPreuploadResponseFileUploadMode
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
    public static class CreateDatasetsPreuploadResponseFileUploadModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsPreuploadResponseFileUploadMode value)
        {
            return value switch
            {
                CreateDatasetsPreuploadResponseFileUploadMode.Lfs => "lfs",
                CreateDatasetsPreuploadResponseFileUploadMode.Regular => "regular",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsPreuploadResponseFileUploadMode? ToEnum(string value)
        {
            return value switch
            {
                "lfs" => CreateDatasetsPreuploadResponseFileUploadMode.Lfs,
                "regular" => CreateDatasetsPreuploadResponseFileUploadMode.Regular,
                _ => null,
            };
        }
    }
}