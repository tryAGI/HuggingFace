#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionDelta : global::System.IEquatable<ChatCompletionDelta>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.TextMessage? TextMessage { get; init; }
#else
        public global::HuggingFace.TextMessage? TextMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextMessage))]
#endif
        public bool IsTextMessage => TextMessage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ToolCallDelta? ToolCall { get; init; }
#else
        public global::HuggingFace.ToolCallDelta? ToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCall))]
#endif
        public bool IsToolCall => ToolCall != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionDelta(global::HuggingFace.TextMessage value) => new ChatCompletionDelta((global::HuggingFace.TextMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.TextMessage?(ChatCompletionDelta @this) => @this.TextMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionDelta(global::HuggingFace.TextMessage? value)
        {
            TextMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionDelta(global::HuggingFace.ToolCallDelta value) => new ChatCompletionDelta((global::HuggingFace.ToolCallDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ToolCallDelta?(ChatCompletionDelta @this) => @this.ToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionDelta(global::HuggingFace.ToolCallDelta? value)
        {
            ToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionDelta(
            global::HuggingFace.TextMessage? textMessage,
            global::HuggingFace.ToolCallDelta? toolCall
            )
        {
            TextMessage = textMessage;
            ToolCall = toolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolCall as object ??
            TextMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextMessage?.ToString() ??
            ToolCall?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextMessage && !IsToolCall || !IsTextMessage && IsToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.TextMessage?, TResult>? textMessage = null,
            global::System.Func<global::HuggingFace.ToolCallDelta?, TResult>? toolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextMessage && textMessage != null)
            {
                return textMessage(TextMessage!);
            }
            else if (IsToolCall && toolCall != null)
            {
                return toolCall(ToolCall!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.TextMessage?>? textMessage = null,
            global::System.Action<global::HuggingFace.ToolCallDelta?>? toolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextMessage)
            {
                textMessage?.Invoke(TextMessage!);
            }
            else if (IsToolCall)
            {
                toolCall?.Invoke(ToolCall!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextMessage,
                typeof(global::HuggingFace.TextMessage),
                ToolCall,
                typeof(global::HuggingFace.ToolCallDelta),
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
        public bool Equals(ChatCompletionDelta other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.TextMessage?>.Default.Equals(TextMessage, other.TextMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ToolCallDelta?>.Default.Equals(ToolCall, other.ToolCall) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionDelta obj1, ChatCompletionDelta obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionDelta>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionDelta obj1, ChatCompletionDelta obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionDelta o && Equals(o);
        }
    }
}
