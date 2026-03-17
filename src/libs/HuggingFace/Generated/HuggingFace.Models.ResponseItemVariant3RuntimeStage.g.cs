
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3RuntimeStage
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
    public static class ResponseItemVariant3RuntimeStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3RuntimeStage value)
        {
            return value switch
            {
                ResponseItemVariant3RuntimeStage.NoAppFile => "NO_APP_FILE",
                ResponseItemVariant3RuntimeStage.ConfigError => "CONFIG_ERROR",
                ResponseItemVariant3RuntimeStage.Building => "BUILDING",
                ResponseItemVariant3RuntimeStage.BuildError => "BUILD_ERROR",
                ResponseItemVariant3RuntimeStage.AppStarting => "APP_STARTING",
                ResponseItemVariant3RuntimeStage.Running => "RUNNING",
                ResponseItemVariant3RuntimeStage.RunningBuilding => "RUNNING_BUILDING",
                ResponseItemVariant3RuntimeStage.RunningAppStarting => "RUNNING_APP_STARTING",
                ResponseItemVariant3RuntimeStage.RuntimeError => "RUNTIME_ERROR",
                ResponseItemVariant3RuntimeStage.Deleting => "DELETING",
                ResponseItemVariant3RuntimeStage.Stopped => "STOPPED",
                ResponseItemVariant3RuntimeStage.Paused => "PAUSED",
                ResponseItemVariant3RuntimeStage.Sleeping => "SLEEPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3RuntimeStage? ToEnum(string value)
        {
            return value switch
            {
                "NO_APP_FILE" => ResponseItemVariant3RuntimeStage.NoAppFile,
                "CONFIG_ERROR" => ResponseItemVariant3RuntimeStage.ConfigError,
                "BUILDING" => ResponseItemVariant3RuntimeStage.Building,
                "BUILD_ERROR" => ResponseItemVariant3RuntimeStage.BuildError,
                "APP_STARTING" => ResponseItemVariant3RuntimeStage.AppStarting,
                "RUNNING" => ResponseItemVariant3RuntimeStage.Running,
                "RUNNING_BUILDING" => ResponseItemVariant3RuntimeStage.RunningBuilding,
                "RUNNING_APP_STARTING" => ResponseItemVariant3RuntimeStage.RunningAppStarting,
                "RUNTIME_ERROR" => ResponseItemVariant3RuntimeStage.RuntimeError,
                "DELETING" => ResponseItemVariant3RuntimeStage.Deleting,
                "STOPPED" => ResponseItemVariant3RuntimeStage.Stopped,
                "PAUSED" => ResponseItemVariant3RuntimeStage.Paused,
                "SLEEPING" => ResponseItemVariant3RuntimeStage.Sleeping,
                _ => null,
            };
        }
    }
}