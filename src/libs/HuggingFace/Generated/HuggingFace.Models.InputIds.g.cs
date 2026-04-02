#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputIds : global::System.IEquatable<InputIds>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<int>? InputIdsVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<int>? InputIdsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputIdsVariant1))]
#endif
        public bool IsInputIdsVariant1 => InputIdsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? InputIdsVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? InputIdsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputIdsVariant2))]
#endif
        public bool IsInputIdsVariant2 => InputIdsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public InputIds(
            global::System.Collections.Generic.IList<int>? inputIdsVariant1,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? inputIdsVariant2
            )
        {
            InputIdsVariant1 = inputIdsVariant1;
            InputIdsVariant2 = inputIdsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputIdsVariant2 as object ??
            InputIdsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputIdsVariant1?.ToString() ??
            InputIdsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputIdsVariant1 && !IsInputIdsVariant2 || !IsInputIdsVariant1 && IsInputIdsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<int>?, TResult>? inputIdsVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>?, TResult>? inputIdsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputIdsVariant1 && inputIdsVariant1 != null)
            {
                return inputIdsVariant1(InputIdsVariant1!);
            }
            else if (IsInputIdsVariant2 && inputIdsVariant2 != null)
            {
                return inputIdsVariant2(InputIdsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<int>?>? inputIdsVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>?>? inputIdsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputIdsVariant1)
            {
                inputIdsVariant1?.Invoke(InputIdsVariant1!);
            }
            else if (IsInputIdsVariant2)
            {
                inputIdsVariant2?.Invoke(InputIdsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputIdsVariant1,
                typeof(global::System.Collections.Generic.IList<int>),
                InputIdsVariant2,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>),
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
        public bool Equals(InputIds other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<int>?>.Default.Equals(InputIdsVariant1, other.InputIdsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>?>.Default.Equals(InputIdsVariant2, other.InputIdsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputIds obj1, InputIds obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputIds>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputIds obj1, InputIds obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputIds o && Equals(o);
        }
    }
}
