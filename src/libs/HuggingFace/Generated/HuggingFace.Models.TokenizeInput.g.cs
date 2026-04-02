#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TokenizeInput : global::System.IEquatable<TokenizeInput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? TokenizeInputVariant1 { get; init; }
#else
        public string? TokenizeInputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TokenizeInputVariant1))]
#endif
        public bool IsTokenizeInputVariant1 => TokenizeInputVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? TokenizeInputVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? TokenizeInputVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TokenizeInputVariant2))]
#endif
        public bool IsTokenizeInputVariant2 => TokenizeInputVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TokenizeInput(string value) => new TokenizeInput((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(TokenizeInput @this) => @this.TokenizeInputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public TokenizeInput(string? value)
        {
            TokenizeInputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TokenizeInput(
            string? tokenizeInputVariant1,
            global::System.Collections.Generic.IList<string>? tokenizeInputVariant2
            )
        {
            TokenizeInputVariant1 = tokenizeInputVariant1;
            TokenizeInputVariant2 = tokenizeInputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TokenizeInputVariant2 as object ??
            TokenizeInputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TokenizeInputVariant1?.ToString() ??
            TokenizeInputVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTokenizeInputVariant1 && !IsTokenizeInputVariant2 || !IsTokenizeInputVariant1 && IsTokenizeInputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? tokenizeInputVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? tokenizeInputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTokenizeInputVariant1 && tokenizeInputVariant1 != null)
            {
                return tokenizeInputVariant1(TokenizeInputVariant1!);
            }
            else if (IsTokenizeInputVariant2 && tokenizeInputVariant2 != null)
            {
                return tokenizeInputVariant2(TokenizeInputVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? tokenizeInputVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? tokenizeInputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTokenizeInputVariant1)
            {
                tokenizeInputVariant1?.Invoke(TokenizeInputVariant1!);
            }
            else if (IsTokenizeInputVariant2)
            {
                tokenizeInputVariant2?.Invoke(TokenizeInputVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TokenizeInputVariant1,
                typeof(string),
                TokenizeInputVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(TokenizeInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TokenizeInputVariant1, other.TokenizeInputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(TokenizeInputVariant2, other.TokenizeInputVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TokenizeInput obj1, TokenizeInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TokenizeInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TokenizeInput obj1, TokenizeInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TokenizeInput o && Equals(o);
        }
    }
}
