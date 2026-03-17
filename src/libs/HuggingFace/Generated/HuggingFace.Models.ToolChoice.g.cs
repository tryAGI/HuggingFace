#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// &lt;https://platform.openai.com/docs/guides/function-calling/configuring-function-calling-behavior-using-the-tool_choice-parameter&gt;
    /// </summary>
    public readonly partial struct ToolChoice : global::System.IEquatable<ToolChoice>
    {
        /// <summary>
        /// Means the model can pick between generating a message or calling one or more tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ToolChoiceVariant1? Value1 { get; init; }
#else
        public global::HuggingFace.ToolChoiceVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Means the model will not call any tool and instead generates a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ToolChoiceVariant2? Value2 { get; init; }
#else
        public global::HuggingFace.ToolChoiceVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// Means the model must call one or more tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ToolChoiceVariant3? Value3 { get; init; }
#else
        public global::HuggingFace.ToolChoiceVariant3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ToolChoiceVariant4? Value4 { get; init; }
#else
        public global::HuggingFace.ToolChoiceVariant4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::HuggingFace.ToolChoiceVariant1 value) => new ToolChoice((global::HuggingFace.ToolChoiceVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ToolChoiceVariant1?(ToolChoice @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::HuggingFace.ToolChoiceVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::HuggingFace.ToolChoiceVariant2 value) => new ToolChoice((global::HuggingFace.ToolChoiceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ToolChoiceVariant2?(ToolChoice @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::HuggingFace.ToolChoiceVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::HuggingFace.ToolChoiceVariant3 value) => new ToolChoice((global::HuggingFace.ToolChoiceVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ToolChoiceVariant3?(ToolChoice @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::HuggingFace.ToolChoiceVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::HuggingFace.ToolChoiceVariant4 value) => new ToolChoice((global::HuggingFace.ToolChoiceVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ToolChoiceVariant4?(ToolChoice @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::HuggingFace.ToolChoiceVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(
            global::HuggingFace.ToolChoiceVariant1? value1,
            global::HuggingFace.ToolChoiceVariant2? value2,
            global::HuggingFace.ToolChoiceVariant3? value3,
            global::HuggingFace.ToolChoiceVariant4? value4
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToValueString() ??
            Value2?.ToValueString() ??
            Value3?.ToValueString() ??
            Value4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.ToolChoiceVariant1?, TResult>? value1 = null,
            global::System.Func<global::HuggingFace.ToolChoiceVariant2?, TResult>? value2 = null,
            global::System.Func<global::HuggingFace.ToolChoiceVariant3?, TResult>? value3 = null,
            global::System.Func<global::HuggingFace.ToolChoiceVariant4?, TResult>? value4 = null,
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
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.ToolChoiceVariant1?>? value1 = null,
            global::System.Action<global::HuggingFace.ToolChoiceVariant2?>? value2 = null,
            global::System.Action<global::HuggingFace.ToolChoiceVariant3?>? value3 = null,
            global::System.Action<global::HuggingFace.ToolChoiceVariant4?>? value4 = null,
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
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
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
                typeof(global::HuggingFace.ToolChoiceVariant1),
                Value2,
                typeof(global::HuggingFace.ToolChoiceVariant2),
                Value3,
                typeof(global::HuggingFace.ToolChoiceVariant3),
                Value4,
                typeof(global::HuggingFace.ToolChoiceVariant4),
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
        public bool Equals(ToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ToolChoiceVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ToolChoiceVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ToolChoiceVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ToolChoiceVariant4?>.Default.Equals(Value4, other.Value4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolChoice obj1, ToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolChoice obj1, ToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolChoice o && Equals(o);
        }
    }
}
