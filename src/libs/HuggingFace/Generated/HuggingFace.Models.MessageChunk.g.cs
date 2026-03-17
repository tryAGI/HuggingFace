#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessageChunk : global::System.IEquatable<MessageChunk>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.MessageChunkVariant1? Text { get; init; }
#else
        public global::HuggingFace.MessageChunkVariant1? Text { get; }
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
        public global::HuggingFace.MessageChunkVariant2? ImageUrl { get; init; }
#else
        public global::HuggingFace.MessageChunkVariant2? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageChunk(global::HuggingFace.MessageChunkVariant1 value) => new MessageChunk((global::HuggingFace.MessageChunkVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.MessageChunkVariant1?(MessageChunk @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public MessageChunk(global::HuggingFace.MessageChunkVariant1? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageChunk(global::HuggingFace.MessageChunkVariant2 value) => new MessageChunk((global::HuggingFace.MessageChunkVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.MessageChunkVariant2?(MessageChunk @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public MessageChunk(global::HuggingFace.MessageChunkVariant2? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageChunk(
            global::HuggingFace.MessageChunkVariant1? text,
            global::HuggingFace.MessageChunkVariant2? imageUrl
            )
        {
            Text = text;
            ImageUrl = imageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageUrl as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl || !IsText && IsImageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.MessageChunkVariant1?, TResult>? text = null,
            global::System.Func<global::HuggingFace.MessageChunkVariant2?, TResult>? imageUrl = null,
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
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.MessageChunkVariant1?>? text = null,
            global::System.Action<global::HuggingFace.MessageChunkVariant2?>? imageUrl = null,
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
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
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
                typeof(global::HuggingFace.MessageChunkVariant1),
                ImageUrl,
                typeof(global::HuggingFace.MessageChunkVariant2),
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
        public bool Equals(MessageChunk other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.MessageChunkVariant1?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.MessageChunkVariant2?>.Default.Equals(ImageUrl, other.ImageUrl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessageChunk obj1, MessageChunk obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessageChunk>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessageChunk obj1, MessageChunk obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessageChunk o && Equals(o);
        }
    }
}
