#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SagemakerRequest : global::System.IEquatable<SagemakerRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.CompatGenerateRequest? CompatGenerate { get; init; }
#else
        public global::HuggingFace.CompatGenerateRequest? CompatGenerate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompatGenerate))]
#endif
        public bool IsCompatGenerate => CompatGenerate != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.ChatRequest? Chat { get; init; }
#else
        public global::HuggingFace.ChatRequest? Chat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chat))]
#endif
        public bool IsChat => Chat != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HuggingFace.CompletionRequest? Completion { get; init; }
#else
        public global::HuggingFace.CompletionRequest? Completion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completion))]
#endif
        public bool IsCompletion => Completion != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SagemakerRequest(global::HuggingFace.CompatGenerateRequest value) => new SagemakerRequest((global::HuggingFace.CompatGenerateRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.CompatGenerateRequest?(SagemakerRequest @this) => @this.CompatGenerate;

        /// <summary>
        /// 
        /// </summary>
        public SagemakerRequest(global::HuggingFace.CompatGenerateRequest? value)
        {
            CompatGenerate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SagemakerRequest(global::HuggingFace.ChatRequest value) => new SagemakerRequest((global::HuggingFace.ChatRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.ChatRequest?(SagemakerRequest @this) => @this.Chat;

        /// <summary>
        /// 
        /// </summary>
        public SagemakerRequest(global::HuggingFace.ChatRequest? value)
        {
            Chat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SagemakerRequest(global::HuggingFace.CompletionRequest value) => new SagemakerRequest((global::HuggingFace.CompletionRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HuggingFace.CompletionRequest?(SagemakerRequest @this) => @this.Completion;

        /// <summary>
        /// 
        /// </summary>
        public SagemakerRequest(global::HuggingFace.CompletionRequest? value)
        {
            Completion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SagemakerRequest(
            global::HuggingFace.CompatGenerateRequest? compatGenerate,
            global::HuggingFace.ChatRequest? chat,
            global::HuggingFace.CompletionRequest? completion
            )
        {
            CompatGenerate = compatGenerate;
            Chat = chat;
            Completion = completion;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Completion as object ??
            Chat as object ??
            CompatGenerate as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CompatGenerate?.ToString() ??
            Chat?.ToString() ??
            Completion?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompatGenerate && !IsChat && !IsCompletion || !IsCompatGenerate && IsChat && !IsCompletion || !IsCompatGenerate && !IsChat && IsCompletion;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HuggingFace.CompatGenerateRequest?, TResult>? compatGenerate = null,
            global::System.Func<global::HuggingFace.ChatRequest?, TResult>? chat = null,
            global::System.Func<global::HuggingFace.CompletionRequest?, TResult>? completion = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompatGenerate && compatGenerate != null)
            {
                return compatGenerate(CompatGenerate!);
            }
            else if (IsChat && chat != null)
            {
                return chat(Chat!);
            }
            else if (IsCompletion && completion != null)
            {
                return completion(Completion!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HuggingFace.CompatGenerateRequest?>? compatGenerate = null,
            global::System.Action<global::HuggingFace.ChatRequest?>? chat = null,
            global::System.Action<global::HuggingFace.CompletionRequest?>? completion = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompatGenerate)
            {
                compatGenerate?.Invoke(CompatGenerate!);
            }
            else if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
            else if (IsCompletion)
            {
                completion?.Invoke(Completion!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CompatGenerate,
                typeof(global::HuggingFace.CompatGenerateRequest),
                Chat,
                typeof(global::HuggingFace.ChatRequest),
                Completion,
                typeof(global::HuggingFace.CompletionRequest),
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
        public bool Equals(SagemakerRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.CompatGenerateRequest?>.Default.Equals(CompatGenerate, other.CompatGenerate) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.ChatRequest?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::HuggingFace.CompletionRequest?>.Default.Equals(Completion, other.Completion) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SagemakerRequest obj1, SagemakerRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SagemakerRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SagemakerRequest obj1, SagemakerRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SagemakerRequest o && Equals(o);
        }
    }
}
