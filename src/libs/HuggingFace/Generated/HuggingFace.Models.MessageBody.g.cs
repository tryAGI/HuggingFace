#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessageBody : global::System.IEquatable<MessageBody>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.MessageBodyVariant1? MessageBodyVariant1 { get; init; }
#else
        public global::HuggingFace.MessageBodyVariant1? MessageBodyVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageBodyVariant1))]
#endif
        public bool IsMessageBodyVariant1 => MessageBodyVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.MessageBodyVariant2? MessageBodyVariant2 { get; init; }
#else
        public global::HuggingFace.MessageBodyVariant2? MessageBodyVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageBodyVariant2))]
#endif
        public bool IsMessageBodyVariant2 => MessageBodyVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageBody(global::HuggingFace.MessageBodyVariant1 value) => new MessageBody((global::HuggingFace.MessageBodyVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.MessageBodyVariant1?(MessageBody @this) => @this.MessageBodyVariant1;

        /// <summary>
        /// 
        /// </summary>
        public MessageBody(global::HuggingFace.MessageBodyVariant1? value)
        {
            MessageBodyVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageBody(global::HuggingFace.MessageBodyVariant2 value) => new MessageBody((global::HuggingFace.MessageBodyVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.MessageBodyVariant2?(MessageBody @this) => @this.MessageBodyVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MessageBody(global::HuggingFace.MessageBodyVariant2? value)
        {
            MessageBodyVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageBody(
            global::HuggingFace.MessageBodyVariant1? messageBodyVariant1,
            global::HuggingFace.MessageBodyVariant2? messageBodyVariant2
            )
        {
            MessageBodyVariant1 = messageBodyVariant1;
            MessageBodyVariant2 = messageBodyVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageBodyVariant2 as object ??
            MessageBodyVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessageBodyVariant1?.ToString() ??
            MessageBodyVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageBodyVariant1 && !IsMessageBodyVariant2 || !IsMessageBodyVariant1 && IsMessageBodyVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.MessageBodyVariant1?, TResult>? messageBodyVariant1 = null,
            global::System.Func<global::HuggingFace.MessageBodyVariant2?, TResult>? messageBodyVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageBodyVariant1 && messageBodyVariant1 != null)
            {
                return messageBodyVariant1(MessageBodyVariant1!);
            }
            else if (IsMessageBodyVariant2 && messageBodyVariant2 != null)
            {
                return messageBodyVariant2(MessageBodyVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.MessageBodyVariant1?>? messageBodyVariant1 = null,
            global::System.Action<global::HuggingFace.MessageBodyVariant2?>? messageBodyVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageBodyVariant1)
            {
                messageBodyVariant1?.Invoke(MessageBodyVariant1!);
            }
            else if (IsMessageBodyVariant2)
            {
                messageBodyVariant2?.Invoke(MessageBodyVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageBodyVariant1,
                typeof(global::HuggingFace.MessageBodyVariant1),
                MessageBodyVariant2,
                typeof(global::HuggingFace.MessageBodyVariant2),
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
        public bool Equals(MessageBody other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.MessageBodyVariant1?>.Default.Equals(MessageBodyVariant1, other.MessageBodyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.MessageBodyVariant2?>.Default.Equals(MessageBodyVariant2, other.MessageBodyVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessageBody obj1, MessageBody obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessageBody>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessageBody obj1, MessageBody obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessageBody o && Equals(o);
        }
    }
}
