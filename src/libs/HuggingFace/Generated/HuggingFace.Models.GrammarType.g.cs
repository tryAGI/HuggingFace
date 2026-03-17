#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GrammarType : global::System.IEquatable<GrammarType>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.GrammarTypeVariant1? Json { get; init; }
#else
        public global::HuggingFace.GrammarTypeVariant1? Json { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Json))]
#endif
        public bool IsJson => Json != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.GrammarTypeVariant2? Regex { get; init; }
#else
        public global::HuggingFace.GrammarTypeVariant2? Regex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Regex))]
#endif
        public bool IsRegex => Regex != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.GrammarTypeVariant3? JsonSchema { get; init; }
#else
        public global::HuggingFace.GrammarTypeVariant3? JsonSchema { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonSchema))]
#endif
        public bool IsJsonSchema => JsonSchema != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GrammarType(global::HuggingFace.GrammarTypeVariant1 value) => new GrammarType((global::HuggingFace.GrammarTypeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.GrammarTypeVariant1?(GrammarType @this) => @this.Json;

        /// <summary>
        /// 
        /// </summary>
        public GrammarType(global::HuggingFace.GrammarTypeVariant1? value)
        {
            Json = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GrammarType(global::HuggingFace.GrammarTypeVariant2 value) => new GrammarType((global::HuggingFace.GrammarTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.GrammarTypeVariant2?(GrammarType @this) => @this.Regex;

        /// <summary>
        /// 
        /// </summary>
        public GrammarType(global::HuggingFace.GrammarTypeVariant2? value)
        {
            Regex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GrammarType(global::HuggingFace.GrammarTypeVariant3 value) => new GrammarType((global::HuggingFace.GrammarTypeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.GrammarTypeVariant3?(GrammarType @this) => @this.JsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public GrammarType(global::HuggingFace.GrammarTypeVariant3? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GrammarType(
            global::HuggingFace.GrammarTypeVariant1? json,
            global::HuggingFace.GrammarTypeVariant2? regex,
            global::HuggingFace.GrammarTypeVariant3? jsonSchema
            )
        {
            Json = json;
            Regex = regex;
            JsonSchema = jsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonSchema as object ??
            Regex as object ??
            Json as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Json?.ToString() ??
            Regex?.ToString() ??
            JsonSchema?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJson && !IsRegex && !IsJsonSchema || !IsJson && IsRegex && !IsJsonSchema || !IsJson && !IsRegex && IsJsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.GrammarTypeVariant1?, TResult>? json = null,
            global::System.Func<global::HuggingFace.GrammarTypeVariant2?, TResult>? regex = null,
            global::System.Func<global::HuggingFace.GrammarTypeVariant3?, TResult>? jsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJson && json != null)
            {
                return json(Json!);
            }
            else if (IsRegex && regex != null)
            {
                return regex(Regex!);
            }
            else if (IsJsonSchema && jsonSchema != null)
            {
                return jsonSchema(JsonSchema!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.GrammarTypeVariant1?>? json = null,
            global::System.Action<global::HuggingFace.GrammarTypeVariant2?>? regex = null,
            global::System.Action<global::HuggingFace.GrammarTypeVariant3?>? jsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJson)
            {
                json?.Invoke(Json!);
            }
            else if (IsRegex)
            {
                regex?.Invoke(Regex!);
            }
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Json,
                typeof(global::HuggingFace.GrammarTypeVariant1),
                Regex,
                typeof(global::HuggingFace.GrammarTypeVariant2),
                JsonSchema,
                typeof(global::HuggingFace.GrammarTypeVariant3),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(GrammarType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.GrammarTypeVariant1?>.Default.Equals(Json, other.Json) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.GrammarTypeVariant2?>.Default.Equals(Regex, other.Regex) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.GrammarTypeVariant3?>.Default.Equals(JsonSchema, other.JsonSchema) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GrammarType obj1, GrammarType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GrammarType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GrammarType obj1, GrammarType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GrammarType o && Equals(o);
        }
    }
}
