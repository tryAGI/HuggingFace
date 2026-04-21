
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDocsSearchProduct
    {
        /// <summary>
        /// 
        /// </summary>
        Accelerate,
        /// <summary>
        /// 
        /// </summary>
        AgentsCourse,
        /// <summary>
        /// 
        /// </summary>
        Argilla,
        /// <summary>
        /// 
        /// </summary>
        AudioCourse,
        /// <summary>
        /// 
        /// </summary>
        Autotrain,
        /// <summary>
        /// 
        /// </summary>
        Bitsandbytes,
        /// <summary>
        /// 
        /// </summary>
        ChatUi,
        /// <summary>
        /// 
        /// </summary>
        Cli,
        /// <summary>
        /// 
        /// </summary>
        ComputerVisionCourse,
        /// <summary>
        /// 
        /// </summary>
        ContextCourse,
        /// <summary>
        /// 
        /// </summary>
        Cookbook,
        /// <summary>
        /// 
        /// </summary>
        DatasetViewer,
        /// <summary>
        /// 
        /// </summary>
        Datasets,
        /// <summary>
        /// 
        /// </summary>
        DeepRlCourse,
        /// <summary>
        /// 
        /// </summary>
        Diffusers,
        /// <summary>
        /// 
        /// </summary>
        DiffusionCourse,
        /// <summary>
        /// 
        /// </summary>
        Distilabel,
        /// <summary>
        /// 
        /// </summary>
        Evaluate,
        /// <summary>
        /// 
        /// </summary>
        GoogleCloud,
        /// <summary>
        /// 
        /// </summary>
        Gradio,
        /// <summary>
        /// 
        /// </summary>
        Hub,
        /// <summary>
        /// 
        /// </summary>
        HuggingfaceJs,
        /// <summary>
        /// 
        /// </summary>
        HuggingfaceHub,
        /// <summary>
        /// 
        /// </summary>
        InferenceEndpoints,
        /// <summary>
        /// 
        /// </summary>
        InferenceProviders,
        /// <summary>
        /// 
        /// </summary>
        Kernels,
        /// <summary>
        /// 
        /// </summary>
        Leaderboards,
        /// <summary>
        /// 
        /// </summary>
        Lerobot,
        /// <summary>
        /// 
        /// </summary>
        Lighteval,
        /// <summary>
        /// 
        /// </summary>
        LlmCourse,
        /// <summary>
        /// 
        /// </summary>
        McpCourse,
        /// <summary>
        /// 
        /// </summary>
        MicrosoftAzure,
        /// <summary>
        /// 
        /// </summary>
        MlFor3dCourse,
        /// <summary>
        /// 
        /// </summary>
        MlGamesCourse,
        /// <summary>
        /// 
        /// </summary>
        Optimum,
        /// <summary>
        /// 
        /// </summary>
        OptimumExecutorch,
        /// <summary>
        /// 
        /// </summary>
        OptimumHabana,
        /// <summary>
        /// 
        /// </summary>
        OptimumIntel,
        /// <summary>
        /// 
        /// </summary>
        OptimumNeuron,
        /// <summary>
        /// 
        /// </summary>
        OptimumTpu,
        /// <summary>
        /// 
        /// </summary>
        Peft,
        /// <summary>
        /// 
        /// </summary>
        ReachyMini,
        /// <summary>
        /// 
        /// </summary>
        RoboticsCourse,
        /// <summary>
        /// 
        /// </summary>
        Safetensors,
        /// <summary>
        /// 
        /// </summary>
        Sagemaker,
        /// <summary>
        /// 
        /// </summary>
        SentenceTransformers,
        /// <summary>
        /// 
        /// </summary>
        Setfit,
        /// <summary>
        /// 
        /// </summary>
        Simulate,
        /// <summary>
        /// 
        /// </summary>
        SmolCourse,
        /// <summary>
        /// 
        /// </summary>
        Smolagents,
        /// <summary>
        /// 
        /// </summary>
        Tasks,
        /// <summary>
        /// 
        /// </summary>
        Tei,
        /// <summary>
        /// 
        /// </summary>
        Tgi,
        /// <summary>
        /// 
        /// </summary>
        Timm,
        /// <summary>
        /// 
        /// </summary>
        Tokenizers,
        /// <summary>
        /// 
        /// </summary>
        Trackio,
        /// <summary>
        /// 
        /// </summary>
        Transformers,
        /// <summary>
        /// 
        /// </summary>
        TransformersJs,
        /// <summary>
        /// 
        /// </summary>
        Trl,
        /// <summary>
        /// 
        /// </summary>
        Xet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDocsSearchProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocsSearchProduct value)
        {
            return value switch
            {
                GetDocsSearchProduct.Accelerate => "accelerate",
                GetDocsSearchProduct.AgentsCourse => "agents-course",
                GetDocsSearchProduct.Argilla => "argilla",
                GetDocsSearchProduct.AudioCourse => "audio-course",
                GetDocsSearchProduct.Autotrain => "autotrain",
                GetDocsSearchProduct.Bitsandbytes => "bitsandbytes",
                GetDocsSearchProduct.ChatUi => "chat-ui",
                GetDocsSearchProduct.Cli => "cli",
                GetDocsSearchProduct.ComputerVisionCourse => "computer-vision-course",
                GetDocsSearchProduct.ContextCourse => "context-course",
                GetDocsSearchProduct.Cookbook => "cookbook",
                GetDocsSearchProduct.DatasetViewer => "dataset-viewer",
                GetDocsSearchProduct.Datasets => "datasets",
                GetDocsSearchProduct.DeepRlCourse => "deep-rl-course",
                GetDocsSearchProduct.Diffusers => "diffusers",
                GetDocsSearchProduct.DiffusionCourse => "diffusion-course",
                GetDocsSearchProduct.Distilabel => "distilabel",
                GetDocsSearchProduct.Evaluate => "evaluate",
                GetDocsSearchProduct.GoogleCloud => "google-cloud",
                GetDocsSearchProduct.Gradio => "gradio",
                GetDocsSearchProduct.Hub => "hub",
                GetDocsSearchProduct.HuggingfaceJs => "huggingface.js",
                GetDocsSearchProduct.HuggingfaceHub => "huggingface_hub",
                GetDocsSearchProduct.InferenceEndpoints => "inference-endpoints",
                GetDocsSearchProduct.InferenceProviders => "inference-providers",
                GetDocsSearchProduct.Kernels => "kernels",
                GetDocsSearchProduct.Leaderboards => "leaderboards",
                GetDocsSearchProduct.Lerobot => "lerobot",
                GetDocsSearchProduct.Lighteval => "lighteval",
                GetDocsSearchProduct.LlmCourse => "llm-course",
                GetDocsSearchProduct.McpCourse => "mcp-course",
                GetDocsSearchProduct.MicrosoftAzure => "microsoft-azure",
                GetDocsSearchProduct.MlFor3dCourse => "ml-for-3d-course",
                GetDocsSearchProduct.MlGamesCourse => "ml-games-course",
                GetDocsSearchProduct.Optimum => "optimum",
                GetDocsSearchProduct.OptimumExecutorch => "optimum-executorch",
                GetDocsSearchProduct.OptimumHabana => "optimum-habana",
                GetDocsSearchProduct.OptimumIntel => "optimum-intel",
                GetDocsSearchProduct.OptimumNeuron => "optimum-neuron",
                GetDocsSearchProduct.OptimumTpu => "optimum-tpu",
                GetDocsSearchProduct.Peft => "peft",
                GetDocsSearchProduct.ReachyMini => "reachy_mini",
                GetDocsSearchProduct.RoboticsCourse => "robotics-course",
                GetDocsSearchProduct.Safetensors => "safetensors",
                GetDocsSearchProduct.Sagemaker => "sagemaker",
                GetDocsSearchProduct.SentenceTransformers => "sentence_transformers",
                GetDocsSearchProduct.Setfit => "setfit",
                GetDocsSearchProduct.Simulate => "simulate",
                GetDocsSearchProduct.SmolCourse => "smol-course",
                GetDocsSearchProduct.Smolagents => "smolagents",
                GetDocsSearchProduct.Tasks => "tasks",
                GetDocsSearchProduct.Tei => "tei",
                GetDocsSearchProduct.Tgi => "tgi",
                GetDocsSearchProduct.Timm => "timm",
                GetDocsSearchProduct.Tokenizers => "tokenizers",
                GetDocsSearchProduct.Trackio => "trackio",
                GetDocsSearchProduct.Transformers => "transformers",
                GetDocsSearchProduct.TransformersJs => "transformers.js",
                GetDocsSearchProduct.Trl => "trl",
                GetDocsSearchProduct.Xet => "xet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocsSearchProduct? ToEnum(string value)
        {
            return value switch
            {
                "accelerate" => GetDocsSearchProduct.Accelerate,
                "agents-course" => GetDocsSearchProduct.AgentsCourse,
                "argilla" => GetDocsSearchProduct.Argilla,
                "audio-course" => GetDocsSearchProduct.AudioCourse,
                "autotrain" => GetDocsSearchProduct.Autotrain,
                "bitsandbytes" => GetDocsSearchProduct.Bitsandbytes,
                "chat-ui" => GetDocsSearchProduct.ChatUi,
                "cli" => GetDocsSearchProduct.Cli,
                "computer-vision-course" => GetDocsSearchProduct.ComputerVisionCourse,
                "context-course" => GetDocsSearchProduct.ContextCourse,
                "cookbook" => GetDocsSearchProduct.Cookbook,
                "dataset-viewer" => GetDocsSearchProduct.DatasetViewer,
                "datasets" => GetDocsSearchProduct.Datasets,
                "deep-rl-course" => GetDocsSearchProduct.DeepRlCourse,
                "diffusers" => GetDocsSearchProduct.Diffusers,
                "diffusion-course" => GetDocsSearchProduct.DiffusionCourse,
                "distilabel" => GetDocsSearchProduct.Distilabel,
                "evaluate" => GetDocsSearchProduct.Evaluate,
                "google-cloud" => GetDocsSearchProduct.GoogleCloud,
                "gradio" => GetDocsSearchProduct.Gradio,
                "hub" => GetDocsSearchProduct.Hub,
                "huggingface.js" => GetDocsSearchProduct.HuggingfaceJs,
                "huggingface_hub" => GetDocsSearchProduct.HuggingfaceHub,
                "inference-endpoints" => GetDocsSearchProduct.InferenceEndpoints,
                "inference-providers" => GetDocsSearchProduct.InferenceProviders,
                "kernels" => GetDocsSearchProduct.Kernels,
                "leaderboards" => GetDocsSearchProduct.Leaderboards,
                "lerobot" => GetDocsSearchProduct.Lerobot,
                "lighteval" => GetDocsSearchProduct.Lighteval,
                "llm-course" => GetDocsSearchProduct.LlmCourse,
                "mcp-course" => GetDocsSearchProduct.McpCourse,
                "microsoft-azure" => GetDocsSearchProduct.MicrosoftAzure,
                "ml-for-3d-course" => GetDocsSearchProduct.MlFor3dCourse,
                "ml-games-course" => GetDocsSearchProduct.MlGamesCourse,
                "optimum" => GetDocsSearchProduct.Optimum,
                "optimum-executorch" => GetDocsSearchProduct.OptimumExecutorch,
                "optimum-habana" => GetDocsSearchProduct.OptimumHabana,
                "optimum-intel" => GetDocsSearchProduct.OptimumIntel,
                "optimum-neuron" => GetDocsSearchProduct.OptimumNeuron,
                "optimum-tpu" => GetDocsSearchProduct.OptimumTpu,
                "peft" => GetDocsSearchProduct.Peft,
                "reachy_mini" => GetDocsSearchProduct.ReachyMini,
                "robotics-course" => GetDocsSearchProduct.RoboticsCourse,
                "safetensors" => GetDocsSearchProduct.Safetensors,
                "sagemaker" => GetDocsSearchProduct.Sagemaker,
                "sentence_transformers" => GetDocsSearchProduct.SentenceTransformers,
                "setfit" => GetDocsSearchProduct.Setfit,
                "simulate" => GetDocsSearchProduct.Simulate,
                "smol-course" => GetDocsSearchProduct.SmolCourse,
                "smolagents" => GetDocsSearchProduct.Smolagents,
                "tasks" => GetDocsSearchProduct.Tasks,
                "tei" => GetDocsSearchProduct.Tei,
                "tgi" => GetDocsSearchProduct.Tgi,
                "timm" => GetDocsSearchProduct.Timm,
                "tokenizers" => GetDocsSearchProduct.Tokenizers,
                "trackio" => GetDocsSearchProduct.Trackio,
                "transformers" => GetDocsSearchProduct.Transformers,
                "transformers.js" => GetDocsSearchProduct.TransformersJs,
                "trl" => GetDocsSearchProduct.Trl,
                "xet" => GetDocsSearchProduct.Xet,
                _ => null,
            };
        }
    }
}