
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3RuntimeStage3
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
    public static class ResponseItemVariant3RuntimeStage3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3RuntimeStage3 value)
        {
            return value switch
            {
                ResponseItemVariant3RuntimeStage3.NoAppFile => "NO_APP_FILE",
                ResponseItemVariant3RuntimeStage3.ConfigError => "CONFIG_ERROR",
                ResponseItemVariant3RuntimeStage3.Building => "BUILDING",
                ResponseItemVariant3RuntimeStage3.BuildError => "BUILD_ERROR",
                ResponseItemVariant3RuntimeStage3.AppStarting => "APP_STARTING",
                ResponseItemVariant3RuntimeStage3.Running => "RUNNING",
                ResponseItemVariant3RuntimeStage3.RunningBuilding => "RUNNING_BUILDING",
                ResponseItemVariant3RuntimeStage3.RunningAppStarting => "RUNNING_APP_STARTING",
                ResponseItemVariant3RuntimeStage3.RuntimeError => "RUNTIME_ERROR",
                ResponseItemVariant3RuntimeStage3.Deleting => "DELETING",
                ResponseItemVariant3RuntimeStage3.Stopped => "STOPPED",
                ResponseItemVariant3RuntimeStage3.Paused => "PAUSED",
                ResponseItemVariant3RuntimeStage3.Sleeping => "SLEEPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3RuntimeStage3? ToEnum(string value)
        {
            return value switch
            {
                "NO_APP_FILE" => ResponseItemVariant3RuntimeStage3.NoAppFile,
                "CONFIG_ERROR" => ResponseItemVariant3RuntimeStage3.ConfigError,
                "BUILDING" => ResponseItemVariant3RuntimeStage3.Building,
                "BUILD_ERROR" => ResponseItemVariant3RuntimeStage3.BuildError,
                "APP_STARTING" => ResponseItemVariant3RuntimeStage3.AppStarting,
                "RUNNING" => ResponseItemVariant3RuntimeStage3.Running,
                "RUNNING_BUILDING" => ResponseItemVariant3RuntimeStage3.RunningBuilding,
                "RUNNING_APP_STARTING" => ResponseItemVariant3RuntimeStage3.RunningAppStarting,
                "RUNTIME_ERROR" => ResponseItemVariant3RuntimeStage3.RuntimeError,
                "DELETING" => ResponseItemVariant3RuntimeStage3.Deleting,
                "STOPPED" => ResponseItemVariant3RuntimeStage3.Stopped,
                "PAUSED" => ResponseItemVariant3RuntimeStage3.Paused,
                "SLEEPING" => ResponseItemVariant3RuntimeStage3.Sleeping,
                _ => null,
            };
        }
    }
}