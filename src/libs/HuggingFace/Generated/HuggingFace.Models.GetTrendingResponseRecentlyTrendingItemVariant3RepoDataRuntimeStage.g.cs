
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage
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
    public static class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.AppStarting => "APP_STARTING",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Building => "BUILDING",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.BuildError => "BUILD_ERROR",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.ConfigError => "CONFIG_ERROR",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Deleting => "DELETING",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.NoAppFile => "NO_APP_FILE",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Paused => "PAUSED",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Running => "RUNNING",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.RunningAppStarting => "RUNNING_APP_STARTING",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.RunningBuilding => "RUNNING_BUILDING",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.RuntimeError => "RUNTIME_ERROR",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Sleeping => "SLEEPING",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Stopped => "STOPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage? ToEnum(string value)
        {
            return value switch
            {
                "APP_STARTING" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.AppStarting,
                "BUILDING" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Building,
                "BUILD_ERROR" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.BuildError,
                "CONFIG_ERROR" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.ConfigError,
                "DELETING" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Deleting,
                "NO_APP_FILE" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.NoAppFile,
                "PAUSED" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Paused,
                "RUNNING" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Running,
                "RUNNING_APP_STARTING" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.RunningAppStarting,
                "RUNNING_BUILDING" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.RunningBuilding,
                "RUNTIME_ERROR" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.RuntimeError,
                "SLEEPING" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Sleeping,
                "STOPPED" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage.Stopped,
                _ => null,
            };
        }
    }
}