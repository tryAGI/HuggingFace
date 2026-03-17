
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3RuntimeStage2
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
    public static class ResponseItemVariant3RuntimeStage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3RuntimeStage2 value)
        {
            return value switch
            {
                ResponseItemVariant3RuntimeStage2.NoAppFile => "NO_APP_FILE",
                ResponseItemVariant3RuntimeStage2.ConfigError => "CONFIG_ERROR",
                ResponseItemVariant3RuntimeStage2.Building => "BUILDING",
                ResponseItemVariant3RuntimeStage2.BuildError => "BUILD_ERROR",
                ResponseItemVariant3RuntimeStage2.AppStarting => "APP_STARTING",
                ResponseItemVariant3RuntimeStage2.Running => "RUNNING",
                ResponseItemVariant3RuntimeStage2.RunningBuilding => "RUNNING_BUILDING",
                ResponseItemVariant3RuntimeStage2.RunningAppStarting => "RUNNING_APP_STARTING",
                ResponseItemVariant3RuntimeStage2.RuntimeError => "RUNTIME_ERROR",
                ResponseItemVariant3RuntimeStage2.Deleting => "DELETING",
                ResponseItemVariant3RuntimeStage2.Stopped => "STOPPED",
                ResponseItemVariant3RuntimeStage2.Paused => "PAUSED",
                ResponseItemVariant3RuntimeStage2.Sleeping => "SLEEPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3RuntimeStage2? ToEnum(string value)
        {
            return value switch
            {
                "NO_APP_FILE" => ResponseItemVariant3RuntimeStage2.NoAppFile,
                "CONFIG_ERROR" => ResponseItemVariant3RuntimeStage2.ConfigError,
                "BUILDING" => ResponseItemVariant3RuntimeStage2.Building,
                "BUILD_ERROR" => ResponseItemVariant3RuntimeStage2.BuildError,
                "APP_STARTING" => ResponseItemVariant3RuntimeStage2.AppStarting,
                "RUNNING" => ResponseItemVariant3RuntimeStage2.Running,
                "RUNNING_BUILDING" => ResponseItemVariant3RuntimeStage2.RunningBuilding,
                "RUNNING_APP_STARTING" => ResponseItemVariant3RuntimeStage2.RunningAppStarting,
                "RUNTIME_ERROR" => ResponseItemVariant3RuntimeStage2.RuntimeError,
                "DELETING" => ResponseItemVariant3RuntimeStage2.Deleting,
                "STOPPED" => ResponseItemVariant3RuntimeStage2.Stopped,
                "PAUSED" => ResponseItemVariant3RuntimeStage2.Paused,
                "SLEEPING" => ResponseItemVariant3RuntimeStage2.Sleeping,
                _ => null,
            };
        }
    }
}