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
        public global::HuggingFace.ToolChoiceVariant1? ToolChoiceVariant1 { get; init; }
#else
        public global::HuggingFace.ToolChoiceVariant1? ToolChoiceVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolChoiceVariant1))]
#endif
        public bool IsToolChoiceVariant1 => ToolChoiceVariant1 != null;

        /// <summary>
        /// Means the model will not call any tool and instead generates a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ToolChoiceVariant2? ToolChoiceVariant2 { get; init; }
#else
        public global::HuggingFace.ToolChoiceVariant2? ToolChoiceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolChoiceVariant2))]
#endif
        public bool IsToolChoiceVariant2 => ToolChoiceVariant2 != null;

        /// <summary>
        /// Means the model must call one or more tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ToolChoiceVariant3? ToolChoiceVariant3 { get; init; }
#else
        public global::HuggingFace.ToolChoiceVariant3? ToolChoiceVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolChoiceVariant3))]
#endif
        public bool IsToolChoiceVariant3 => ToolChoiceVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ToolChoiceVariant4? ToolChoiceVariant4 { get; init; }
#else
        public global::HuggingFace.ToolChoiceVariant4? ToolChoiceVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolChoiceVariant4))]
#endif
        public bool IsToolChoiceVariant4 => ToolChoiceVariant4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::HuggingFace.ToolChoiceVariant1 value) => new ToolChoice((global::HuggingFace.ToolChoiceVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ToolChoiceVariant1?(ToolChoice @this) => @this.ToolChoiceVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::HuggingFace.ToolChoiceVariant1? value)
        {
            ToolChoiceVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::HuggingFace.ToolChoiceVariant2 value) => new ToolChoice((global::HuggingFace.ToolChoiceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ToolChoiceVariant2?(ToolChoice @this) => @this.ToolChoiceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::HuggingFace.ToolChoiceVariant2? value)
        {
            ToolChoiceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::HuggingFace.ToolChoiceVariant3 value) => new ToolChoice((global::HuggingFace.ToolChoiceVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ToolChoiceVariant3?(ToolChoice @this) => @this.ToolChoiceVariant3;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::HuggingFace.ToolChoiceVariant3? value)
        {
            ToolChoiceVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::HuggingFace.ToolChoiceVariant4 value) => new ToolChoice((global::HuggingFace.ToolChoiceVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ToolChoiceVariant4?(ToolChoice @this) => @this.ToolChoiceVariant4;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::HuggingFace.ToolChoiceVariant4? value)
        {
            ToolChoiceVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(
            global::HuggingFace.ToolChoiceVariant1? toolChoiceVariant1,
            global::HuggingFace.ToolChoiceVariant2? toolChoiceVariant2,
            global::HuggingFace.ToolChoiceVariant3? toolChoiceVariant3,
            global::HuggingFace.ToolChoiceVariant4? toolChoiceVariant4
            )
        {
            ToolChoiceVariant1 = toolChoiceVariant1;
            ToolChoiceVariant2 = toolChoiceVariant2;
            ToolChoiceVariant3 = toolChoiceVariant3;
            ToolChoiceVariant4 = toolChoiceVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolChoiceVariant4 as object ??
            ToolChoiceVariant3 as object ??
            ToolChoiceVariant2 as object ??
            ToolChoiceVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ToolChoiceVariant1?.ToValueString() ??
            ToolChoiceVariant2?.ToValueString() ??
            ToolChoiceVariant3?.ToValueString() ??
            ToolChoiceVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsToolChoiceVariant1 && !IsToolChoiceVariant2 && !IsToolChoiceVariant3 && !IsToolChoiceVariant4 || !IsToolChoiceVariant1 && IsToolChoiceVariant2 && !IsToolChoiceVariant3 && !IsToolChoiceVariant4 || !IsToolChoiceVariant1 && !IsToolChoiceVariant2 && IsToolChoiceVariant3 && !IsToolChoiceVariant4 || !IsToolChoiceVariant1 && !IsToolChoiceVariant2 && !IsToolChoiceVariant3 && IsToolChoiceVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.ToolChoiceVariant1?, TResult>? toolChoiceVariant1 = null,
            global::System.Func<global::HuggingFace.ToolChoiceVariant2?, TResult>? toolChoiceVariant2 = null,
            global::System.Func<global::HuggingFace.ToolChoiceVariant3?, TResult>? toolChoiceVariant3 = null,
            global::System.Func<global::HuggingFace.ToolChoiceVariant4?, TResult>? toolChoiceVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolChoiceVariant1 && toolChoiceVariant1 != null)
            {
                return toolChoiceVariant1(ToolChoiceVariant1!);
            }
            else if (IsToolChoiceVariant2 && toolChoiceVariant2 != null)
            {
                return toolChoiceVariant2(ToolChoiceVariant2!);
            }
            else if (IsToolChoiceVariant3 && toolChoiceVariant3 != null)
            {
                return toolChoiceVariant3(ToolChoiceVariant3!);
            }
            else if (IsToolChoiceVariant4 && toolChoiceVariant4 != null)
            {
                return toolChoiceVariant4(ToolChoiceVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.ToolChoiceVariant1?>? toolChoiceVariant1 = null,
            global::System.Action<global::HuggingFace.ToolChoiceVariant2?>? toolChoiceVariant2 = null,
            global::System.Action<global::HuggingFace.ToolChoiceVariant3?>? toolChoiceVariant3 = null,
            global::System.Action<global::HuggingFace.ToolChoiceVariant4?>? toolChoiceVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolChoiceVariant1)
            {
                toolChoiceVariant1?.Invoke(ToolChoiceVariant1!);
            }
            else if (IsToolChoiceVariant2)
            {
                toolChoiceVariant2?.Invoke(ToolChoiceVariant2!);
            }
            else if (IsToolChoiceVariant3)
            {
                toolChoiceVariant3?.Invoke(ToolChoiceVariant3!);
            }
            else if (IsToolChoiceVariant4)
            {
                toolChoiceVariant4?.Invoke(ToolChoiceVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ToolChoiceVariant1,
                typeof(global::HuggingFace.ToolChoiceVariant1),
                ToolChoiceVariant2,
                typeof(global::HuggingFace.ToolChoiceVariant2),
                ToolChoiceVariant3,
                typeof(global::HuggingFace.ToolChoiceVariant3),
                ToolChoiceVariant4,
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
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ToolChoiceVariant1?>.Default.Equals(ToolChoiceVariant1, other.ToolChoiceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ToolChoiceVariant2?>.Default.Equals(ToolChoiceVariant2, other.ToolChoiceVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ToolChoiceVariant3?>.Default.Equals(ToolChoiceVariant3, other.ToolChoiceVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ToolChoiceVariant4?>.Default.Equals(ToolChoiceVariant4, other.ToolChoiceVariant4) 
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
