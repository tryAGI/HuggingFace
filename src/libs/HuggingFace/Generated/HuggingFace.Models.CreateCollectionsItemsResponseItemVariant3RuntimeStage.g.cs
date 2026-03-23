
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3RuntimeStage
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
    public static class CreateCollectionsItemsResponseItemVariant3RuntimeStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3RuntimeStage value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3RuntimeStage.AppStarting => "APP_STARTING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage.Building => "BUILDING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage.BuildError => "BUILD_ERROR",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage.ConfigError => "CONFIG_ERROR",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage.Deleting => "DELETING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage.NoAppFile => "NO_APP_FILE",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage.Paused => "PAUSED",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage.Running => "RUNNING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage.RunningAppStarting => "RUNNING_APP_STARTING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage.RunningBuilding => "RUNNING_BUILDING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage.RuntimeError => "RUNTIME_ERROR",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage.Sleeping => "SLEEPING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage.Stopped => "STOPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3RuntimeStage? ToEnum(string value)
        {
            return value switch
            {
                "APP_STARTING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage.AppStarting,
                "BUILDING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage.Building,
                "BUILD_ERROR" => CreateCollectionsItemsResponseItemVariant3RuntimeStage.BuildError,
                "CONFIG_ERROR" => CreateCollectionsItemsResponseItemVariant3RuntimeStage.ConfigError,
                "DELETING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage.Deleting,
                "NO_APP_FILE" => CreateCollectionsItemsResponseItemVariant3RuntimeStage.NoAppFile,
                "PAUSED" => CreateCollectionsItemsResponseItemVariant3RuntimeStage.Paused,
                "RUNNING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage.Running,
                "RUNNING_APP_STARTING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage.RunningAppStarting,
                "RUNNING_BUILDING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage.RunningBuilding,
                "RUNTIME_ERROR" => CreateCollectionsItemsResponseItemVariant3RuntimeStage.RuntimeError,
                "SLEEPING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage.Sleeping,
                "STOPPED" => CreateCollectionsItemsResponseItemVariant3RuntimeStage.Stopped,
                _ => null,
            };
        }
    }
}