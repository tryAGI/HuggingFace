#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SagemakerResponse : global::System.IEquatable<SagemakerResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.GenerateResponse? Generate { get; init; }
#else
        public global::HuggingFace.GenerateResponse? Generate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Generate))]
#endif
        public bool IsGenerate => Generate != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ChatCompletion? ChatCompletion { get; init; }
#else
        public global::HuggingFace.ChatCompletion? ChatCompletion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletion))]
#endif
        public bool IsChatCompletion => ChatCompletion != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.CompletionFinal? CompletionFinal { get; init; }
#else
        public global::HuggingFace.CompletionFinal? CompletionFinal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionFinal))]
#endif
        public bool IsCompletionFinal => CompletionFinal != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SagemakerResponse(global::HuggingFace.GenerateResponse value) => new SagemakerResponse((global::HuggingFace.GenerateResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.GenerateResponse?(SagemakerResponse @this) => @this.Generate;

        /// <summary>
        /// 
        /// </summary>
        public SagemakerResponse(global::HuggingFace.GenerateResponse? value)
        {
            Generate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SagemakerResponse(global::HuggingFace.ChatCompletion value) => new SagemakerResponse((global::HuggingFace.ChatCompletion?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ChatCompletion?(SagemakerResponse @this) => @this.ChatCompletion;

        /// <summary>
        /// 
        /// </summary>
        public SagemakerResponse(global::HuggingFace.ChatCompletion? value)
        {
            ChatCompletion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SagemakerResponse(global::HuggingFace.CompletionFinal value) => new SagemakerResponse((global::HuggingFace.CompletionFinal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.CompletionFinal?(SagemakerResponse @this) => @this.CompletionFinal;

        /// <summary>
        /// 
        /// </summary>
        public SagemakerResponse(global::HuggingFace.CompletionFinal? value)
        {
            CompletionFinal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SagemakerResponse(
            global::HuggingFace.GenerateResponse? generate,
            global::HuggingFace.ChatCompletion? chatCompletion,
            global::HuggingFace.CompletionFinal? completionFinal
            )
        {
            Generate = generate;
            ChatCompletion = chatCompletion;
            CompletionFinal = completionFinal;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompletionFinal as object ??
            ChatCompletion as object ??
            Generate as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Generate?.ToString() ??
            ChatCompletion?.ToString() ??
            CompletionFinal?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGenerate && !IsChatCompletion && !IsCompletionFinal || !IsGenerate && IsChatCompletion && !IsCompletionFinal || !IsGenerate && !IsChatCompletion && IsCompletionFinal;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.GenerateResponse?, TResult>? generate = null,
            global::System.Func<global::HuggingFace.ChatCompletion?, TResult>? chatCompletion = null,
            global::System.Func<global::HuggingFace.CompletionFinal?, TResult>? completionFinal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerate && generate != null)
            {
                return generate(Generate!);
            }
            else if (IsChatCompletion && chatCompletion != null)
            {
                return chatCompletion(ChatCompletion!);
            }
            else if (IsCompletionFinal && completionFinal != null)
            {
                return completionFinal(CompletionFinal!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.GenerateResponse?>? generate = null,
            global::System.Action<global::HuggingFace.ChatCompletion?>? chatCompletion = null,
            global::System.Action<global::HuggingFace.CompletionFinal?>? completionFinal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerate)
            {
                generate?.Invoke(Generate!);
            }
            else if (IsChatCompletion)
            {
                chatCompletion?.Invoke(ChatCompletion!);
            }
            else if (IsCompletionFinal)
            {
                completionFinal?.Invoke(CompletionFinal!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Generate,
                typeof(global::HuggingFace.GenerateResponse),
                ChatCompletion,
                typeof(global::HuggingFace.ChatCompletion),
                CompletionFinal,
                typeof(global::HuggingFace.CompletionFinal),
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
        public bool Equals(SagemakerResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.GenerateResponse?>.Default.Equals(Generate, other.Generate) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ChatCompletion?>.Default.Equals(ChatCompletion, other.ChatCompletion) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.CompletionFinal?>.Default.Equals(CompletionFinal, other.CompletionFinal) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SagemakerResponse obj1, SagemakerResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SagemakerResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SagemakerResponse obj1, SagemakerResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SagemakerResponse o && Equals(o);
        }
    }
}
