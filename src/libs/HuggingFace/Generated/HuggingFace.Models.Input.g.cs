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
        public global::HuggingFace.InputType? Type { get; init; }
#else
        public global::HuggingFace.InputType? Type { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Type))]
#endif
        public bool IsType => Type != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::HuggingFace.InputType>? InputVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::HuggingFace.InputType>? InputVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputVariant2))]
#endif
        public bool IsInputVariant2 => InputVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::HuggingFace.InputType value) => new Input((global::HuggingFace.InputType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.InputType?(Input @this) => @this.Type;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::HuggingFace.InputType? value)
        {
            Type = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Input(
            global::HuggingFace.InputType? type,
            global::System.Collections.Generic.IList<global::HuggingFace.InputType>? inputVariant2
            )
        {
            Type = type;
            InputVariant2 = inputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputVariant2 as object ??
            Type as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Type?.ToString() ??
            InputVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsType && !IsInputVariant2 || !IsType && IsInputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.InputType?, TResult>? type = null,
            global::System.Func<global::System.Collections.Generic.IList<global::HuggingFace.InputType>?, TResult>? inputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsType && type != null)
            {
                return type(Type!);
            }
            else if (IsInputVariant2 && inputVariant2 != null)
            {
                return inputVariant2(InputVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.InputType?>? type = null,
            global::System.Action<global::System.Collections.Generic.IList<global::HuggingFace.InputType>?>? inputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsType)
            {
                type?.Invoke(Type!);
            }
            else if (IsInputVariant2)
            {
                inputVariant2?.Invoke(InputVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Type,
                typeof(global::HuggingFace.InputType),
                InputVariant2,
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
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.InputType?>.Default.Equals(Type, other.Type) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::HuggingFace.InputType>?>.Default.Equals(InputVariant2, other.InputVariant2) 
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
