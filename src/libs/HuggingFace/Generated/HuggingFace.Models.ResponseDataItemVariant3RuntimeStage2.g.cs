
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3RuntimeStage2
    {
        /// <summary>
        /// 
        /// </summary>
        NoAppFile,
        /// <summary>
        /// 
        /// </summary>
        ConfigError,
        /// <summary>
        /// 
        /// </summary>
        Building,
        /// <summary>
        /// 
        /// </summary>
        BuildError,
        /// <summary>
        /// 
        /// </summary>
        AppStarting,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        RunningBuilding,
        /// <summary>
        /// 
        /// </summary>
        RunningAppStarting,
        /// <summary>
        /// 
        /// </summary>
        RuntimeError,
        /// <summary>
        /// 
        /// </summary>
        Deleting,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        Sleeping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseDataItemVariant3RuntimeStage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3RuntimeStage2 value)
        {
            return value switch
            {
                ResponseDataItemVariant3RuntimeStage2.NoAppFile => "NO_APP_FILE",
                ResponseDataItemVariant3RuntimeStage2.ConfigError => "CONFIG_ERROR",
                ResponseDataItemVariant3RuntimeStage2.Building => "BUILDING",
                ResponseDataItemVariant3RuntimeStage2.BuildError => "BUILD_ERROR",
                ResponseDataItemVariant3RuntimeStage2.AppStarting => "APP_STARTING",
                ResponseDataItemVariant3RuntimeStage2.Running => "RUNNING",
                ResponseDataItemVariant3RuntimeStage2.RunningBuilding => "RUNNING_BUILDING",
                ResponseDataItemVariant3RuntimeStage2.RunningAppStarting => "RUNNING_APP_STARTING",
                ResponseDataItemVariant3RuntimeStage2.RuntimeError => "RUNTIME_ERROR",
                ResponseDataItemVariant3RuntimeStage2.Deleting => "DELETING",
                ResponseDataItemVariant3RuntimeStage2.Stopped => "STOPPED",
                ResponseDataItemVariant3RuntimeStage2.Paused => "PAUSED",
                ResponseDataItemVariant3RuntimeStage2.Sleeping => "SLEEPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3RuntimeStage2? ToEnum(string value)
        {
            return value switch
            {
                "NO_APP_FILE" => ResponseDataItemVariant3RuntimeStage2.NoAppFile,
                "CONFIG_ERROR" => ResponseDataItemVariant3RuntimeStage2.ConfigError,
                "BUILDING" => ResponseDataItemVariant3RuntimeStage2.Building,
                "BUILD_ERROR" => ResponseDataItemVariant3RuntimeStage2.BuildError,
                "APP_STARTING" => ResponseDataItemVariant3RuntimeStage2.AppStarting,
                "RUNNING" => ResponseDataItemVariant3RuntimeStage2.Running,
                "RUNNING_BUILDING" => ResponseDataItemVariant3RuntimeStage2.RunningBuilding,
                "RUNNING_APP_STARTING" => ResponseDataItemVariant3RuntimeStage2.RunningAppStarting,
                "RUNTIME_ERROR" => ResponseDataItemVariant3RuntimeStage2.RuntimeError,
                "DELETING" => ResponseDataItemVariant3RuntimeStage2.Deleting,
                "STOPPED" => ResponseDataItemVariant3RuntimeStage2.Stopped,
                "PAUSED" => ResponseDataItemVariant3RuntimeStage2.Paused,
                "SLEEPING" => ResponseDataItemVariant3RuntimeStage2.Sleeping,
                _ => null,
            };
        }
    }
}