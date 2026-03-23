
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant3RuntimeStage
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
    public static class CreateCollectionsResponseItemVariant3RuntimeStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant3RuntimeStage value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant3RuntimeStage.AppStarting => "APP_STARTING",
                CreateCollectionsResponseItemVariant3RuntimeStage.Building => "BUILDING",
                CreateCollectionsResponseItemVariant3RuntimeStage.BuildError => "BUILD_ERROR",
                CreateCollectionsResponseItemVariant3RuntimeStage.ConfigError => "CONFIG_ERROR",
                CreateCollectionsResponseItemVariant3RuntimeStage.Deleting => "DELETING",
                CreateCollectionsResponseItemVariant3RuntimeStage.NoAppFile => "NO_APP_FILE",
                CreateCollectionsResponseItemVariant3RuntimeStage.Paused => "PAUSED",
                CreateCollectionsResponseItemVariant3RuntimeStage.Running => "RUNNING",
                CreateCollectionsResponseItemVariant3RuntimeStage.RunningAppStarting => "RUNNING_APP_STARTING",
                CreateCollectionsResponseItemVariant3RuntimeStage.RunningBuilding => "RUNNING_BUILDING",
                CreateCollectionsResponseItemVariant3RuntimeStage.RuntimeError => "RUNTIME_ERROR",
                CreateCollectionsResponseItemVariant3RuntimeStage.Sleeping => "SLEEPING",
                CreateCollectionsResponseItemVariant3RuntimeStage.Stopped => "STOPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant3RuntimeStage? ToEnum(string value)
        {
            return value switch
            {
                "APP_STARTING" => CreateCollectionsResponseItemVariant3RuntimeStage.AppStarting,
                "BUILDING" => CreateCollectionsResponseItemVariant3RuntimeStage.Building,
                "BUILD_ERROR" => CreateCollectionsResponseItemVariant3RuntimeStage.BuildError,
                "CONFIG_ERROR" => CreateCollectionsResponseItemVariant3RuntimeStage.ConfigError,
                "DELETING" => CreateCollectionsResponseItemVariant3RuntimeStage.Deleting,
                "NO_APP_FILE" => CreateCollectionsResponseItemVariant3RuntimeStage.NoAppFile,
                "PAUSED" => CreateCollectionsResponseItemVariant3RuntimeStage.Paused,
                "RUNNING" => CreateCollectionsResponseItemVariant3RuntimeStage.Running,
                "RUNNING_APP_STARTING" => CreateCollectionsResponseItemVariant3RuntimeStage.RunningAppStarting,
                "RUNNING_BUILDING" => CreateCollectionsResponseItemVariant3RuntimeStage.RunningBuilding,
                "RUNTIME_ERROR" => CreateCollectionsResponseItemVariant3RuntimeStage.RuntimeError,
                "SLEEPING" => CreateCollectionsResponseItemVariant3RuntimeStage.Sleeping,
                "STOPPED" => CreateCollectionsResponseItemVariant3RuntimeStage.Stopped,
                _ => null,
            };
        }
    }
}