
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3RuntimeStage2
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
    public static class GetCollectionsResponseItemVariant3RuntimeStage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3RuntimeStage2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3RuntimeStage2.AppStarting => "APP_STARTING",
                GetCollectionsResponseItemVariant3RuntimeStage2.Building => "BUILDING",
                GetCollectionsResponseItemVariant3RuntimeStage2.BuildError => "BUILD_ERROR",
                GetCollectionsResponseItemVariant3RuntimeStage2.ConfigError => "CONFIG_ERROR",
                GetCollectionsResponseItemVariant3RuntimeStage2.Deleting => "DELETING",
                GetCollectionsResponseItemVariant3RuntimeStage2.NoAppFile => "NO_APP_FILE",
                GetCollectionsResponseItemVariant3RuntimeStage2.Paused => "PAUSED",
                GetCollectionsResponseItemVariant3RuntimeStage2.Running => "RUNNING",
                GetCollectionsResponseItemVariant3RuntimeStage2.RunningAppStarting => "RUNNING_APP_STARTING",
                GetCollectionsResponseItemVariant3RuntimeStage2.RunningBuilding => "RUNNING_BUILDING",
                GetCollectionsResponseItemVariant3RuntimeStage2.RuntimeError => "RUNTIME_ERROR",
                GetCollectionsResponseItemVariant3RuntimeStage2.Sleeping => "SLEEPING",
                GetCollectionsResponseItemVariant3RuntimeStage2.Stopped => "STOPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3RuntimeStage2? ToEnum(string value)
        {
            return value switch
            {
                "APP_STARTING" => GetCollectionsResponseItemVariant3RuntimeStage2.AppStarting,
                "BUILDING" => GetCollectionsResponseItemVariant3RuntimeStage2.Building,
                "BUILD_ERROR" => GetCollectionsResponseItemVariant3RuntimeStage2.BuildError,
                "CONFIG_ERROR" => GetCollectionsResponseItemVariant3RuntimeStage2.ConfigError,
                "DELETING" => GetCollectionsResponseItemVariant3RuntimeStage2.Deleting,
                "NO_APP_FILE" => GetCollectionsResponseItemVariant3RuntimeStage2.NoAppFile,
                "PAUSED" => GetCollectionsResponseItemVariant3RuntimeStage2.Paused,
                "RUNNING" => GetCollectionsResponseItemVariant3RuntimeStage2.Running,
                "RUNNING_APP_STARTING" => GetCollectionsResponseItemVariant3RuntimeStage2.RunningAppStarting,
                "RUNNING_BUILDING" => GetCollectionsResponseItemVariant3RuntimeStage2.RunningBuilding,
                "RUNTIME_ERROR" => GetCollectionsResponseItemVariant3RuntimeStage2.RuntimeError,
                "SLEEPING" => GetCollectionsResponseItemVariant3RuntimeStage2.Sleeping,
                "STOPPED" => GetCollectionsResponseItemVariant3RuntimeStage2.Stopped,
                _ => null,
            };
        }
    }
}