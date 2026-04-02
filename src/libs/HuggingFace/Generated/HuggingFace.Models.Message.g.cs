#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Message : global::System.IEquatable<Message>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.MessageBody? Body { get; init; }
#else
        public global::HuggingFace.MessageBody? Body { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Body))]
#endif
        public bool IsBody => Body != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.MessageVariant2? MessageVariant2 { get; init; }
#else
        public global::HuggingFace.MessageVariant2? MessageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageVariant2))]
#endif
        public bool IsMessageVariant2 => MessageVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::HuggingFace.MessageBody value) => new Message((global::HuggingFace.MessageBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.MessageBody?(Message @this) => @this.Body;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::HuggingFace.MessageBody? value)
        {
            Body = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::HuggingFace.MessageVariant2 value) => new Message((global::HuggingFace.MessageVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.MessageVariant2?(Message @this) => @this.MessageVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::HuggingFace.MessageVariant2? value)
        {
            MessageVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Message(
            global::HuggingFace.MessageBody? body,
            global::HuggingFace.MessageVariant2? messageVariant2
            )
        {
            Body = body;
            MessageVariant2 = messageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageVariant2 as object ??
            Body as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Body?.ToString() ??
            MessageVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBody && IsMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.MessageBody?, TResult>? body = null,
            global::System.Func<global::HuggingFace.MessageVariant2?, TResult>? messageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBody && body != null)
            {
                return body(Body!);
            }
            else if (IsMessageVariant2 && messageVariant2 != null)
            {
                return messageVariant2(MessageVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.MessageBody?>? body = null,
            global::System.Action<global::HuggingFace.MessageVariant2?>? messageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBody)
            {
                body?.Invoke(Body!);
            }
            else if (IsMessageVariant2)
            {
                messageVariant2?.Invoke(MessageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Body,
                typeof(global::HuggingFace.MessageBody),
                MessageVariant2,
                typeof(global::HuggingFace.MessageVariant2),
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
        public bool Equals(Message other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.MessageBody?>.Default.Equals(Body, other.Body) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.MessageVariant2?>.Default.Equals(MessageVariant2, other.MessageVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Message obj1, Message obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Message>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Message obj1, Message obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Message o && Equals(o);
        }
    }
}
