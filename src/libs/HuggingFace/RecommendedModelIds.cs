namespace HuggingFace;

// ReSharper disable InconsistentNaming
#pragma warning disable CA1707

/// <summary>
/// Recommended models for HuggingFace.
/// </summary>
public static class RecommendedModelIds
{
    /// <summary>
    /// https://huggingface.co/gpt2 <br/>
    /// Pretrained model on English language using a causal language modeling (CLM) objective.
    /// It was introduced in this paper and first released at this page. <br/>
    /// </summary>
    public const string Gpt2 = "gpt2";

    /// <summary>
    /// https://huggingface.co/meta-llama/ <br/>
    /// Llama 2 is a collection of pretrained and fine-tuned generative text models ranging in scale from 7 billion to 70 billion parameters.
    /// This is the repository for the 70B fine-tuned model, optimized for dialogue use cases and converted for the Hugging Face Transformers format.
    /// Links to other models can be found in the index at the bottom. <br/>
    /// </summary>
    public static class Llama2
    {
        /// <inheritdoc cref="Llama2"/>
        public static class Base
        {
            /// <inheritdoc cref="Llama2"/>
            public const string _7B = "meta-llama/Llama-2-7b-hf";
        
            /// <inheritdoc cref="Llama2"/>
            public const string _13B = "meta-llama/Llama-2-13b-hf";
        
            /// <inheritdoc cref="Llama2"/>
            public const string _70B = "meta-llama/Llama-2-70b-hf";
        }

        /// <inheritdoc cref="Llama2"/>
        public static class Chat
        {
            /// <inheritdoc cref="Llama2"/>
            public const string _7B = "meta-llama/Llama-2-7b-chat-hf";
        
            /// <inheritdoc cref="Llama2"/>
            public const string _13B = "meta-llama/Llama-2-13b-chat-hf";
        
            /// <inheritdoc cref="Llama2"/>
            public const string _70B = "meta-llama/Llama-2-70b-chat-hf";
        }
    }
}