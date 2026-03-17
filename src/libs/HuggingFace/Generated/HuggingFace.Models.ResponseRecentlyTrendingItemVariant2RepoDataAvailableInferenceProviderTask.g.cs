
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask
    {
        /// <summary>
        /// 
        /// </summary>
        TextClassification,
        /// <summary>
        /// 
        /// </summary>
        TokenClassification,
        /// <summary>
        /// 
        /// </summary>
        TableQuestionAnswering,
        /// <summary>
        /// 
        /// </summary>
        QuestionAnswering,
        /// <summary>
        /// 
        /// </summary>
        ZeroShotClassification,
        /// <summary>
        /// 
        /// </summary>
        Translation,
        /// <summary>
        /// 
        /// </summary>
        Summarization,
        /// <summary>
        /// 
        /// </summary>
        FeatureExtraction,
        /// <summary>
        /// 
        /// </summary>
        TextGeneration,
        /// <summary>
        /// 
        /// </summary>
        FillMask,
        /// <summary>
        /// 
        /// </summary>
        SentenceSimilarity,
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
        /// <summary>
        /// 
        /// </summary>
        TextToAudio,
        /// <summary>
        /// 
        /// </summary>
        AutomaticSpeechRecognition,
        /// <summary>
        /// 
        /// </summary>
        AudioToAudio,
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
        VoiceActivityDetection,
        /// <summary>
        /// 
        /// </summary>
        DepthEstimation,
        /// <summary>
        /// 
        /// </summary>
        ImageClassification,
        /// <summary>
        /// 
        /// </summary>
        ObjectDetection,
        /// <summary>
        /// 
        /// </summary>
        ImageSegmentation,
        /// <summary>
        /// 
        /// </summary>
        TextToImage,
        /// <summary>
        /// 
        /// </summary>
        ImageToText,
        /// <summary>
        /// 
        /// </summary>
        ImageToImage,
        /// <summary>
        /// 
        /// </summary>
        ImageToVideo,
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
        ReinforcementLearning,
        /// <summary>
        /// 
        /// </summary>
        Robotics,
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
        TableToText,
        /// <summary>
        /// 
        /// </summary>
        MultipleChoice,
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
        TimeSeriesForecasting,
        /// <summary>
        /// 
        /// </summary>
        TextToVideo,
        /// <summary>
        /// 
        /// </summary>
        ImageTextToText,
        /// <summary>
        /// 
        /// </summary>
        ImageTextToImage,
        /// <summary>
        /// 
        /// </summary>
        ImageTextToVideo,
        /// <summary>
        /// 
        /// </summary>
        VisualQuestionAnswering,
        /// <summary>
        /// 
        /// </summary>
        DocumentQuestionAnswering,
        /// <summary>
        /// 
        /// </summary>
        ZeroShotImageClassification,
        /// <summary>
        /// 
        /// </summary>
        GraphMl,
        /// <summary>
        /// 
        /// </summary>
        MaskGeneration,
        /// <summary>
        /// 
        /// </summary>
        ZeroShotObjectDetection,
        /// <summary>
        /// 
        /// </summary>
        TextTo3d,
        /// <summary>
        /// 
        /// </summary>
        ImageTo3d,
        /// <summary>
        /// 
        /// </summary>
        ImageFeatureExtraction,
        /// <summary>
        /// 
        /// </summary>
        VideoTextToText,
        /// <summary>
        /// 
        /// </summary>
        KeypointDetection,
        /// <summary>
        /// 
        /// </summary>
        VisualDocumentRetrieval,
        /// <summary>
        /// 
        /// </summary>
        AnyToAny,
        /// <summary>
        /// 
        /// </summary>
        VideoToVideo,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Conversational,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextClassification => "text-classification",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TokenClassification => "token-classification",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TableQuestionAnswering => "table-question-answering",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.QuestionAnswering => "question-answering",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ZeroShotClassification => "zero-shot-classification",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Translation => "translation",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Summarization => "summarization",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.FeatureExtraction => "feature-extraction",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextGeneration => "text-generation",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.FillMask => "fill-mask",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.SentenceSimilarity => "sentence-similarity",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToSpeech => "text-to-speech",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToAudio => "text-to-audio",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AutomaticSpeechRecognition => "automatic-speech-recognition",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AudioToAudio => "audio-to-audio",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AudioClassification => "audio-classification",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AudioTextToText => "audio-text-to-text",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VoiceActivityDetection => "voice-activity-detection",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.DepthEstimation => "depth-estimation",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageClassification => "image-classification",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ObjectDetection => "object-detection",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageSegmentation => "image-segmentation",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToImage => "text-to-image",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageToText => "image-to-text",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageToImage => "image-to-image",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageToVideo => "image-to-video",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.UnconditionalImageGeneration => "unconditional-image-generation",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VideoClassification => "video-classification",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ReinforcementLearning => "reinforcement-learning",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Robotics => "robotics",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TabularClassification => "tabular-classification",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TabularRegression => "tabular-regression",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TabularToText => "tabular-to-text",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TableToText => "table-to-text",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.MultipleChoice => "multiple-choice",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextRanking => "text-ranking",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextRetrieval => "text-retrieval",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TimeSeriesForecasting => "time-series-forecasting",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToVideo => "text-to-video",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTextToText => "image-text-to-text",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTextToImage => "image-text-to-image",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTextToVideo => "image-text-to-video",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VisualQuestionAnswering => "visual-question-answering",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.DocumentQuestionAnswering => "document-question-answering",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ZeroShotImageClassification => "zero-shot-image-classification",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.GraphMl => "graph-ml",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.MaskGeneration => "mask-generation",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ZeroShotObjectDetection => "zero-shot-object-detection",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextTo3d => "text-to-3d",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTo3d => "image-to-3d",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageFeatureExtraction => "image-feature-extraction",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VideoTextToText => "video-text-to-text",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.KeypointDetection => "keypoint-detection",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VisualDocumentRetrieval => "visual-document-retrieval",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AnyToAny => "any-to-any",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VideoToVideo => "video-to-video",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Other => "other",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Conversational => "conversational",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask? ToEnum(string value)
        {
            return value switch
            {
                "text-classification" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextClassification,
                "token-classification" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TokenClassification,
                "table-question-answering" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TableQuestionAnswering,
                "question-answering" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.QuestionAnswering,
                "zero-shot-classification" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ZeroShotClassification,
                "translation" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Translation,
                "summarization" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Summarization,
                "feature-extraction" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.FeatureExtraction,
                "text-generation" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextGeneration,
                "fill-mask" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.FillMask,
                "sentence-similarity" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.SentenceSimilarity,
                "text-to-speech" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToSpeech,
                "text-to-audio" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToAudio,
                "automatic-speech-recognition" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AutomaticSpeechRecognition,
                "audio-to-audio" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AudioToAudio,
                "audio-classification" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AudioClassification,
                "audio-text-to-text" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AudioTextToText,
                "voice-activity-detection" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VoiceActivityDetection,
                "depth-estimation" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.DepthEstimation,
                "image-classification" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageClassification,
                "object-detection" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ObjectDetection,
                "image-segmentation" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageSegmentation,
                "text-to-image" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToImage,
                "image-to-text" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageToText,
                "image-to-image" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageToImage,
                "image-to-video" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageToVideo,
                "unconditional-image-generation" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.UnconditionalImageGeneration,
                "video-classification" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VideoClassification,
                "reinforcement-learning" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ReinforcementLearning,
                "robotics" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Robotics,
                "tabular-classification" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TabularClassification,
                "tabular-regression" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TabularRegression,
                "tabular-to-text" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TabularToText,
                "table-to-text" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TableToText,
                "multiple-choice" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.MultipleChoice,
                "text-ranking" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextRanking,
                "text-retrieval" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextRetrieval,
                "time-series-forecasting" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TimeSeriesForecasting,
                "text-to-video" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextToVideo,
                "image-text-to-text" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTextToText,
                "image-text-to-image" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTextToImage,
                "image-text-to-video" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTextToVideo,
                "visual-question-answering" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VisualQuestionAnswering,
                "document-question-answering" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.DocumentQuestionAnswering,
                "zero-shot-image-classification" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ZeroShotImageClassification,
                "graph-ml" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.GraphMl,
                "mask-generation" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.MaskGeneration,
                "zero-shot-object-detection" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ZeroShotObjectDetection,
                "text-to-3d" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.TextTo3d,
                "image-to-3d" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageTo3d,
                "image-feature-extraction" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.ImageFeatureExtraction,
                "video-text-to-text" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VideoTextToText,
                "keypoint-detection" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.KeypointDetection,
                "visual-document-retrieval" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VisualDocumentRetrieval,
                "any-to-any" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.AnyToAny,
                "video-to-video" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.VideoToVideo,
                "other" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Other,
                "conversational" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask.Conversational,
                _ => null,
            };
        }
    }
}