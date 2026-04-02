#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PredictResponse : global::System.IEquatable<PredictResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::HuggingFace.Prediction>? PredictResponseVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::HuggingFace.Prediction>? PredictResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PredictResponseVariant1))]
#endif
        public bool IsPredictResponseVariant1 => PredictResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.Prediction>>? PredictResponseVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.Prediction>>? PredictResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PredictResponseVariant2))]
#endif
        public bool IsPredictResponseVariant2 => PredictResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public PredictResponse(
            global::System.Collections.Generic.IList<global::HuggingFace.Prediction>? predictResponseVariant1,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.Prediction>>? predictResponseVariant2
            )
        {
            PredictResponseVariant1 = predictResponseVariant1;
            PredictResponseVariant2 = predictResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PredictResponseVariant2 as object ??
            PredictResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PredictResponseVariant1?.ToString() ??
            PredictResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPredictResponseVariant1 && !IsPredictResponseVariant2 || !IsPredictResponseVariant1 && IsPredictResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::HuggingFace.Prediction>?, TResult>? predictResponseVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.Prediction>>?, TResult>? predictResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPredictResponseVariant1 && predictResponseVariant1 != null)
            {
                return predictResponseVariant1(PredictResponseVariant1!);
            }
            else if (IsPredictResponseVariant2 && predictResponseVariant2 != null)
            {
                return predictResponseVariant2(PredictResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::HuggingFace.Prediction>?>? predictResponseVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.Prediction>>?>? predictResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPredictResponseVariant1)
            {
                predictResponseVariant1?.Invoke(PredictResponseVariant1!);
            }
            else if (IsPredictResponseVariant2)
            {
                predictResponseVariant2?.Invoke(PredictResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PredictResponseVariant1,
                typeof(global::System.Collections.Generic.IList<global::HuggingFace.Prediction>),
                PredictResponseVariant2,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.Prediction>>),
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
        public bool Equals(PredictResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::HuggingFace.Prediction>?>.Default.Equals(PredictResponseVariant1, other.PredictResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.Prediction>>?>.Default.Equals(PredictResponseVariant2, other.PredictResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PredictResponse obj1, PredictResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PredictResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PredictResponse obj1, PredictResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PredictResponse o && Equals(o);
        }
    }
}
