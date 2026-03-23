
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3RuntimeStage2
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
    public static class PatchCollectionsResponseDataItemVariant3RuntimeStage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3RuntimeStage2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3RuntimeStage2.AppStarting => "APP_STARTING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage2.Building => "BUILDING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage2.BuildError => "BUILD_ERROR",
                PatchCollectionsResponseDataItemVariant3RuntimeStage2.ConfigError => "CONFIG_ERROR",
                PatchCollectionsResponseDataItemVariant3RuntimeStage2.Deleting => "DELETING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage2.NoAppFile => "NO_APP_FILE",
                PatchCollectionsResponseDataItemVariant3RuntimeStage2.Paused => "PAUSED",
                PatchCollectionsResponseDataItemVariant3RuntimeStage2.Running => "RUNNING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage2.RunningAppStarting => "RUNNING_APP_STARTING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage2.RunningBuilding => "RUNNING_BUILDING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage2.RuntimeError => "RUNTIME_ERROR",
                PatchCollectionsResponseDataItemVariant3RuntimeStage2.Sleeping => "SLEEPING",
                PatchCollectionsResponseDataItemVariant3RuntimeStage2.Stopped => "STOPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3RuntimeStage2? ToEnum(string value)
        {
            return value switch
            {
                "APP_STARTING" => PatchCollectionsResponseDataItemVariant3RuntimeStage2.AppStarting,
                "BUILDING" => PatchCollectionsResponseDataItemVariant3RuntimeStage2.Building,
                "BUILD_ERROR" => PatchCollectionsResponseDataItemVariant3RuntimeStage2.BuildError,
                "CONFIG_ERROR" => PatchCollectionsResponseDataItemVariant3RuntimeStage2.ConfigError,
                "DELETING" => PatchCollectionsResponseDataItemVariant3RuntimeStage2.Deleting,
                "NO_APP_FILE" => PatchCollectionsResponseDataItemVariant3RuntimeStage2.NoAppFile,
                "PAUSED" => PatchCollectionsResponseDataItemVariant3RuntimeStage2.Paused,
                "RUNNING" => PatchCollectionsResponseDataItemVariant3RuntimeStage2.Running,
                "RUNNING_APP_STARTING" => PatchCollectionsResponseDataItemVariant3RuntimeStage2.RunningAppStarting,
                "RUNNING_BUILDING" => PatchCollectionsResponseDataItemVariant3RuntimeStage2.RunningBuilding,
                "RUNTIME_ERROR" => PatchCollectionsResponseDataItemVariant3RuntimeStage2.RuntimeError,
                "SLEEPING" => PatchCollectionsResponseDataItemVariant3RuntimeStage2.Sleeping,
                "STOPPED" => PatchCollectionsResponseDataItemVariant3RuntimeStage2.Stopped,
                _ => null,
            };
        }
    }
}