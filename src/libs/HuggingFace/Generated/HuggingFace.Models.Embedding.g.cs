#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Embedding : global::System.IEquatable<Embedding>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<float>? EmbeddingVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<float>? EmbeddingVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingVariant1))]
#endif
        public bool IsEmbeddingVariant1 => EmbeddingVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? EmbeddingVariant2 { get; init; }
#else
        public string? EmbeddingVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingVariant2))]
#endif
        public bool IsEmbeddingVariant2 => EmbeddingVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Embedding(string value) => new Embedding((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Embedding @this) => @this.EmbeddingVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Embedding(string? value)
        {
            EmbeddingVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Embedding(
            global::System.Collections.Generic.IList<float>? embeddingVariant1,
            string? embeddingVariant2
            )
        {
            EmbeddingVariant1 = embeddingVariant1;
            EmbeddingVariant2 = embeddingVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingVariant2 as object ??
            EmbeddingVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EmbeddingVariant1?.ToString() ??
            EmbeddingVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingVariant1 && !IsEmbeddingVariant2 || !IsEmbeddingVariant1 && IsEmbeddingVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<float>?, TResult>? embeddingVariant1 = null,
            global::System.Func<string?, TResult>? embeddingVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingVariant1 && embeddingVariant1 != null)
            {
                return embeddingVariant1(EmbeddingVariant1!);
            }
            else if (IsEmbeddingVariant2 && embeddingVariant2 != null)
            {
                return embeddingVariant2(EmbeddingVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<float>?>? embeddingVariant1 = null,
            global::System.Action<string?>? embeddingVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingVariant1)
            {
                embeddingVariant1?.Invoke(EmbeddingVariant1!);
            }
            else if (IsEmbeddingVariant2)
            {
                embeddingVariant2?.Invoke(EmbeddingVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingVariant1,
                typeof(global::System.Collections.Generic.IList<float>),
                EmbeddingVariant2,
                typeof(string),
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
        public bool Equals(Embedding other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<float>?>.Default.Equals(EmbeddingVariant1, other.EmbeddingVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(EmbeddingVariant2, other.EmbeddingVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Embedding obj1, Embedding obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Embedding>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Embedding obj1, Embedding obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Embedding o && Equals(o);
        }
    }
}
