#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public class GrammarTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GrammarType>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GrammarType Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::HuggingFace.GrammarTypeVariant1? json = default;
            global::HuggingFace.GrammarTypeVariant2? regex = default;
            global::HuggingFace.GrammarTypeVariant3? jsonSchema = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GrammarTypeVariant1).Name}");
                        json = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GrammarTypeVariant2).Name}");
                        regex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GrammarTypeVariant3).Name}");
                        jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (json == null && regex == null && jsonSchema == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GrammarTypeVariant1).Name}");
                    json = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GrammarTypeVariant2).Name}");
                    regex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GrammarTypeVariant3).Name}");
                    jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::HuggingFace.GrammarType(
                json,

                regex,

                jsonSchema
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GrammarType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GrammarTypeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Json!, typeInfo);
            }
            else if (value.IsRegex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GrammarTypeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Regex!, typeInfo);
            }
            else if (value.IsJsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GrammarTypeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonSchema!, typeInfo);
            }
        }
    }
}