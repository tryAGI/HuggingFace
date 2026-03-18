#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Input : global::System.IEquatable<Input>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.InputType? Value1 { get; init; }
#else
        public global::HuggingFace.InputType? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::HuggingFace.InputType>? Value2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::HuggingFace.InputType>? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::HuggingFace.InputType value) => new Input((global::HuggingFace.InputType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.InputType?(Input @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::HuggingFace.InputType? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Input(
            global::HuggingFace.InputType? value1,
            global::System.Collections.Generic.IList<global::HuggingFace.InputType>? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.InputType?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::HuggingFace.InputType>?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.InputType?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::HuggingFace.InputType>?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::HuggingFace.InputType),
                Value2,
                typeof(global::System.Collections.Generic.IList<global::HuggingFace.InputType>),
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
        public bool Equals(Input other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.InputType?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::HuggingFace.InputType>?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Input obj1, Input obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Input>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Input obj1, Input obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Input o && Equals(o);
        }
    }
}
