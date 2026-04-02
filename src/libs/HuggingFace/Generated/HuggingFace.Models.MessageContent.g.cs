#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessageContent : global::System.IEquatable<MessageContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? MessageContentVariant1 { get; init; }
#else
        public string? MessageContentVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageContentVariant1))]
#endif
        public bool IsMessageContentVariant1 => MessageContentVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::HuggingFace.MessageChunk>? MessageContentVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::HuggingFace.MessageChunk>? MessageContentVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageContentVariant2))]
#endif
        public bool IsMessageContentVariant2 => MessageContentVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageContent(string value) => new MessageContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(MessageContent @this) => @this.MessageContentVariant1;

        /// <summary>
        /// 
        /// </summary>
        public MessageContent(string? value)
        {
            MessageContentVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageContent(
            string? messageContentVariant1,
            global::System.Collections.Generic.IList<global::HuggingFace.MessageChunk>? messageContentVariant2
            )
        {
            MessageContentVariant1 = messageContentVariant1;
            MessageContentVariant2 = messageContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageContentVariant2 as object ??
            MessageContentVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessageContentVariant1?.ToString() ??
            MessageContentVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageContentVariant1 && !IsMessageContentVariant2 || !IsMessageContentVariant1 && IsMessageContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? messageContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::HuggingFace.MessageChunk>?, TResult>? messageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageContentVariant1 && messageContentVariant1 != null)
            {
                return messageContentVariant1(MessageContentVariant1!);
            }
            else if (IsMessageContentVariant2 && messageContentVariant2 != null)
            {
                return messageContentVariant2(MessageContentVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? messageContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::HuggingFace.MessageChunk>?>? messageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageContentVariant1)
            {
                messageContentVariant1?.Invoke(MessageContentVariant1!);
            }
            else if (IsMessageContentVariant2)
            {
                messageContentVariant2?.Invoke(MessageContentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageContentVariant1,
                typeof(string),
                MessageContentVariant2,
                typeof(global::System.Collections.Generic.IList<global::HuggingFace.MessageChunk>),
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
        public bool Equals(MessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(MessageContentVariant1, other.MessageContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::HuggingFace.MessageChunk>?>.Default.Equals(MessageContentVariant2, other.MessageContentVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessageContent obj1, MessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessageContent obj1, MessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessageContent o && Equals(o);
        }
    }
}
