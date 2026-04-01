#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public class ToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.ToolChoice>
    {
        /// <inheritdoc />
        public override global::HuggingFace.ToolChoice Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            if (__jsonProps.Contains("function")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::HuggingFace.ToolChoiceVariant1? value1 = default;
            global::HuggingFace.ToolChoiceVariant2? value2 = default;
            global::HuggingFace.ToolChoiceVariant3? value3 = default;
            global::HuggingFace.ToolChoiceVariant4? value4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolChoiceVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolChoiceVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolChoiceVariant1).Name}");
                        value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolChoiceVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolChoiceVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolChoiceVariant2).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolChoiceVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolChoiceVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolChoiceVariant3).Name}");
                        value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolChoiceVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolChoiceVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolChoiceVariant4).Name}");
                        value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null && value3 == null && value4 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolChoiceVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolChoiceVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolChoiceVariant1).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolChoiceVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolChoiceVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolChoiceVariant2).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolChoiceVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolChoiceVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolChoiceVariant3).Name}");
                    value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolChoiceVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolChoiceVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolChoiceVariant4).Name}");
                    value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::HuggingFace.ToolChoice(
                value1,

                value2,

                value3,

                value4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.ToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolChoiceVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolChoiceVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolChoiceVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1!.Value, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolChoiceVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolChoiceVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolChoiceVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!.Value, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolChoiceVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolChoiceVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolChoiceVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3!.Value, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolChoiceVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolChoiceVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolChoiceVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4!, typeInfo);
            }
        }
    }
}