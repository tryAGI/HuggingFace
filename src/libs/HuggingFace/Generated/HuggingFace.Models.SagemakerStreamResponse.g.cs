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
        public global::HuggingFace.StreamResponse? StreamResponse { get; init; }
#else
        public global::HuggingFace.StreamResponse? StreamResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamResponse))]
#endif
        public bool IsStreamResponse => StreamResponse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ChatCompletionChunk? ChatCompletionChunk { get; init; }
#else
        public global::HuggingFace.ChatCompletionChunk? ChatCompletionChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletionChunk))]
#endif
        public bool IsChatCompletionChunk => ChatCompletionChunk != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.Chunk? Chunk { get; init; }
#else
        public global::HuggingFace.Chunk? Chunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chunk))]
#endif
        public bool IsChunk => Chunk != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SagemakerStreamResponse(global::HuggingFace.StreamResponse value) => new SagemakerStreamResponse((global::HuggingFace.StreamResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.StreamResponse?(SagemakerStreamResponse @this) => @this.StreamResponse;

        /// <summary>
        /// 
        /// </summary>
        public SagemakerStreamResponse(global::HuggingFace.StreamResponse? value)
        {
            StreamResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SagemakerStreamResponse(global::HuggingFace.ChatCompletionChunk value) => new SagemakerStreamResponse((global::HuggingFace.ChatCompletionChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ChatCompletionChunk?(SagemakerStreamResponse @this) => @this.ChatCompletionChunk;

        /// <summary>
        /// 
        /// </summary>
        public SagemakerStreamResponse(global::HuggingFace.ChatCompletionChunk? value)
        {
            ChatCompletionChunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SagemakerStreamResponse(global::HuggingFace.Chunk value) => new SagemakerStreamResponse((global::HuggingFace.Chunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.Chunk?(SagemakerStreamResponse @this) => @this.Chunk;

        /// <summary>
        /// 
        /// </summary>
        public SagemakerStreamResponse(global::HuggingFace.Chunk? value)
        {
            Chunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SagemakerStreamResponse(
            global::HuggingFace.StreamResponse? streamResponse,
            global::HuggingFace.ChatCompletionChunk? chatCompletionChunk,
            global::HuggingFace.Chunk? chunk
            )
        {
            StreamResponse = streamResponse;
            ChatCompletionChunk = chatCompletionChunk;
            Chunk = chunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Chunk as object ??
            ChatCompletionChunk as object ??
            StreamResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamResponse?.ToString() ??
            ChatCompletionChunk?.ToString() ??
            Chunk?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamResponse && !IsChatCompletionChunk && !IsChunk || !IsStreamResponse && IsChatCompletionChunk && !IsChunk || !IsStreamResponse && !IsChatCompletionChunk && IsChunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.StreamResponse?, TResult>? streamResponse = null,
            global::System.Func<global::HuggingFace.ChatCompletionChunk?, TResult>? chatCompletionChunk = null,
            global::System.Func<global::HuggingFace.Chunk?, TResult>? chunk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamResponse && streamResponse != null)
            {
                return streamResponse(StreamResponse!);
            }
            else if (IsChatCompletionChunk && chatCompletionChunk != null)
            {
                return chatCompletionChunk(ChatCompletionChunk!);
            }
            else if (IsChunk && chunk != null)
            {
                return chunk(Chunk!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.StreamResponse?>? streamResponse = null,
            global::System.Action<global::HuggingFace.ChatCompletionChunk?>? chatCompletionChunk = null,
            global::System.Action<global::HuggingFace.Chunk?>? chunk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamResponse)
            {
                streamResponse?.Invoke(StreamResponse!);
            }
            else if (IsChatCompletionChunk)
            {
                chatCompletionChunk?.Invoke(ChatCompletionChunk!);
            }
            else if (IsChunk)
            {
                chunk?.Invoke(Chunk!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamResponse,
                typeof(global::HuggingFace.StreamResponse),
                ChatCompletionChunk,
                typeof(global::HuggingFace.ChatCompletionChunk),
                Chunk,
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
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.StreamResponse?>.Default.Equals(StreamResponse, other.StreamResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ChatCompletionChunk?>.Default.Equals(ChatCompletionChunk, other.ChatCompletionChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.Chunk?>.Default.Equals(Chunk, other.Chunk) 
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
