#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ModelType : global::System.IEquatable<ModelType>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ModelTypeVariant1? ModelTypeVariant1 { get; init; }
#else
        public global::HuggingFace.ModelTypeVariant1? ModelTypeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelTypeVariant1))]
#endif
        public bool IsModelTypeVariant1 => ModelTypeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ModelTypeVariant2? ModelTypeVariant2 { get; init; }
#else
        public global::HuggingFace.ModelTypeVariant2? ModelTypeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelTypeVariant2))]
#endif
        public bool IsModelTypeVariant2 => ModelTypeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ModelTypeVariant3? ModelTypeVariant3 { get; init; }
#else
        public global::HuggingFace.ModelTypeVariant3? ModelTypeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelTypeVariant3))]
#endif
        public bool IsModelTypeVariant3 => ModelTypeVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelType(global::HuggingFace.ModelTypeVariant1 value) => new ModelType((global::HuggingFace.ModelTypeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ModelTypeVariant1?(ModelType @this) => @this.ModelTypeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ModelType(global::HuggingFace.ModelTypeVariant1? value)
        {
            ModelTypeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelType(global::HuggingFace.ModelTypeVariant2 value) => new ModelType((global::HuggingFace.ModelTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ModelTypeVariant2?(ModelType @this) => @this.ModelTypeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ModelType(global::HuggingFace.ModelTypeVariant2? value)
        {
            ModelTypeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelType(global::HuggingFace.ModelTypeVariant3 value) => new ModelType((global::HuggingFace.ModelTypeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ModelTypeVariant3?(ModelType @this) => @this.ModelTypeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public ModelType(global::HuggingFace.ModelTypeVariant3? value)
        {
            ModelTypeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelType(
            global::HuggingFace.ModelTypeVariant1? modelTypeVariant1,
            global::HuggingFace.ModelTypeVariant2? modelTypeVariant2,
            global::HuggingFace.ModelTypeVariant3? modelTypeVariant3
            )
        {
            ModelTypeVariant1 = modelTypeVariant1;
            ModelTypeVariant2 = modelTypeVariant2;
            ModelTypeVariant3 = modelTypeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ModelTypeVariant3 as object ??
            ModelTypeVariant2 as object ??
            ModelTypeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelTypeVariant1?.ToString() ??
            ModelTypeVariant2?.ToString() ??
            ModelTypeVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelTypeVariant1 && !IsModelTypeVariant2 && !IsModelTypeVariant3 || !IsModelTypeVariant1 && IsModelTypeVariant2 && !IsModelTypeVariant3 || !IsModelTypeVariant1 && !IsModelTypeVariant2 && IsModelTypeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.ModelTypeVariant1?, TResult>? modelTypeVariant1 = null,
            global::System.Func<global::HuggingFace.ModelTypeVariant2?, TResult>? modelTypeVariant2 = null,
            global::System.Func<global::HuggingFace.ModelTypeVariant3?, TResult>? modelTypeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelTypeVariant1 && modelTypeVariant1 != null)
            {
                return modelTypeVariant1(ModelTypeVariant1!);
            }
            else if (IsModelTypeVariant2 && modelTypeVariant2 != null)
            {
                return modelTypeVariant2(ModelTypeVariant2!);
            }
            else if (IsModelTypeVariant3 && modelTypeVariant3 != null)
            {
                return modelTypeVariant3(ModelTypeVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.ModelTypeVariant1?>? modelTypeVariant1 = null,
            global::System.Action<global::HuggingFace.ModelTypeVariant2?>? modelTypeVariant2 = null,
            global::System.Action<global::HuggingFace.ModelTypeVariant3?>? modelTypeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelTypeVariant1)
            {
                modelTypeVariant1?.Invoke(ModelTypeVariant1!);
            }
            else if (IsModelTypeVariant2)
            {
                modelTypeVariant2?.Invoke(ModelTypeVariant2!);
            }
            else if (IsModelTypeVariant3)
            {
                modelTypeVariant3?.Invoke(ModelTypeVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelTypeVariant1,
                typeof(global::HuggingFace.ModelTypeVariant1),
                ModelTypeVariant2,
                typeof(global::HuggingFace.ModelTypeVariant2),
                ModelTypeVariant3,
                typeof(global::HuggingFace.ModelTypeVariant3),
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
        public bool Equals(ModelType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ModelTypeVariant1?>.Default.Equals(ModelTypeVariant1, other.ModelTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ModelTypeVariant2?>.Default.Equals(ModelTypeVariant2, other.ModelTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ModelTypeVariant3?>.Default.Equals(ModelTypeVariant3, other.ModelTypeVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelType obj1, ModelType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelType obj1, ModelType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelType o && Equals(o);
        }
    }
}
