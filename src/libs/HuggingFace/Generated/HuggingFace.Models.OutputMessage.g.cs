#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputMessage : global::System.IEquatable<OutputMessage>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.TextMessage? Text { get; init; }
#else
        public global::HuggingFace.TextMessage? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ToolCallMessage? ToolCall { get; init; }
#else
        public global::HuggingFace.ToolCallMessage? ToolCall { get; }
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
        public static implicit operator OutputMessage(global::HuggingFace.TextMessage value) => new OutputMessage((global::HuggingFace.TextMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.TextMessage?(OutputMessage @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessage(global::HuggingFace.TextMessage? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessage(global::HuggingFace.ToolCallMessage value) => new OutputMessage((global::HuggingFace.ToolCallMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ToolCallMessage?(OutputMessage @this) => @this.ToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessage(global::HuggingFace.ToolCallMessage? value)
        {
            ToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputMessage(
            global::HuggingFace.TextMessage? text,
            global::HuggingFace.ToolCallMessage? toolCall
            )
        {
            Text = text;
            ToolCall = toolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolCall as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ToolCall?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsToolCall || !IsText && IsToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.TextMessage?, TResult>? text = null,
            global::System.Func<global::HuggingFace.ToolCallMessage?, TResult>? toolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
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
            global::System.Action<global::HuggingFace.TextMessage?>? text = null,
            global::System.Action<global::HuggingFace.ToolCallMessage?>? toolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
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
                Text,
                typeof(global::HuggingFace.TextMessage),
                ToolCall,
                typeof(global::HuggingFace.ToolCallMessage),
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
        public bool Equals(OutputMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.TextMessage?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ToolCallMessage?>.Default.Equals(ToolCall, other.ToolCall) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputMessage obj1, OutputMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputMessage obj1, OutputMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputMessage o && Equals(o);
        }
    }
}
