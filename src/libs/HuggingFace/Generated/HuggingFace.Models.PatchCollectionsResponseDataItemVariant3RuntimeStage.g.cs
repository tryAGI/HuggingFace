
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3RuntimeStage
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
    public static class PatchCollectionsResponseDataItemVariant3RuntimeStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3RuntimeStage value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3RuntimeStage.AppStarting => "APP_STARTING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage.Building => "BUILDING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage.BuildError => "BUILD_ERROR",
                PatchCollectionsResponseDataItemVariant3RuntimeStage.ConfigError => "CONFIG_ERROR",
                PatchCollectionsResponseDataItemVariant3RuntimeStage.Deleting => "DELETING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage.NoAppFile => "NO_APP_FILE",
                PatchCollectionsResponseDataItemVariant3RuntimeStage.Paused => "PAUSED",
                PatchCollectionsResponseDataItemVariant3RuntimeStage.Running => "RUNNING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage.RunningAppStarting => "RUNNING_APP_STARTING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage.RunningBuilding => "RUNNING_BUILDING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage.RuntimeError => "RUNTIME_ERROR",
                PatchCollectionsResponseDataItemVariant3RuntimeStage.Sleeping => "SLEEPING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage.Stopped => "STOPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3RuntimeStage? ToEnum(string value)
        {
            return value switch
            {
                "APP_STARTING" => PatchCollectionsResponseDataItemVariant3RuntimeStage.AppStarting,
                "BUILDING" => PatchCollectionsResponseDataItemVariant3RuntimeStage.Building,
                "BUILD_ERROR" => PatchCollectionsResponseDataItemVariant3RuntimeStage.BuildError,
                "CONFIG_ERROR" => PatchCollectionsResponseDataItemVariant3RuntimeStage.ConfigError,
                "DELETING" => PatchCollectionsResponseDataItemVariant3RuntimeStage.Deleting,
                "NO_APP_FILE" => PatchCollectionsResponseDataItemVariant3RuntimeStage.NoAppFile,
                "PAUSED" => PatchCollectionsResponseDataItemVariant3RuntimeStage.Paused,
                "RUNNING" => PatchCollectionsResponseDataItemVariant3RuntimeStage.Running,
                "RUNNING_APP_STARTING" => PatchCollectionsResponseDataItemVariant3RuntimeStage.RunningAppStarting,
                "RUNNING_BUILDING" => PatchCollectionsResponseDataItemVariant3RuntimeStage.RunningBuilding,
                "RUNTIME_ERROR" => PatchCollectionsResponseDataItemVariant3RuntimeStage.RuntimeError,
                "SLEEPING" => PatchCollectionsResponseDataItemVariant3RuntimeStage.Sleeping,
                "STOPPED" => PatchCollectionsResponseDataItemVariant3RuntimeStage.Stopped,
                _ => null,
            };
        }
    }
}