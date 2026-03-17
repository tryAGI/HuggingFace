#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SagemakerStreamResponse : global::System.IEquatable<SagemakerStreamResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.StreamResponse? Value1 { get; init; }
#else
        public global::HuggingFace.StreamResponse? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ChatCompletionChunk? Value2 { get; init; }
#else
        public global::HuggingFace.ChatCompletionChunk? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.Chunk? Value3 { get; init; }
#else
        public global::HuggingFace.Chunk? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SagemakerStreamResponse(global::HuggingFace.StreamResponse value) => new SagemakerStreamResponse((global::HuggingFace.StreamResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.StreamResponse?(SagemakerStreamResponse @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public SagemakerStreamResponse(global::HuggingFace.StreamResponse? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SagemakerStreamResponse(global::HuggingFace.ChatCompletionChunk value) => new SagemakerStreamResponse((global::HuggingFace.ChatCompletionChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ChatCompletionChunk?(SagemakerStreamResponse @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public SagemakerStreamResponse(global::HuggingFace.ChatCompletionChunk? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SagemakerStreamResponse(global::HuggingFace.Chunk value) => new SagemakerStreamResponse((global::HuggingFace.Chunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.Chunk?(SagemakerStreamResponse @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public SagemakerStreamResponse(global::HuggingFace.Chunk? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SagemakerStreamResponse(
            global::HuggingFace.StreamResponse? value1,
            global::HuggingFace.ChatCompletionChunk? value2,
            global::HuggingFace.Chunk? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 || !IsValue1 && IsValue2 && !IsValue3 || !IsValue1 && !IsValue2 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.StreamResponse?, TResult>? value1 = null,
            global::System.Func<global::HuggingFace.ChatCompletionChunk?, TResult>? value2 = null,
            global::System.Func<global::HuggingFace.Chunk?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.StreamResponse?>? value1 = null,
            global::System.Action<global::HuggingFace.ChatCompletionChunk?>? value2 = null,
            global::System.Action<global::HuggingFace.Chunk?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::HuggingFace.StreamResponse),
                Value2,
                typeof(global::HuggingFace.ChatCompletionChunk),
                Value3,
                typeof(global::HuggingFace.Chunk),
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
        public bool Equals(SagemakerStreamResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.StreamResponse?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ChatCompletionChunk?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.Chunk?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SagemakerStreamResponse obj1, SagemakerStreamResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SagemakerStreamResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SagemakerStreamResponse obj1, SagemakerStreamResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SagemakerStreamResponse o && Equals(o);
        }
    }
}
