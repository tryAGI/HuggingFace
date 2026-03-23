
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesPreuploadResponseFileUploadMode
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
    public static class CreateSpacesPreuploadResponseFileUploadModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesPreuploadResponseFileUploadMode value)
        {
            return value switch
            {
                CreateSpacesPreuploadResponseFileUploadMode.Lfs => "lfs",
                CreateSpacesPreuploadResponseFileUploadMode.Regular => "regular",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesPreuploadResponseFileUploadMode? ToEnum(string value)
        {
            return value switch
            {
                "lfs" => CreateSpacesPreuploadResponseFileUploadMode.Lfs,
                "regular" => CreateSpacesPreuploadResponseFileUploadMode.Regular,
                _ => null,
            };
        }
    }
}