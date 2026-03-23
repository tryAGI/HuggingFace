
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3RuntimeStage2
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
    public static class CreateCollectionsItemsResponseItemVariant3RuntimeStage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3RuntimeStage2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3RuntimeStage2.AppStarting => "APP_STARTING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage2.Building => "BUILDING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage2.BuildError => "BUILD_ERROR",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage2.ConfigError => "CONFIG_ERROR",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage2.Deleting => "DELETING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage2.NoAppFile => "NO_APP_FILE",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage2.Paused => "PAUSED",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage2.Running => "RUNNING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage2.RunningAppStarting => "RUNNING_APP_STARTING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage2.RunningBuilding => "RUNNING_BUILDING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage2.RuntimeError => "RUNTIME_ERROR",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage2.Sleeping => "SLEEPING",
                CreateCollectionsItemsResponseItemVariant3RuntimeStage2.Stopped => "STOPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3RuntimeStage2? ToEnum(string value)
        {
            return value switch
            {
                "APP_STARTING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage2.AppStarting,
                "BUILDING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage2.Building,
                "BUILD_ERROR" => CreateCollectionsItemsResponseItemVariant3RuntimeStage2.BuildError,
                "CONFIG_ERROR" => CreateCollectionsItemsResponseItemVariant3RuntimeStage2.ConfigError,
                "DELETING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage2.Deleting,
                "NO_APP_FILE" => CreateCollectionsItemsResponseItemVariant3RuntimeStage2.NoAppFile,
                "PAUSED" => CreateCollectionsItemsResponseItemVariant3RuntimeStage2.Paused,
                "RUNNING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage2.Running,
                "RUNNING_APP_STARTING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage2.RunningAppStarting,
                "RUNNING_BUILDING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage2.RunningBuilding,
                "RUNTIME_ERROR" => CreateCollectionsItemsResponseItemVariant3RuntimeStage2.RuntimeError,
                "SLEEPING" => CreateCollectionsItemsResponseItemVariant3RuntimeStage2.Sleeping,
                "STOPPED" => CreateCollectionsItemsResponseItemVariant3RuntimeStage2.Stopped,
                _ => null,
            };
        }
    }
}