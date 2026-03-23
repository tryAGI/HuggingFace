
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask
    {
        /// <summary>
        /// 
        /// </summary>
        AnyToAny,
        /// <summary>
        /// 
        /// </summary>
        AudioClassification,
        /// <summary>
        /// 
        /// </summary>
        AudioTextToText,
        /// <summary>
        /// 
        /// </summary>
        AudioToAudio,
        /// <summary>
        /// 
        /// </summary>
        AutomaticSpeechRecognition,
        /// <summary>
        /// 
        /// </summary>
        Conversational,
        /// <summary>
        /// 
        /// </summary>
        DepthEstimation,
        /// <summary>
        /// 
        /// </summary>
        DocumentQuestionAnswering,
        /// <summary>
        /// 
        /// </summary>
        FeatureExtraction,
        /// <summary>
        /// 
        /// </summary>
        FillMask,
        /// <summary>
        /// 
        /// </summary>
        GraphMl,
        /// <summary>
        /// 
        /// </summary>
        ImageClassification,
        /// <summary>
        /// 
        /// </summary>
        ImageFeatureExtraction,
        /// <summary>
        /// 
        /// </summary>
        ImageSegmentation,
        /// <summary>
        /// 
        /// </summary>
        ImageTextToImage,
        /// <summary>
        /// 
        /// </summary>
        ImageTextToText,
        /// <summary>
        /// 
        /// </summary>
        ImageTextToVideo,
        /// <summary>
        /// 
        /// </summary>
        ImageTo3d,
        /// <summary>
        /// 
        /// </summary>
        ImageToImage,
        /// <summary>
        /// 
        /// </summary>
        ImageToText,
        /// <summary>
        /// 
        /// </summary>
        ImageToVideo,
        /// <summary>
        /// 
        /// </summary>
        KeypointDetection,
        /// <summary>
        /// 
        /// </summary>
        MaskGeneration,
        /// <summary>
        /// 
        /// </summary>
        MultipleChoice,
        /// <summary>
        /// 
        /// </summary>
        ObjectDetection,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        QuestionAnswering,
        /// <summary>
        /// 
        /// </summary>
        ReinforcementLearning,
        /// <summary>
        /// 
        /// </summary>
        Robotics,
        /// <summary>
        /// 
        /// </summary>
        SentenceSimilarity,
        /// <summary>
        /// 
        /// </summary>
        Summarization,
        /// <summary>
        /// 
        /// </summary>
        TableQuestionAnswering,
        /// <summary>
        /// 
        /// </summary>
        TableToText,
        /// <summary>
        /// 
        /// </summary>
        TabularClassification,
        /// <summary>
        /// 
        /// </summary>
        TabularRegression,
        /// <summary>
        /// 
        /// </summary>
        TabularToText,
        /// <summary>
        /// 
        /// </summary>
        TextClassification,
        /// <summary>
        /// 
        /// </summary>
        TextGeneration,
        /// <summary>
        /// 
        /// </summary>
        TextRanking,
        /// <summary>
        /// 
        /// </summary>
        TextRetrieval,
        /// <summary>
        /// 
        /// </summary>
        TextTo3d,
        /// <summary>
        /// 
        /// </summary>
        TextToAudio,
        /// <summary>
        /// 
        /// </summary>
        TextToImage,
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
        /// <summary>
        /// 
        /// </summary>
        TextToVideo,
        /// <summary>
        /// 
        /// </summary>
        TimeSeriesForecasting,
        /// <summary>
        /// 
        /// </summary>
        TokenClassification,
        /// <summary>
        /// 
        /// </summary>
        Translation,
        /// <summary>
        /// 
        /// </summary>
        UnconditionalImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        VideoClassification,
        /// <summary>
        /// 
        /// </summary>
        VideoTextToText,
        /// <summary>
        /// 
        /// </summary>
        VideoToVideo,
        /// <summary>
        /// 
        /// </summary>
        VisualDocumentRetrieval,
        /// <summary>
        /// 
        /// </summary>
        VisualQuestionAnswering,
        /// <summary>
        /// 
        /// </summary>
        VoiceActivityDetection,
        /// <summary>
        /// 
        /// </summary>
        ZeroShotClassification,
        /// <summary>
        /// 
        /// </summary>
        ZeroShotImageClassification,
        /// <summary>
        /// 
        /// </summary>
        ZeroShotObjectDetection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AnyToAny => "any-to-any",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AudioClassification => "audio-classification",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AudioTextToText => "audio-text-to-text",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AudioToAudio => "audio-to-audio",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AutomaticSpeechRecognition => "automatic-speech-recognition",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Conversational => "conversational",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.DepthEstimation => "depth-estimation",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.DocumentQuestionAnswering => "document-question-answering",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.FeatureExtraction => "feature-extraction",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.FillMask => "fill-mask",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.GraphMl => "graph-ml",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageClassification => "image-classification",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageFeatureExtraction => "image-feature-extraction",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageSegmentation => "image-segmentation",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTextToImage => "image-text-to-image",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTextToText => "image-text-to-text",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTextToVideo => "image-text-to-video",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTo3d => "image-to-3d",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageToImage => "image-to-image",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageToText => "image-to-text",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageToVideo => "image-to-video",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.KeypointDetection => "keypoint-detection",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.MaskGeneration => "mask-generation",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.MultipleChoice => "multiple-choice",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ObjectDetection => "object-detection",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Other => "other",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.QuestionAnswering => "question-answering",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ReinforcementLearning => "reinforcement-learning",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Robotics => "robotics",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.SentenceSimilarity => "sentence-similarity",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Summarization => "summarization",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TableQuestionAnswering => "table-question-answering",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TableToText => "table-to-text",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TabularClassification => "tabular-classification",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TabularRegression => "tabular-regression",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TabularToText => "tabular-to-text",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextClassification => "text-classification",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextGeneration => "text-generation",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextRanking => "text-ranking",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextRetrieval => "text-retrieval",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextTo3d => "text-to-3d",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToAudio => "text-to-audio",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToImage => "text-to-image",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToSpeech => "text-to-speech",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToVideo => "text-to-video",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TimeSeriesForecasting => "time-series-forecasting",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TokenClassification => "token-classification",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Translation => "translation",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.UnconditionalImageGeneration => "unconditional-image-generation",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VideoClassification => "video-classification",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VideoTextToText => "video-text-to-text",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VideoToVideo => "video-to-video",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VisualDocumentRetrieval => "visual-document-retrieval",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VisualQuestionAnswering => "visual-question-answering",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VoiceActivityDetection => "voice-activity-detection",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ZeroShotClassification => "zero-shot-classification",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ZeroShotImageClassification => "zero-shot-image-classification",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AnyToAny,
                "audio-classification" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AudioClassification,
                "audio-text-to-text" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AudioTextToText,
                "audio-to-audio" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AudioToAudio,
                "automatic-speech-recognition" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AutomaticSpeechRecognition,
                "conversational" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Conversational,
                "depth-estimation" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.DepthEstimation,
                "document-question-answering" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.DocumentQuestionAnswering,
                "feature-extraction" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.FeatureExtraction,
                "fill-mask" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.FillMask,
                "graph-ml" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.GraphMl,
                "image-classification" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageClassification,
                "image-feature-extraction" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageFeatureExtraction,
                "image-segmentation" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageSegmentation,
                "image-text-to-image" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTextToImage,
                "image-text-to-text" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTextToText,
                "image-text-to-video" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTextToVideo,
                "image-to-3d" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTo3d,
                "image-to-image" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageToImage,
                "image-to-text" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageToText,
                "image-to-video" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageToVideo,
                "keypoint-detection" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.KeypointDetection,
                "mask-generation" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.MaskGeneration,
                "multiple-choice" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.MultipleChoice,
                "object-detection" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ObjectDetection,
                "other" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Other,
                "question-answering" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.QuestionAnswering,
                "reinforcement-learning" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ReinforcementLearning,
                "robotics" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Robotics,
                "sentence-similarity" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.SentenceSimilarity,
                "summarization" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Summarization,
                "table-question-answering" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TableQuestionAnswering,
                "table-to-text" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TableToText,
                "tabular-classification" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TabularClassification,
                "tabular-regression" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TabularRegression,
                "tabular-to-text" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TabularToText,
                "text-classification" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextClassification,
                "text-generation" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextGeneration,
                "text-ranking" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextRanking,
                "text-retrieval" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextRetrieval,
                "text-to-3d" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextTo3d,
                "text-to-audio" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToAudio,
                "text-to-image" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToImage,
                "text-to-speech" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToSpeech,
                "text-to-video" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToVideo,
                "time-series-forecasting" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TimeSeriesForecasting,
                "token-classification" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TokenClassification,
                "translation" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Translation,
                "unconditional-image-generation" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.UnconditionalImageGeneration,
                "video-classification" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VideoClassification,
                "video-text-to-text" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VideoTextToText,
                "video-to-video" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VideoToVideo,
                "visual-document-retrieval" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VisualDocumentRetrieval,
                "visual-question-answering" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VisualQuestionAnswering,
                "voice-activity-detection" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VoiceActivityDetection,
                "zero-shot-classification" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ZeroShotClassification,
                "zero-shot-image-classification" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ZeroShotImageClassification,
                "zero-shot-object-detection" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}