
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSpacesSemanticSearchCategory
    {
        /// <summary>
        ///
        /// </summary>
        x3dModeling,
        /// <summary>
        ///
        /// </summary>
        AgentEnvironment,
        /// <summary>
        ///
        /// </summary>
        AnomalyDetection,
        /// <summary>
        ///
        /// </summary>
        BackgroundRemoval,
        /// <summary>
        ///
        /// </summary>
        CharacterAnimation,
        /// <summary>
        ///
        /// </summary>
        Chatbots,
        /// <summary>
        ///
        /// </summary>
        CodeGeneration,
        /// <summary>
        ///
        /// </summary>
        DataVisualization,
        /// <summary>
        ///
        /// </summary>
        DatasetCreation,
        /// <summary>
        ///
        /// </summary>
        DocumentAnalysis,
        /// <summary>
        ///
        /// </summary>
        FaceRecognition,
        /// <summary>
        ///
        /// </summary>
        FinancialAnalysis,
        /// <summary>
        ///
        /// </summary>
        FineTuningTools,
        /// <summary>
        ///
        /// </summary>
        GameAi,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        ImageCaptioning,
        /// <summary>
        ///
        /// </summary>
        ImageEditing,
        /// <summary>
        ///
        /// </summary>
        ImageGeneration,
        /// <summary>
        ///
        /// </summary>
        ImageUpscaling,
        /// <summary>
        ///
        /// </summary>
        LanguageTranslation,
        /// <summary>
        ///
        /// </summary>
        MedicalImaging,
        /// <summary>
        ///
        /// </summary>
        ModelBenchmarking,
        /// <summary>
        ///
        /// </summary>
        MusicGeneration,
        /// <summary>
        ///
        /// </summary>
        ObjectDetection,
        /// <summary>
        ///
        /// </summary>
        Ocr,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        PoseEstimation,
        /// <summary>
        ///
        /// </summary>
        QuestionAnswering,
        /// <summary>
        ///
        /// </summary>
        RecommendationSystems,
        /// <summary>
        ///
        /// </summary>
        SentimentAnalysis,
        /// <summary>
        ///
        /// </summary>
        SpeechSynthesis,
        /// <summary>
        ///
        /// </summary>
        StyleTransfer,
        /// <summary>
        ///
        /// </summary>
        TextAnalysis,
        /// <summary>
        ///
        /// </summary>
        TextGeneration,
        /// <summary>
        ///
        /// </summary>
        TextSummarization,
        /// <summary>
        ///
        /// </summary>
        VideoGeneration,
        /// <summary>
        ///
        /// </summary>
        VisualQa,
        /// <summary>
        ///
        /// </summary>
        VoiceCloning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpacesSemanticSearchCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesSemanticSearchCategory value)
        {
            return value switch
            {
                GetSpacesSemanticSearchCategory.x3dModeling => "3d-modeling",
                GetSpacesSemanticSearchCategory.AgentEnvironment => "agent-environment",
                GetSpacesSemanticSearchCategory.AnomalyDetection => "anomaly-detection",
                GetSpacesSemanticSearchCategory.BackgroundRemoval => "background-removal",
                GetSpacesSemanticSearchCategory.CharacterAnimation => "character-animation",
                GetSpacesSemanticSearchCategory.Chatbots => "chatbots",
                GetSpacesSemanticSearchCategory.CodeGeneration => "code-generation",
                GetSpacesSemanticSearchCategory.DataVisualization => "data-visualization",
                GetSpacesSemanticSearchCategory.DatasetCreation => "dataset-creation",
                GetSpacesSemanticSearchCategory.DocumentAnalysis => "document-analysis",
                GetSpacesSemanticSearchCategory.FaceRecognition => "face-recognition",
                GetSpacesSemanticSearchCategory.FinancialAnalysis => "financial-analysis",
                GetSpacesSemanticSearchCategory.FineTuningTools => "fine-tuning-tools",
                GetSpacesSemanticSearchCategory.GameAi => "game-ai",
                GetSpacesSemanticSearchCategory.Image => "image",
                GetSpacesSemanticSearchCategory.ImageCaptioning => "image-captioning",
                GetSpacesSemanticSearchCategory.ImageEditing => "image-editing",
                GetSpacesSemanticSearchCategory.ImageGeneration => "image-generation",
                GetSpacesSemanticSearchCategory.ImageUpscaling => "image-upscaling",
                GetSpacesSemanticSearchCategory.LanguageTranslation => "language-translation",
                GetSpacesSemanticSearchCategory.MedicalImaging => "medical-imaging",
                GetSpacesSemanticSearchCategory.ModelBenchmarking => "model-benchmarking",
                GetSpacesSemanticSearchCategory.MusicGeneration => "music-generation",
                GetSpacesSemanticSearchCategory.ObjectDetection => "object-detection",
                GetSpacesSemanticSearchCategory.Ocr => "ocr",
                GetSpacesSemanticSearchCategory.Other => "other",
                GetSpacesSemanticSearchCategory.PoseEstimation => "pose-estimation",
                GetSpacesSemanticSearchCategory.QuestionAnswering => "question-answering",
                GetSpacesSemanticSearchCategory.RecommendationSystems => "recommendation-systems",
                GetSpacesSemanticSearchCategory.SentimentAnalysis => "sentiment-analysis",
                GetSpacesSemanticSearchCategory.SpeechSynthesis => "speech-synthesis",
                GetSpacesSemanticSearchCategory.StyleTransfer => "style-transfer",
                GetSpacesSemanticSearchCategory.TextAnalysis => "text-analysis",
                GetSpacesSemanticSearchCategory.TextGeneration => "text-generation",
                GetSpacesSemanticSearchCategory.TextSummarization => "text-summarization",
                GetSpacesSemanticSearchCategory.VideoGeneration => "video-generation",
                GetSpacesSemanticSearchCategory.VisualQa => "visual-qa",
                GetSpacesSemanticSearchCategory.VoiceCloning => "voice-cloning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesSemanticSearchCategory? ToEnum(string value)
        {
            return value switch
            {
                "3d-modeling" => GetSpacesSemanticSearchCategory.x3dModeling,
                "agent-environment" => GetSpacesSemanticSearchCategory.AgentEnvironment,
                "anomaly-detection" => GetSpacesSemanticSearchCategory.AnomalyDetection,
                "background-removal" => GetSpacesSemanticSearchCategory.BackgroundRemoval,
                "character-animation" => GetSpacesSemanticSearchCategory.CharacterAnimation,
                "chatbots" => GetSpacesSemanticSearchCategory.Chatbots,
                "code-generation" => GetSpacesSemanticSearchCategory.CodeGeneration,
                "data-visualization" => GetSpacesSemanticSearchCategory.DataVisualization,
                "dataset-creation" => GetSpacesSemanticSearchCategory.DatasetCreation,
                "document-analysis" => GetSpacesSemanticSearchCategory.DocumentAnalysis,
                "face-recognition" => GetSpacesSemanticSearchCategory.FaceRecognition,
                "financial-analysis" => GetSpacesSemanticSearchCategory.FinancialAnalysis,
                "fine-tuning-tools" => GetSpacesSemanticSearchCategory.FineTuningTools,
                "game-ai" => GetSpacesSemanticSearchCategory.GameAi,
                "image" => GetSpacesSemanticSearchCategory.Image,
                "image-captioning" => GetSpacesSemanticSearchCategory.ImageCaptioning,
                "image-editing" => GetSpacesSemanticSearchCategory.ImageEditing,
                "image-generation" => GetSpacesSemanticSearchCategory.ImageGeneration,
                "image-upscaling" => GetSpacesSemanticSearchCategory.ImageUpscaling,
                "language-translation" => GetSpacesSemanticSearchCategory.LanguageTranslation,
                "medical-imaging" => GetSpacesSemanticSearchCategory.MedicalImaging,
                "model-benchmarking" => GetSpacesSemanticSearchCategory.ModelBenchmarking,
                "music-generation" => GetSpacesSemanticSearchCategory.MusicGeneration,
                "object-detection" => GetSpacesSemanticSearchCategory.ObjectDetection,
                "ocr" => GetSpacesSemanticSearchCategory.Ocr,
                "other" => GetSpacesSemanticSearchCategory.Other,
                "pose-estimation" => GetSpacesSemanticSearchCategory.PoseEstimation,
                "question-answering" => GetSpacesSemanticSearchCategory.QuestionAnswering,
                "recommendation-systems" => GetSpacesSemanticSearchCategory.RecommendationSystems,
                "sentiment-analysis" => GetSpacesSemanticSearchCategory.SentimentAnalysis,
                "speech-synthesis" => GetSpacesSemanticSearchCategory.SpeechSynthesis,
                "style-transfer" => GetSpacesSemanticSearchCategory.StyleTransfer,
                "text-analysis" => GetSpacesSemanticSearchCategory.TextAnalysis,
                "text-generation" => GetSpacesSemanticSearchCategory.TextGeneration,
                "text-summarization" => GetSpacesSemanticSearchCategory.TextSummarization,
                "video-generation" => GetSpacesSemanticSearchCategory.VideoGeneration,
                "visual-qa" => GetSpacesSemanticSearchCategory.VisualQa,
                "voice-cloning" => GetSpacesSemanticSearchCategory.VoiceCloning,
                _ => null,
            };
        }
    }
}