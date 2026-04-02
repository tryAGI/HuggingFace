#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputType : global::System.IEquatable<InputType>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? InputTypeVariant1 { get; init; }
#else
        public string? InputTypeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputTypeVariant1))]
#endif
        public bool IsInputTypeVariant1 => InputTypeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<int>? InputTypeVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<int>? InputTypeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputTypeVariant2))]
#endif
        public bool IsInputTypeVariant2 => InputTypeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputType(string value) => new InputType((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(InputType @this) => @this.InputTypeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public InputType(string? value)
        {
            InputTypeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputType(
            string? inputTypeVariant1,
            global::System.Collections.Generic.IList<int>? inputTypeVariant2
            )
        {
            InputTypeVariant1 = inputTypeVariant1;
            InputTypeVariant2 = inputTypeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputTypeVariant2 as object ??
            InputTypeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputTypeVariant1?.ToString() ??
            InputTypeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputTypeVariant1 && !IsInputTypeVariant2 || !IsInputTypeVariant1 && IsInputTypeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? inputTypeVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<int>?, TResult>? inputTypeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputTypeVariant1 && inputTypeVariant1 != null)
            {
                return inputTypeVariant1(InputTypeVariant1!);
            }
            else if (IsInputTypeVariant2 && inputTypeVariant2 != null)
            {
                return inputTypeVariant2(InputTypeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? inputTypeVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<int>?>? inputTypeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputTypeVariant1)
            {
                inputTypeVariant1?.Invoke(InputTypeVariant1!);
            }
            else if (IsInputTypeVariant2)
            {
                inputTypeVariant2?.Invoke(InputTypeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputTypeVariant1,
                typeof(string),
                InputTypeVariant2,
                typeof(global::System.Collections.Generic.IList<int>),
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
        public bool Equals(InputType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(InputTypeVariant1, other.InputTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<int>?>.Default.Equals(InputTypeVariant2, other.InputTypeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputType obj1, InputType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputType obj1, InputType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputType o && Equals(o);
        }
    }
}
