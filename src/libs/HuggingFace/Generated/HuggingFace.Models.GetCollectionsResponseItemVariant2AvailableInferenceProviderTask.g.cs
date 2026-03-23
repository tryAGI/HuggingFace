
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AvailableInferenceProviderTask
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
    public static class GetCollectionsResponseItemVariant2AvailableInferenceProviderTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AvailableInferenceProviderTask value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.AnyToAny => "any-to-any",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.AudioClassification => "audio-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.AudioTextToText => "audio-text-to-text",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.AudioToAudio => "audio-to-audio",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition => "automatic-speech-recognition",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.Conversational => "conversational",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.DepthEstimation => "depth-estimation",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering => "document-question-answering",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.FeatureExtraction => "feature-extraction",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.FillMask => "fill-mask",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.GraphMl => "graph-ml",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageClassification => "image-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction => "image-feature-extraction",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageSegmentation => "image-segmentation",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToImage => "image-text-to-image",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToText => "image-text-to-text",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToVideo => "image-text-to-video",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTo3d => "image-to-3d",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageToImage => "image-to-image",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageToText => "image-to-text",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageToVideo => "image-to-video",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.KeypointDetection => "keypoint-detection",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.MaskGeneration => "mask-generation",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.MultipleChoice => "multiple-choice",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ObjectDetection => "object-detection",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.Other => "other",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.QuestionAnswering => "question-answering",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ReinforcementLearning => "reinforcement-learning",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.Robotics => "robotics",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.SentenceSimilarity => "sentence-similarity",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.Summarization => "summarization",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering => "table-question-answering",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TableToText => "table-to-text",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TabularClassification => "tabular-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TabularRegression => "tabular-regression",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TabularToText => "tabular-to-text",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextClassification => "text-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextGeneration => "text-generation",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextRanking => "text-ranking",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextRetrieval => "text-retrieval",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextTo3d => "text-to-3d",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToAudio => "text-to-audio",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToImage => "text-to-image",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToSpeech => "text-to-speech",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToVideo => "text-to-video",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting => "time-series-forecasting",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TokenClassification => "token-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.Translation => "translation",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration => "unconditional-image-generation",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.VideoClassification => "video-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.VideoTextToText => "video-text-to-text",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.VideoToVideo => "video-to-video",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval => "visual-document-retrieval",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering => "visual-question-answering",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection => "voice-activity-detection",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotClassification => "zero-shot-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification => "zero-shot-image-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AvailableInferenceProviderTask? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.AnyToAny,
                "audio-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.AudioClassification,
                "audio-text-to-text" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.AudioTextToText,
                "audio-to-audio" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.AudioToAudio,
                "automatic-speech-recognition" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition,
                "conversational" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.Conversational,
                "depth-estimation" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.DepthEstimation,
                "document-question-answering" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering,
                "feature-extraction" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.FeatureExtraction,
                "fill-mask" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.FillMask,
                "graph-ml" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.GraphMl,
                "image-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageClassification,
                "image-feature-extraction" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction,
                "image-segmentation" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageSegmentation,
                "image-text-to-image" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToImage,
                "image-text-to-text" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToText,
                "image-text-to-video" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToVideo,
                "image-to-3d" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTo3d,
                "image-to-image" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageToImage,
                "image-to-text" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageToText,
                "image-to-video" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageToVideo,
                "keypoint-detection" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.KeypointDetection,
                "mask-generation" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.MaskGeneration,
                "multiple-choice" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.MultipleChoice,
                "object-detection" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ObjectDetection,
                "other" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.Other,
                "question-answering" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.QuestionAnswering,
                "reinforcement-learning" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ReinforcementLearning,
                "robotics" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.Robotics,
                "sentence-similarity" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.SentenceSimilarity,
                "summarization" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.Summarization,
                "table-question-answering" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering,
                "table-to-text" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TableToText,
                "tabular-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TabularClassification,
                "tabular-regression" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TabularRegression,
                "tabular-to-text" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TabularToText,
                "text-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextClassification,
                "text-generation" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextGeneration,
                "text-ranking" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextRanking,
                "text-retrieval" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextRetrieval,
                "text-to-3d" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextTo3d,
                "text-to-audio" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToAudio,
                "text-to-image" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToImage,
                "text-to-speech" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToSpeech,
                "text-to-video" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToVideo,
                "time-series-forecasting" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting,
                "token-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.TokenClassification,
                "translation" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.Translation,
                "unconditional-image-generation" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration,
                "video-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.VideoClassification,
                "video-text-to-text" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.VideoTextToText,
                "video-to-video" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.VideoToVideo,
                "visual-document-retrieval" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval,
                "visual-question-answering" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering,
                "voice-activity-detection" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection,
                "zero-shot-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotClassification,
                "zero-shot-image-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification,
                "zero-shot-object-detection" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}