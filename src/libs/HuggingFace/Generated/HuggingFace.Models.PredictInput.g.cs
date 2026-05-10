#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Model input. Can be either a single string, a pair of strings or a batch of mixed single and pairs of strings.<br/>
    /// Example: What is Deep Learning?
    /// </summary>
    public readonly partial struct PredictInput : global::System.IEquatable<PredictInput>
    {
        /// <summary>
        /// A single string
        /// </summary>
#if NET6_0_OR_GREATER
        public string? PredictInputVariant1 { get; init; }
#else
        public string? PredictInputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PredictInputVariant1))]
#endif
        public bool IsPredictInputVariant1 => PredictInputVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPredictInputVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = PredictInputVariant1;
            return IsPredictInputVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickPredictInputVariant1() => IsPredictInputVariant1
            ? PredictInputVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PredictInputVariant1' but the value was {ToString()}.");

        /// <summary>
        /// A pair of strings
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? PredictInputVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? PredictInputVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PredictInputVariant2))]
#endif
        public bool IsPredictInputVariant2 => PredictInputVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPredictInputVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = PredictInputVariant2;
            return IsPredictInputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickPredictInputVariant2() => IsPredictInputVariant2
            ? PredictInputVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PredictInputVariant2' but the value was {ToString()}.");

        /// <summary>
        /// A batch
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? PredictInputVariant3 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? PredictInputVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PredictInputVariant3))]
#endif
        public bool IsPredictInputVariant3 => PredictInputVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPredictInputVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? value)
        {
            value = PredictInputVariant3;
            return IsPredictInputVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> PickPredictInputVariant3() => IsPredictInputVariant3
            ? PredictInputVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PredictInputVariant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PredictInput(string value) => new PredictInput((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(PredictInput @this) => @this.PredictInputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public PredictInput(string? value)
        {
            PredictInputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PredictInput FromPredictInputVariant1(string? value) => new PredictInput(value);

        /// <summary>
        /// 
        /// </summary>
        public PredictInput(
            string? predictInputVariant1,
            global::System.Collections.Generic.IList<string>? predictInputVariant2,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? predictInputVariant3
            )
        {
            PredictInputVariant1 = predictInputVariant1;
            PredictInputVariant2 = predictInputVariant2;
            PredictInputVariant3 = predictInputVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PredictInputVariant3 as object ??
            PredictInputVariant2 as object ??
            PredictInputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PredictInputVariant1?.ToString() ??
            PredictInputVariant2?.ToString() ??
            PredictInputVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPredictInputVariant1 && !IsPredictInputVariant2 && !IsPredictInputVariant3 || !IsPredictInputVariant1 && IsPredictInputVariant2 && !IsPredictInputVariant3 || !IsPredictInputVariant1 && !IsPredictInputVariant2 && IsPredictInputVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? predictInputVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? predictInputVariant2 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>, TResult>? predictInputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPredictInputVariant1 && predictInputVariant1 != null)
            {
                return predictInputVariant1(PredictInputVariant1!);
            }
            else if (IsPredictInputVariant2 && predictInputVariant2 != null)
            {
                return predictInputVariant2(PredictInputVariant2!);
            }
            else if (IsPredictInputVariant3 && predictInputVariant3 != null)
            {
                return predictInputVariant3(PredictInputVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? predictInputVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? predictInputVariant2 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>>? predictInputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPredictInputVariant1)
            {
                predictInputVariant1?.Invoke(PredictInputVariant1!);
            }
            else if (IsPredictInputVariant2)
            {
                predictInputVariant2?.Invoke(PredictInputVariant2!);
            }
            else if (IsPredictInputVariant3)
            {
                predictInputVariant3?.Invoke(PredictInputVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? predictInputVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? predictInputVariant2 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>>? predictInputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPredictInputVariant1)
            {
                predictInputVariant1?.Invoke(PredictInputVariant1!);
            }
            else if (IsPredictInputVariant2)
            {
                predictInputVariant2?.Invoke(PredictInputVariant2!);
            }
            else if (IsPredictInputVariant3)
            {
                predictInputVariant3?.Invoke(PredictInputVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PredictInputVariant1,
                typeof(string),
                PredictInputVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
                PredictInputVariant3,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>),
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
        public bool Equals(PredictInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(PredictInputVariant1, other.PredictInputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(PredictInputVariant2, other.PredictInputVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>?>.Default.Equals(PredictInputVariant3, other.PredictInputVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PredictInput obj1, PredictInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PredictInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PredictInput obj1, PredictInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PredictInput o && Equals(o);
        }
    }
}
