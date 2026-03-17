
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant3RuntimeStage
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
    public static class ResponseVariant1ItemItemVariant3RuntimeStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant3RuntimeStage value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant3RuntimeStage.NoAppFile => "NO_APP_FILE",
                ResponseVariant1ItemItemVariant3RuntimeStage.ConfigError => "CONFIG_ERROR",
                ResponseVariant1ItemItemVariant3RuntimeStage.Building => "BUILDING",
                ResponseVariant1ItemItemVariant3RuntimeStage.BuildError => "BUILD_ERROR",
                ResponseVariant1ItemItemVariant3RuntimeStage.AppStarting => "APP_STARTING",
                ResponseVariant1ItemItemVariant3RuntimeStage.Running => "RUNNING",
                ResponseVariant1ItemItemVariant3RuntimeStage.RunningBuilding => "RUNNING_BUILDING",
                ResponseVariant1ItemItemVariant3RuntimeStage.RunningAppStarting => "RUNNING_APP_STARTING",
                ResponseVariant1ItemItemVariant3RuntimeStage.RuntimeError => "RUNTIME_ERROR",
                ResponseVariant1ItemItemVariant3RuntimeStage.Deleting => "DELETING",
                ResponseVariant1ItemItemVariant3RuntimeStage.Stopped => "STOPPED",
                ResponseVariant1ItemItemVariant3RuntimeStage.Paused => "PAUSED",
                ResponseVariant1ItemItemVariant3RuntimeStage.Sleeping => "SLEEPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant3RuntimeStage? ToEnum(string value)
        {
            return value switch
            {
                "NO_APP_FILE" => ResponseVariant1ItemItemVariant3RuntimeStage.NoAppFile,
                "CONFIG_ERROR" => ResponseVariant1ItemItemVariant3RuntimeStage.ConfigError,
                "BUILDING" => ResponseVariant1ItemItemVariant3RuntimeStage.Building,
                "BUILD_ERROR" => ResponseVariant1ItemItemVariant3RuntimeStage.BuildError,
                "APP_STARTING" => ResponseVariant1ItemItemVariant3RuntimeStage.AppStarting,
                "RUNNING" => ResponseVariant1ItemItemVariant3RuntimeStage.Running,
                "RUNNING_BUILDING" => ResponseVariant1ItemItemVariant3RuntimeStage.RunningBuilding,
                "RUNNING_APP_STARTING" => ResponseVariant1ItemItemVariant3RuntimeStage.RunningAppStarting,
                "RUNTIME_ERROR" => ResponseVariant1ItemItemVariant3RuntimeStage.RuntimeError,
                "DELETING" => ResponseVariant1ItemItemVariant3RuntimeStage.Deleting,
                "STOPPED" => ResponseVariant1ItemItemVariant3RuntimeStage.Stopped,
                "PAUSED" => ResponseVariant1ItemItemVariant3RuntimeStage.Paused,
                "SLEEPING" => ResponseVariant1ItemItemVariant3RuntimeStage.Sleeping,
                _ => null,
            };
        }
    }
}