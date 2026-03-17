
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum Product
    {
        /// <summary>
        /// 
        /// </summary>
        Hub,
        /// <summary>
        /// 
        /// </summary>
        Transformers,
        /// <summary>
        /// 
        /// </summary>
        Diffusers,
        /// <summary>
        /// 
        /// </summary>
        Datasets,
        /// <summary>
        /// 
        /// </summary>
        Gradio,
        /// <summary>
        /// 
        /// </summary>
        Trackio,
        /// <summary>
        /// 
        /// </summary>
        Smolagents,
        /// <summary>
        /// 
        /// </summary>
        HuggingfaceHub,
        /// <summary>
        /// 
        /// </summary>
        HuggingfaceJs,
        /// <summary>
        /// 
        /// </summary>
        TransformersJs,
        /// <summary>
        /// 
        /// </summary>
        InferenceProviders,
        /// <summary>
        /// 
        /// </summary>
        InferenceEndpoints,
        /// <summary>
        /// 
        /// </summary>
        Peft,
        /// <summary>
        /// 
        /// </summary>
        Accelerate,
        /// <summary>
        /// 
        /// </summary>
        Optimum,
        /// <summary>
        /// 
        /// </summary>
        OptimumHabana,
        /// <summary>
        /// 
        /// </summary>
        OptimumNeuron,
        /// <summary>
        /// 
        /// </summary>
        OptimumIntel,
        /// <summary>
        /// 
        /// </summary>
        OptimumExecutorch,
        /// <summary>
        /// 
        /// </summary>
        OptimumTpu,
        /// <summary>
        /// 
        /// </summary>
        Tokenizers,
        /// <summary>
        /// 
        /// </summary>
        LlmCourse,
        /// <summary>
        /// 
        /// </summary>
        RoboticsCourse,
        /// <summary>
        /// 
        /// </summary>
        McpCourse,
        /// <summary>
        /// 
        /// </summary>
        SmolCourse,
        /// <summary>
        /// 
        /// </summary>
        AgentsCourse,
        /// <summary>
        /// 
        /// </summary>
        DeepRlCourse,
        /// <summary>
        /// 
        /// </summary>
        ComputerVisionCourse,
        /// <summary>
        /// 
        /// </summary>
        Evaluate,
        /// <summary>
        /// 
        /// </summary>
        Tasks,
        /// <summary>
        /// 
        /// </summary>
        DatasetViewer,
        /// <summary>
        /// 
        /// </summary>
        Trl,
        /// <summary>
        /// 
        /// </summary>
        Simulate,
        /// <summary>
        /// 
        /// </summary>
        Sagemaker,
        /// <summary>
        /// 
        /// </summary>
        Timm,
        /// <summary>
        /// 
        /// </summary>
        Safetensors,
        /// <summary>
        /// 
        /// </summary>
        Tgi,
        /// <summary>
        /// 
        /// </summary>
        Setfit,
        /// <summary>
        /// 
        /// </summary>
        AudioCourse,
        /// <summary>
        /// 
        /// </summary>
        Lerobot,
        /// <summary>
        /// 
        /// </summary>
        ReachyMini,
        /// <summary>
        /// 
        /// </summary>
        Autotrain,
        /// <summary>
        /// 
        /// </summary>
        Tei,
        /// <summary>
        /// 
        /// </summary>
        Bitsandbytes,
        /// <summary>
        /// 
        /// </summary>
        Cookbook,
        /// <summary>
        /// 
        /// </summary>
        SentenceTransformers,
        /// <summary>
        /// 
        /// </summary>
        MlGamesCourse,
        /// <summary>
        /// 
        /// </summary>
        DiffusionCourse,
        /// <summary>
        /// 
        /// </summary>
        MlFor3dCourse,
        /// <summary>
        /// 
        /// </summary>
        ChatUi,
        /// <summary>
        /// 
        /// </summary>
        Leaderboards,
        /// <summary>
        /// 
        /// </summary>
        Lighteval,
        /// <summary>
        /// 
        /// </summary>
        Argilla,
        /// <summary>
        /// 
        /// </summary>
        Distilabel,
        /// <summary>
        /// 
        /// </summary>
        MicrosoftAzure,
        /// <summary>
        /// 
        /// </summary>
        Kernels,
        /// <summary>
        /// 
        /// </summary>
        GoogleCloud,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Product value)
        {
            return value switch
            {
                Product.Hub => "hub",
                Product.Transformers => "transformers",
                Product.Diffusers => "diffusers",
                Product.Datasets => "datasets",
                Product.Gradio => "gradio",
                Product.Trackio => "trackio",
                Product.Smolagents => "smolagents",
                Product.HuggingfaceHub => "huggingface_hub",
                Product.HuggingfaceJs => "huggingface.js",
                Product.TransformersJs => "transformers.js",
                Product.InferenceProviders => "inference-providers",
                Product.InferenceEndpoints => "inference-endpoints",
                Product.Peft => "peft",
                Product.Accelerate => "accelerate",
                Product.Optimum => "optimum",
                Product.OptimumHabana => "optimum-habana",
                Product.OptimumNeuron => "optimum-neuron",
                Product.OptimumIntel => "optimum-intel",
                Product.OptimumExecutorch => "optimum-executorch",
                Product.OptimumTpu => "optimum-tpu",
                Product.Tokenizers => "tokenizers",
                Product.LlmCourse => "llm-course",
                Product.RoboticsCourse => "robotics-course",
                Product.McpCourse => "mcp-course",
                Product.SmolCourse => "smol-course",
                Product.AgentsCourse => "agents-course",
                Product.DeepRlCourse => "deep-rl-course",
                Product.ComputerVisionCourse => "computer-vision-course",
                Product.Evaluate => "evaluate",
                Product.Tasks => "tasks",
                Product.DatasetViewer => "dataset-viewer",
                Product.Trl => "trl",
                Product.Simulate => "simulate",
                Product.Sagemaker => "sagemaker",
                Product.Timm => "timm",
                Product.Safetensors => "safetensors",
                Product.Tgi => "tgi",
                Product.Setfit => "setfit",
                Product.AudioCourse => "audio-course",
                Product.Lerobot => "lerobot",
                Product.ReachyMini => "reachy_mini",
                Product.Autotrain => "autotrain",
                Product.Tei => "tei",
                Product.Bitsandbytes => "bitsandbytes",
                Product.Cookbook => "cookbook",
                Product.SentenceTransformers => "sentence_transformers",
                Product.MlGamesCourse => "ml-games-course",
                Product.DiffusionCourse => "diffusion-course",
                Product.MlFor3dCourse => "ml-for-3d-course",
                Product.ChatUi => "chat-ui",
                Product.Leaderboards => "leaderboards",
                Product.Lighteval => "lighteval",
                Product.Argilla => "argilla",
                Product.Distilabel => "distilabel",
                Product.MicrosoftAzure => "microsoft-azure",
                Product.Kernels => "kernels",
                Product.GoogleCloud => "google-cloud",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Product? ToEnum(string value)
        {
            return value switch
            {
                "hub" => Product.Hub,
                "transformers" => Product.Transformers,
                "diffusers" => Product.Diffusers,
                "datasets" => Product.Datasets,
                "gradio" => Product.Gradio,
                "trackio" => Product.Trackio,
                "smolagents" => Product.Smolagents,
                "huggingface_hub" => Product.HuggingfaceHub,
                "huggingface.js" => Product.HuggingfaceJs,
                "transformers.js" => Product.TransformersJs,
                "inference-providers" => Product.InferenceProviders,
                "inference-endpoints" => Product.InferenceEndpoints,
                "peft" => Product.Peft,
                "accelerate" => Product.Accelerate,
                "optimum" => Product.Optimum,
                "optimum-habana" => Product.OptimumHabana,
                "optimum-neuron" => Product.OptimumNeuron,
                "optimum-intel" => Product.OptimumIntel,
                "optimum-executorch" => Product.OptimumExecutorch,
                "optimum-tpu" => Product.OptimumTpu,
                "tokenizers" => Product.Tokenizers,
                "llm-course" => Product.LlmCourse,
                "robotics-course" => Product.RoboticsCourse,
                "mcp-course" => Product.McpCourse,
                "smol-course" => Product.SmolCourse,
                "agents-course" => Product.AgentsCourse,
                "deep-rl-course" => Product.DeepRlCourse,
                "computer-vision-course" => Product.ComputerVisionCourse,
                "evaluate" => Product.Evaluate,
                "tasks" => Product.Tasks,
                "dataset-viewer" => Product.DatasetViewer,
                "trl" => Product.Trl,
                "simulate" => Product.Simulate,
                "sagemaker" => Product.Sagemaker,
                "timm" => Product.Timm,
                "safetensors" => Product.Safetensors,
                "tgi" => Product.Tgi,
                "setfit" => Product.Setfit,
                "audio-course" => Product.AudioCourse,
                "lerobot" => Product.Lerobot,
                "reachy_mini" => Product.ReachyMini,
                "autotrain" => Product.Autotrain,
                "tei" => Product.Tei,
                "bitsandbytes" => Product.Bitsandbytes,
                "cookbook" => Product.Cookbook,
                "sentence_transformers" => Product.SentenceTransformers,
                "ml-games-course" => Product.MlGamesCourse,
                "diffusion-course" => Product.DiffusionCourse,
                "ml-for-3d-course" => Product.MlFor3dCourse,
                "chat-ui" => Product.ChatUi,
                "leaderboards" => Product.Leaderboards,
                "lighteval" => Product.Lighteval,
                "argilla" => Product.Argilla,
                "distilabel" => Product.Distilabel,
                "microsoft-azure" => Product.MicrosoftAzure,
                "kernels" => Product.Kernels,
                "google-cloud" => Product.GoogleCloud,
                _ => null,
            };
        }
    }
}