
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3RuntimeStage
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
    public static class GetCollectionsResponseItemVariant3RuntimeStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3RuntimeStage value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3RuntimeStage.AppStarting => "APP_STARTING",
                GetCollectionsResponseItemVariant3RuntimeStage.Building => "BUILDING",
                GetCollectionsResponseItemVariant3RuntimeStage.BuildError => "BUILD_ERROR",
                GetCollectionsResponseItemVariant3RuntimeStage.ConfigError => "CONFIG_ERROR",
                GetCollectionsResponseItemVariant3RuntimeStage.Deleting => "DELETING",
                GetCollectionsResponseItemVariant3RuntimeStage.NoAppFile => "NO_APP_FILE",
                GetCollectionsResponseItemVariant3RuntimeStage.Paused => "PAUSED",
                GetCollectionsResponseItemVariant3RuntimeStage.Running => "RUNNING",
                GetCollectionsResponseItemVariant3RuntimeStage.RunningAppStarting => "RUNNING_APP_STARTING",
                GetCollectionsResponseItemVariant3RuntimeStage.RunningBuilding => "RUNNING_BUILDING",
                GetCollectionsResponseItemVariant3RuntimeStage.RuntimeError => "RUNTIME_ERROR",
                GetCollectionsResponseItemVariant3RuntimeStage.Sleeping => "SLEEPING",
                GetCollectionsResponseItemVariant3RuntimeStage.Stopped => "STOPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3RuntimeStage? ToEnum(string value)
        {
            return value switch
            {
                "APP_STARTING" => GetCollectionsResponseItemVariant3RuntimeStage.AppStarting,
                "BUILDING" => GetCollectionsResponseItemVariant3RuntimeStage.Building,
                "BUILD_ERROR" => GetCollectionsResponseItemVariant3RuntimeStage.BuildError,
                "CONFIG_ERROR" => GetCollectionsResponseItemVariant3RuntimeStage.ConfigError,
                "DELETING" => GetCollectionsResponseItemVariant3RuntimeStage.Deleting,
                "NO_APP_FILE" => GetCollectionsResponseItemVariant3RuntimeStage.NoAppFile,
                "PAUSED" => GetCollectionsResponseItemVariant3RuntimeStage.Paused,
                "RUNNING" => GetCollectionsResponseItemVariant3RuntimeStage.Running,
                "RUNNING_APP_STARTING" => GetCollectionsResponseItemVariant3RuntimeStage.RunningAppStarting,
                "RUNNING_BUILDING" => GetCollectionsResponseItemVariant3RuntimeStage.RunningBuilding,
                "RUNTIME_ERROR" => GetCollectionsResponseItemVariant3RuntimeStage.RuntimeError,
                "SLEEPING" => GetCollectionsResponseItemVariant3RuntimeStage.Sleeping,
                "STOPPED" => GetCollectionsResponseItemVariant3RuntimeStage.Stopped,
                _ => null,
            };
        }
    }
}