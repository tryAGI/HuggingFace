
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3RuntimeStage5
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
    public static class ResponseItemVariant3RuntimeStage5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3RuntimeStage5 value)
        {
            return value switch
            {
                ResponseItemVariant3RuntimeStage5.NoAppFile => "NO_APP_FILE",
                ResponseItemVariant3RuntimeStage5.ConfigError => "CONFIG_ERROR",
                ResponseItemVariant3RuntimeStage5.Building => "BUILDING",
                ResponseItemVariant3RuntimeStage5.BuildError => "BUILD_ERROR",
                ResponseItemVariant3RuntimeStage5.AppStarting => "APP_STARTING",
                ResponseItemVariant3RuntimeStage5.Running => "RUNNING",
                ResponseItemVariant3RuntimeStage5.RunningBuilding => "RUNNING_BUILDING",
                ResponseItemVariant3RuntimeStage5.RunningAppStarting => "RUNNING_APP_STARTING",
                ResponseItemVariant3RuntimeStage5.RuntimeError => "RUNTIME_ERROR",
                ResponseItemVariant3RuntimeStage5.Deleting => "DELETING",
                ResponseItemVariant3RuntimeStage5.Stopped => "STOPPED",
                ResponseItemVariant3RuntimeStage5.Paused => "PAUSED",
                ResponseItemVariant3RuntimeStage5.Sleeping => "SLEEPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3RuntimeStage5? ToEnum(string value)
        {
            return value switch
            {
                "NO_APP_FILE" => ResponseItemVariant3RuntimeStage5.NoAppFile,
                "CONFIG_ERROR" => ResponseItemVariant3RuntimeStage5.ConfigError,
                "BUILDING" => ResponseItemVariant3RuntimeStage5.Building,
                "BUILD_ERROR" => ResponseItemVariant3RuntimeStage5.BuildError,
                "APP_STARTING" => ResponseItemVariant3RuntimeStage5.AppStarting,
                "RUNNING" => ResponseItemVariant3RuntimeStage5.Running,
                "RUNNING_BUILDING" => ResponseItemVariant3RuntimeStage5.RunningBuilding,
                "RUNNING_APP_STARTING" => ResponseItemVariant3RuntimeStage5.RunningAppStarting,
                "RUNTIME_ERROR" => ResponseItemVariant3RuntimeStage5.RuntimeError,
                "DELETING" => ResponseItemVariant3RuntimeStage5.Deleting,
                "STOPPED" => ResponseItemVariant3RuntimeStage5.Stopped,
                "PAUSED" => ResponseItemVariant3RuntimeStage5.Paused,
                "SLEEPING" => ResponseItemVariant3RuntimeStage5.Sleeping,
                _ => null,
            };
        }
    }
}