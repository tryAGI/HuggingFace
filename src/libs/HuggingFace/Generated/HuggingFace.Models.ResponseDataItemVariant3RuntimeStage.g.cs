
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3RuntimeStage
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
    public static class ResponseDataItemVariant3RuntimeStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3RuntimeStage value)
        {
            return value switch
            {
                ResponseDataItemVariant3RuntimeStage.NoAppFile => "NO_APP_FILE",
                ResponseDataItemVariant3RuntimeStage.ConfigError => "CONFIG_ERROR",
                ResponseDataItemVariant3RuntimeStage.Building => "BUILDING",
                ResponseDataItemVariant3RuntimeStage.BuildError => "BUILD_ERROR",
                ResponseDataItemVariant3RuntimeStage.AppStarting => "APP_STARTING",
                ResponseDataItemVariant3RuntimeStage.Running => "RUNNING",
                ResponseDataItemVariant3RuntimeStage.RunningBuilding => "RUNNING_BUILDING",
                ResponseDataItemVariant3RuntimeStage.RunningAppStarting => "RUNNING_APP_STARTING",
                ResponseDataItemVariant3RuntimeStage.RuntimeError => "RUNTIME_ERROR",
                ResponseDataItemVariant3RuntimeStage.Deleting => "DELETING",
                ResponseDataItemVariant3RuntimeStage.Stopped => "STOPPED",
                ResponseDataItemVariant3RuntimeStage.Paused => "PAUSED",
                ResponseDataItemVariant3RuntimeStage.Sleeping => "SLEEPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3RuntimeStage? ToEnum(string value)
        {
            return value switch
            {
                "NO_APP_FILE" => ResponseDataItemVariant3RuntimeStage.NoAppFile,
                "CONFIG_ERROR" => ResponseDataItemVariant3RuntimeStage.ConfigError,
                "BUILDING" => ResponseDataItemVariant3RuntimeStage.Building,
                "BUILD_ERROR" => ResponseDataItemVariant3RuntimeStage.BuildError,
                "APP_STARTING" => ResponseDataItemVariant3RuntimeStage.AppStarting,
                "RUNNING" => ResponseDataItemVariant3RuntimeStage.Running,
                "RUNNING_BUILDING" => ResponseDataItemVariant3RuntimeStage.RunningBuilding,
                "RUNNING_APP_STARTING" => ResponseDataItemVariant3RuntimeStage.RunningAppStarting,
                "RUNTIME_ERROR" => ResponseDataItemVariant3RuntimeStage.RuntimeError,
                "DELETING" => ResponseDataItemVariant3RuntimeStage.Deleting,
                "STOPPED" => ResponseDataItemVariant3RuntimeStage.Stopped,
                "PAUSED" => ResponseDataItemVariant3RuntimeStage.Paused,
                "SLEEPING" => ResponseDataItemVariant3RuntimeStage.Sleeping,
                _ => null,
            };
        }
    }
}