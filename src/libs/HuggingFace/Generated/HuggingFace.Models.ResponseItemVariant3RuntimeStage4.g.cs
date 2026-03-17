
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3RuntimeStage4
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
    public static class ResponseItemVariant3RuntimeStage4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3RuntimeStage4 value)
        {
            return value switch
            {
                ResponseItemVariant3RuntimeStage4.NoAppFile => "NO_APP_FILE",
                ResponseItemVariant3RuntimeStage4.ConfigError => "CONFIG_ERROR",
                ResponseItemVariant3RuntimeStage4.Building => "BUILDING",
                ResponseItemVariant3RuntimeStage4.BuildError => "BUILD_ERROR",
                ResponseItemVariant3RuntimeStage4.AppStarting => "APP_STARTING",
                ResponseItemVariant3RuntimeStage4.Running => "RUNNING",
                ResponseItemVariant3RuntimeStage4.RunningBuilding => "RUNNING_BUILDING",
                ResponseItemVariant3RuntimeStage4.RunningAppStarting => "RUNNING_APP_STARTING",
                ResponseItemVariant3RuntimeStage4.RuntimeError => "RUNTIME_ERROR",
                ResponseItemVariant3RuntimeStage4.Deleting => "DELETING",
                ResponseItemVariant3RuntimeStage4.Stopped => "STOPPED",
                ResponseItemVariant3RuntimeStage4.Paused => "PAUSED",
                ResponseItemVariant3RuntimeStage4.Sleeping => "SLEEPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3RuntimeStage4? ToEnum(string value)
        {
            return value switch
            {
                "NO_APP_FILE" => ResponseItemVariant3RuntimeStage4.NoAppFile,
                "CONFIG_ERROR" => ResponseItemVariant3RuntimeStage4.ConfigError,
                "BUILDING" => ResponseItemVariant3RuntimeStage4.Building,
                "BUILD_ERROR" => ResponseItemVariant3RuntimeStage4.BuildError,
                "APP_STARTING" => ResponseItemVariant3RuntimeStage4.AppStarting,
                "RUNNING" => ResponseItemVariant3RuntimeStage4.Running,
                "RUNNING_BUILDING" => ResponseItemVariant3RuntimeStage4.RunningBuilding,
                "RUNNING_APP_STARTING" => ResponseItemVariant3RuntimeStage4.RunningAppStarting,
                "RUNTIME_ERROR" => ResponseItemVariant3RuntimeStage4.RuntimeError,
                "DELETING" => ResponseItemVariant3RuntimeStage4.Deleting,
                "STOPPED" => ResponseItemVariant3RuntimeStage4.Stopped,
                "PAUSED" => ResponseItemVariant3RuntimeStage4.Paused,
                "SLEEPING" => ResponseItemVariant3RuntimeStage4.Sleeping,
                _ => null,
            };
        }
    }
}