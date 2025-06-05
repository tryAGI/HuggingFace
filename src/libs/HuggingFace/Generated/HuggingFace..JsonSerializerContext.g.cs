
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),
            typeof(global::HuggingFace.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}