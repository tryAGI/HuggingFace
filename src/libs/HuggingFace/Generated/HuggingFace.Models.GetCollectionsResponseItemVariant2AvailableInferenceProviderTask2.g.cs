
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2
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
    public static class GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.AnyToAny => "any-to-any",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.AudioClassification => "audio-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.AudioTextToText => "audio-text-to-text",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.AudioToAudio => "audio-to-audio",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.AutomaticSpeechRecognition => "automatic-speech-recognition",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.Conversational => "conversational",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.DepthEstimation => "depth-estimation",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.DocumentQuestionAnswering => "document-question-answering",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.FeatureExtraction => "feature-extraction",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.FillMask => "fill-mask",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.GraphMl => "graph-ml",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageClassification => "image-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageFeatureExtraction => "image-feature-extraction",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageSegmentation => "image-segmentation",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToImage => "image-text-to-image",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToText => "image-text-to-text",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToVideo => "image-text-to-video",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageTo3d => "image-to-3d",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageToImage => "image-to-image",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageToText => "image-to-text",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageToVideo => "image-to-video",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.KeypointDetection => "keypoint-detection",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.MaskGeneration => "mask-generation",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.MultipleChoice => "multiple-choice",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ObjectDetection => "object-detection",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.Other => "other",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.QuestionAnswering => "question-answering",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ReinforcementLearning => "reinforcement-learning",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.Robotics => "robotics",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.SentenceSimilarity => "sentence-similarity",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.Summarization => "summarization",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TableQuestionAnswering => "table-question-answering",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TableToText => "table-to-text",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TabularClassification => "tabular-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TabularRegression => "tabular-regression",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TabularToText => "tabular-to-text",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextClassification => "text-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextGeneration => "text-generation",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextRanking => "text-ranking",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextRetrieval => "text-retrieval",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextTo3d => "text-to-3d",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextToAudio => "text-to-audio",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextToImage => "text-to-image",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextToSpeech => "text-to-speech",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextToVideo => "text-to-video",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TimeSeriesForecasting => "time-series-forecasting",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TokenClassification => "token-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.Translation => "translation",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.UnconditionalImageGeneration => "unconditional-image-generation",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.VideoClassification => "video-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.VideoTextToText => "video-text-to-text",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.VideoToVideo => "video-to-video",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.VisualDocumentRetrieval => "visual-document-retrieval",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.VisualQuestionAnswering => "visual-question-answering",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.VoiceActivityDetection => "voice-activity-detection",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotClassification => "zero-shot-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotImageClassification => "zero-shot-image-classification",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.AnyToAny,
                "audio-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.AudioClassification,
                "audio-text-to-text" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.AudioTextToText,
                "audio-to-audio" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.AudioToAudio,
                "automatic-speech-recognition" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.AutomaticSpeechRecognition,
                "conversational" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.Conversational,
                "depth-estimation" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.DepthEstimation,
                "document-question-answering" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.DocumentQuestionAnswering,
                "feature-extraction" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.FeatureExtraction,
                "fill-mask" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.FillMask,
                "graph-ml" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.GraphMl,
                "image-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageClassification,
                "image-feature-extraction" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageFeatureExtraction,
                "image-segmentation" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageSegmentation,
                "image-text-to-image" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToImage,
                "image-text-to-text" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToText,
                "image-text-to-video" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToVideo,
                "image-to-3d" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageTo3d,
                "image-to-image" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageToImage,
                "image-to-text" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageToText,
                "image-to-video" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ImageToVideo,
                "keypoint-detection" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.KeypointDetection,
                "mask-generation" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.MaskGeneration,
                "multiple-choice" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.MultipleChoice,
                "object-detection" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ObjectDetection,
                "other" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.Other,
                "question-answering" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.QuestionAnswering,
                "reinforcement-learning" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ReinforcementLearning,
                "robotics" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.Robotics,
                "sentence-similarity" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.SentenceSimilarity,
                "summarization" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.Summarization,
                "table-question-answering" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TableQuestionAnswering,
                "table-to-text" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TableToText,
                "tabular-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TabularClassification,
                "tabular-regression" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TabularRegression,
                "tabular-to-text" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TabularToText,
                "text-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextClassification,
                "text-generation" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextGeneration,
                "text-ranking" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextRanking,
                "text-retrieval" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextRetrieval,
                "text-to-3d" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextTo3d,
                "text-to-audio" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextToAudio,
                "text-to-image" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextToImage,
                "text-to-speech" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextToSpeech,
                "text-to-video" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TextToVideo,
                "time-series-forecasting" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TimeSeriesForecasting,
                "token-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.TokenClassification,
                "translation" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.Translation,
                "unconditional-image-generation" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.UnconditionalImageGeneration,
                "video-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.VideoClassification,
                "video-text-to-text" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.VideoTextToText,
                "video-to-video" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.VideoToVideo,
                "visual-document-retrieval" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.VisualDocumentRetrieval,
                "visual-question-answering" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.VisualQuestionAnswering,
                "voice-activity-detection" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.VoiceActivityDetection,
                "zero-shot-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotClassification,
                "zero-shot-image-classification" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotImageClassification,
                "zero-shot-object-detection" => GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}