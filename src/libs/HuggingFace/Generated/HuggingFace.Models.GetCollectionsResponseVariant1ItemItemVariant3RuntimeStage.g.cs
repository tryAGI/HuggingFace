
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage
    {
        /// <summary>
        /// 
        /// </summary>
        AppStarting,
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
        ConfigError,
        /// <summary>
        /// 
        /// </summary>
        Deleting,
        /// <summary>
        /// 
        /// </summary>
        NoAppFile,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        RunningAppStarting,
        /// <summary>
        /// 
        /// </summary>
        RunningBuilding,
        /// <summary>
        /// 
        /// </summary>
        RuntimeError,
        /// <summary>
        /// 
        /// </summary>
        Sleeping,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCollectionsResponseVariant1ItemItemVariant3RuntimeStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.AppStarting => "APP_STARTING",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.Building => "BUILDING",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.BuildError => "BUILD_ERROR",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.ConfigError => "CONFIG_ERROR",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.Deleting => "DELETING",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.NoAppFile => "NO_APP_FILE",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.Paused => "PAUSED",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.Running => "RUNNING",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.RunningAppStarting => "RUNNING_APP_STARTING",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.RunningBuilding => "RUNNING_BUILDING",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.RuntimeError => "RUNTIME_ERROR",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.Sleeping => "SLEEPING",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.Stopped => "STOPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage? ToEnum(string value)
        {
            return value switch
            {
                "APP_STARTING" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.AppStarting,
                "BUILDING" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.Building,
                "BUILD_ERROR" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.BuildError,
                "CONFIG_ERROR" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.ConfigError,
                "DELETING" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.Deleting,
                "NO_APP_FILE" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.NoAppFile,
                "PAUSED" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.Paused,
                "RUNNING" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.Running,
                "RUNNING_APP_STARTING" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.RunningAppStarting,
                "RUNNING_BUILDING" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.RunningBuilding,
                "RUNTIME_ERROR" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.RuntimeError,
                "SLEEPING" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.Sleeping,
                "STOPPED" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage.Stopped,
                _ => null,
            };
        }
    }
}