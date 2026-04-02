#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Completion : global::System.IEquatable<Completion>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>? CompletionVariant1 { get; init; }
#else
        public global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>? CompletionVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionVariant1))]
#endif
        public bool IsCompletionVariant1 => CompletionVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>? CompletionVariant2 { get; init; }
#else
        public global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>? CompletionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionVariant2))]
#endif
        public bool IsCompletionVariant2 => CompletionVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Completion(global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12> value) => new Completion((global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>?(Completion @this) => @this.CompletionVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Completion(global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>? value)
        {
            CompletionVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Completion(global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22> value) => new Completion((global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>?(Completion @this) => @this.CompletionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Completion(global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>? value)
        {
            CompletionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Completion(
            global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>? completionVariant1,
            global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>? completionVariant2
            )
        {
            CompletionVariant1 = completionVariant1;
            CompletionVariant2 = completionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompletionVariant2 as object ??
            CompletionVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CompletionVariant1?.ToString() ??
            CompletionVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompletionVariant1 && !IsCompletionVariant2 || !IsCompletionVariant1 && IsCompletionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>?, TResult>? completionVariant1 = null,
            global::System.Func<global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>?, TResult>? completionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletionVariant1 && completionVariant1 != null)
            {
                return completionVariant1(CompletionVariant1!);
            }
            else if (IsCompletionVariant2 && completionVariant2 != null)
            {
                return completionVariant2(CompletionVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>?>? completionVariant1 = null,
            global::System.Action<global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>?>? completionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletionVariant1)
            {
                completionVariant1?.Invoke(CompletionVariant1!);
            }
            else if (IsCompletionVariant2)
            {
                completionVariant2?.Invoke(CompletionVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CompletionVariant1,
                typeof(global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>),
                CompletionVariant2,
                typeof(global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>),
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
        public bool Equals(Completion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>?>.Default.Equals(CompletionVariant1, other.CompletionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>?>.Default.Equals(CompletionVariant2, other.CompletionVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Completion obj1, Completion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Completion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Completion obj1, Completion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Completion o && Equals(o);
        }
    }
}
