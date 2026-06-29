
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsResponseItemBuildMetadataBackendHardwareType
    {
        /// <summary>
        /// 
        /// </summary>
        x100,
        /// <summary>
        /// 
        /// </summary>
        x100Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x100a,
        /// <summary>
        /// 
        /// </summary>
        x100f,
        /// <summary>
        /// 
        /// </summary>
        x103,
        /// <summary>
        /// 
        /// </summary>
        x103Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x103a,
        /// <summary>
        /// 
        /// </summary>
        x110,
        /// <summary>
        /// 
        /// </summary>
        x110Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x110a,
        /// <summary>
        /// 
        /// </summary>
        x120,
        /// <summary>
        /// 
        /// </summary>
        x120Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x120a,
        /// <summary>
        /// 
        /// </summary>
        x120f,
        /// <summary>
        /// 
        /// </summary>
        x121,
        /// <summary>
        /// 
        /// </summary>
        x121Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x121a,
        /// <summary>
        /// 
        /// </summary>
        x130,
        /// <summary>
        /// 
        /// </summary>
        x130Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x130a,
        /// <summary>
        /// 
        /// </summary>
        x130f,
        /// <summary>
        /// 
        /// </summary>
        x50,
        /// <summary>
        /// 
        /// </summary>
        x50Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x52,
        /// <summary>
        /// 
        /// </summary>
        x52Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x60,
        /// <summary>
        /// 
        /// </summary>
        x60Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x61,
        /// <summary>
        /// 
        /// </summary>
        x61Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x62,
        /// <summary>
        /// 
        /// </summary>
        x62Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x70,
        /// <summary>
        /// 
        /// </summary>
        x70Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x72,
        /// <summary>
        /// 
        /// </summary>
        x72Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x75,
        /// <summary>
        /// 
        /// </summary>
        x75Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x80,
        /// <summary>
        /// 
        /// </summary>
        x80Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x86,
        /// <summary>
        /// 
        /// </summary>
        x86Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x87,
        /// <summary>
        /// 
        /// </summary>
        x87Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x89,
        /// <summary>
        /// 
        /// </summary>
        x89Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x90,
        /// <summary>
        /// 
        /// </summary>
        x90Plusptx,
        /// <summary>
        /// 
        /// </summary>
        x90a,
        /// <summary>
        /// 
        /// </summary>
        Gfx1030,
        /// <summary>
        /// 
        /// </summary>
        Gfx1100,
        /// <summary>
        /// 
        /// </summary>
        Gfx1101,
        /// <summary>
        /// 
        /// </summary>
        Gfx1102,
        /// <summary>
        /// 
        /// </summary>
        Gfx1150,
        /// <summary>
        /// 
        /// </summary>
        Gfx1151,
        /// <summary>
        /// 
        /// </summary>
        Gfx1200,
        /// <summary>
        /// 
        /// </summary>
        Gfx1201,
        /// <summary>
        /// 
        /// </summary>
        Gfx900,
        /// <summary>
        /// 
        /// </summary>
        Gfx906,
        /// <summary>
        /// 
        /// </summary>
        Gfx908,
        /// <summary>
        /// 
        /// </summary>
        Gfx90a,
        /// <summary>
        /// 
        /// </summary>
        Gfx942,
        /// <summary>
        /// 
        /// </summary>
        Gfx950,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKernelsResponseItemBuildMetadataBackendHardwareTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsResponseItemBuildMetadataBackendHardwareType value)
        {
            return value switch
            {
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x100 => "10.0",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x100Plusptx => "10.0+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x100a => "10.0a",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x100f => "10.0f",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x103 => "10.3",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x103Plusptx => "10.3+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x103a => "10.3a",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x110 => "11.0",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x110Plusptx => "11.0+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x110a => "11.0a",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x120 => "12.0",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x120Plusptx => "12.0+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x120a => "12.0a",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x120f => "12.0f",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x121 => "12.1",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x121Plusptx => "12.1+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x121a => "12.1a",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x130 => "13.0",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x130Plusptx => "13.0+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x130a => "13.0a",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x130f => "13.0f",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x50 => "5.0",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x50Plusptx => "5.0+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x52 => "5.2",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x52Plusptx => "5.2+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x60 => "6.0",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x60Plusptx => "6.0+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x61 => "6.1",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x61Plusptx => "6.1+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x62 => "6.2",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x62Plusptx => "6.2+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x70 => "7.0",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x70Plusptx => "7.0+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x72 => "7.2",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x72Plusptx => "7.2+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x75 => "7.5",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x75Plusptx => "7.5+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x80 => "8.0",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x80Plusptx => "8.0+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x86 => "8.6",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x86Plusptx => "8.6+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x87 => "8.7",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x87Plusptx => "8.7+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x89 => "8.9",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x89Plusptx => "8.9+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x90 => "9.0",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x90Plusptx => "9.0+PTX",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.x90a => "9.0a",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1030 => "gfx1030",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1100 => "gfx1100",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1101 => "gfx1101",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1102 => "gfx1102",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1150 => "gfx1150",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1151 => "gfx1151",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1200 => "gfx1200",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1201 => "gfx1201",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx900 => "gfx900",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx906 => "gfx906",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx908 => "gfx908",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx90a => "gfx90a",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx942 => "gfx942",
                GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx950 => "gfx950",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsResponseItemBuildMetadataBackendHardwareType? ToEnum(string value)
        {
            return value switch
            {
                "10.0" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x100,
                "10.0+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x100Plusptx,
                "10.0a" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x100a,
                "10.0f" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x100f,
                "10.3" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x103,
                "10.3+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x103Plusptx,
                "10.3a" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x103a,
                "11.0" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x110,
                "11.0+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x110Plusptx,
                "11.0a" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x110a,
                "12.0" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x120,
                "12.0+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x120Plusptx,
                "12.0a" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x120a,
                "12.0f" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x120f,
                "12.1" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x121,
                "12.1+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x121Plusptx,
                "12.1a" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x121a,
                "13.0" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x130,
                "13.0+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x130Plusptx,
                "13.0a" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x130a,
                "13.0f" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x130f,
                "5.0" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x50,
                "5.0+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x50Plusptx,
                "5.2" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x52,
                "5.2+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x52Plusptx,
                "6.0" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x60,
                "6.0+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x60Plusptx,
                "6.1" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x61,
                "6.1+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x61Plusptx,
                "6.2" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x62,
                "6.2+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x62Plusptx,
                "7.0" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x70,
                "7.0+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x70Plusptx,
                "7.2" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x72,
                "7.2+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x72Plusptx,
                "7.5" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x75,
                "7.5+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x75Plusptx,
                "8.0" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x80,
                "8.0+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x80Plusptx,
                "8.6" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x86,
                "8.6+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x86Plusptx,
                "8.7" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x87,
                "8.7+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x87Plusptx,
                "8.9" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x89,
                "8.9+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x89Plusptx,
                "9.0" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x90,
                "9.0+PTX" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x90Plusptx,
                "9.0a" => GetKernelsResponseItemBuildMetadataBackendHardwareType.x90a,
                "gfx1030" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1030,
                "gfx1100" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1100,
                "gfx1101" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1101,
                "gfx1102" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1102,
                "gfx1150" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1150,
                "gfx1151" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1151,
                "gfx1200" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1200,
                "gfx1201" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx1201,
                "gfx900" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx900,
                "gfx906" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx906,
                "gfx908" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx908,
                "gfx90a" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx90a,
                "gfx942" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx942,
                "gfx950" => GetKernelsResponseItemBuildMetadataBackendHardwareType.Gfx950,
                _ => null,
            };
        }
    }
}