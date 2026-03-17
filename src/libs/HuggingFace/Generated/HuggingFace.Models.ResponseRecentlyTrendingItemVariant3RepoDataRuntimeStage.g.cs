
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage
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
    public static class ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.NoAppFile => "NO_APP_FILE",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.ConfigError => "CONFIG_ERROR",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Building => "BUILDING",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.BuildError => "BUILD_ERROR",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.AppStarting => "APP_STARTING",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Running => "RUNNING",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.RunningBuilding => "RUNNING_BUILDING",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.RunningAppStarting => "RUNNING_APP_STARTING",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.RuntimeError => "RUNTIME_ERROR",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Deleting => "DELETING",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Stopped => "STOPPED",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Paused => "PAUSED",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Sleeping => "SLEEPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage? ToEnum(string value)
        {
            return value switch
            {
                "NO_APP_FILE" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.NoAppFile,
                "CONFIG_ERROR" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.ConfigError,
                "BUILDING" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Building,
                "BUILD_ERROR" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.BuildError,
                "APP_STARTING" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.AppStarting,
                "RUNNING" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Running,
                "RUNNING_BUILDING" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.RunningBuilding,
                "RUNNING_APP_STARTING" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.RunningAppStarting,
                "RUNTIME_ERROR" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.RuntimeError,
                "DELETING" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Deleting,
                "STOPPED" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Stopped,
                "PAUSED" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Paused,
                "SLEEPING" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Sleeping,
                _ => null,
            };
        }
    }
}