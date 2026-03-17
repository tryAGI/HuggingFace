
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderTask3
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
    public static class ResponseItemVariant2AvailableInferenceProviderTask3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderTask3 value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderTask3.TextClassification => "text-classification",
                ResponseItemVariant2AvailableInferenceProviderTask3.TokenClassification => "token-classification",
                ResponseItemVariant2AvailableInferenceProviderTask3.TableQuestionAnswering => "table-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask3.QuestionAnswering => "question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask3.ZeroShotClassification => "zero-shot-classification",
                ResponseItemVariant2AvailableInferenceProviderTask3.Translation => "translation",
                ResponseItemVariant2AvailableInferenceProviderTask3.Summarization => "summarization",
                ResponseItemVariant2AvailableInferenceProviderTask3.FeatureExtraction => "feature-extraction",
                ResponseItemVariant2AvailableInferenceProviderTask3.TextGeneration => "text-generation",
                ResponseItemVariant2AvailableInferenceProviderTask3.FillMask => "fill-mask",
                ResponseItemVariant2AvailableInferenceProviderTask3.SentenceSimilarity => "sentence-similarity",
                ResponseItemVariant2AvailableInferenceProviderTask3.TextToSpeech => "text-to-speech",
                ResponseItemVariant2AvailableInferenceProviderTask3.TextToAudio => "text-to-audio",
                ResponseItemVariant2AvailableInferenceProviderTask3.AutomaticSpeechRecognition => "automatic-speech-recognition",
                ResponseItemVariant2AvailableInferenceProviderTask3.AudioToAudio => "audio-to-audio",
                ResponseItemVariant2AvailableInferenceProviderTask3.AudioClassification => "audio-classification",
                ResponseItemVariant2AvailableInferenceProviderTask3.AudioTextToText => "audio-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask3.VoiceActivityDetection => "voice-activity-detection",
                ResponseItemVariant2AvailableInferenceProviderTask3.DepthEstimation => "depth-estimation",
                ResponseItemVariant2AvailableInferenceProviderTask3.ImageClassification => "image-classification",
                ResponseItemVariant2AvailableInferenceProviderTask3.ObjectDetection => "object-detection",
                ResponseItemVariant2AvailableInferenceProviderTask3.ImageSegmentation => "image-segmentation",
                ResponseItemVariant2AvailableInferenceProviderTask3.TextToImage => "text-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask3.ImageToText => "image-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask3.ImageToImage => "image-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask3.ImageToVideo => "image-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask3.UnconditionalImageGeneration => "unconditional-image-generation",
                ResponseItemVariant2AvailableInferenceProviderTask3.VideoClassification => "video-classification",
                ResponseItemVariant2AvailableInferenceProviderTask3.ReinforcementLearning => "reinforcement-learning",
                ResponseItemVariant2AvailableInferenceProviderTask3.Robotics => "robotics",
                ResponseItemVariant2AvailableInferenceProviderTask3.TabularClassification => "tabular-classification",
                ResponseItemVariant2AvailableInferenceProviderTask3.TabularRegression => "tabular-regression",
                ResponseItemVariant2AvailableInferenceProviderTask3.TabularToText => "tabular-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask3.TableToText => "table-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask3.MultipleChoice => "multiple-choice",
                ResponseItemVariant2AvailableInferenceProviderTask3.TextRanking => "text-ranking",
                ResponseItemVariant2AvailableInferenceProviderTask3.TextRetrieval => "text-retrieval",
                ResponseItemVariant2AvailableInferenceProviderTask3.TimeSeriesForecasting => "time-series-forecasting",
                ResponseItemVariant2AvailableInferenceProviderTask3.TextToVideo => "text-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask3.ImageTextToText => "image-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask3.ImageTextToImage => "image-text-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask3.ImageTextToVideo => "image-text-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask3.VisualQuestionAnswering => "visual-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask3.DocumentQuestionAnswering => "document-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask3.ZeroShotImageClassification => "zero-shot-image-classification",
                ResponseItemVariant2AvailableInferenceProviderTask3.GraphMl => "graph-ml",
                ResponseItemVariant2AvailableInferenceProviderTask3.MaskGeneration => "mask-generation",
                ResponseItemVariant2AvailableInferenceProviderTask3.ZeroShotObjectDetection => "zero-shot-object-detection",
                ResponseItemVariant2AvailableInferenceProviderTask3.TextTo3d => "text-to-3d",
                ResponseItemVariant2AvailableInferenceProviderTask3.ImageTo3d => "image-to-3d",
                ResponseItemVariant2AvailableInferenceProviderTask3.ImageFeatureExtraction => "image-feature-extraction",
                ResponseItemVariant2AvailableInferenceProviderTask3.VideoTextToText => "video-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask3.KeypointDetection => "keypoint-detection",
                ResponseItemVariant2AvailableInferenceProviderTask3.VisualDocumentRetrieval => "visual-document-retrieval",
                ResponseItemVariant2AvailableInferenceProviderTask3.AnyToAny => "any-to-any",
                ResponseItemVariant2AvailableInferenceProviderTask3.VideoToVideo => "video-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask3.Other => "other",
                ResponseItemVariant2AvailableInferenceProviderTask3.Conversational => "conversational",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderTask3? ToEnum(string value)
        {
            return value switch
            {
                "text-classification" => ResponseItemVariant2AvailableInferenceProviderTask3.TextClassification,
                "token-classification" => ResponseItemVariant2AvailableInferenceProviderTask3.TokenClassification,
                "table-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask3.TableQuestionAnswering,
                "question-answering" => ResponseItemVariant2AvailableInferenceProviderTask3.QuestionAnswering,
                "zero-shot-classification" => ResponseItemVariant2AvailableInferenceProviderTask3.ZeroShotClassification,
                "translation" => ResponseItemVariant2AvailableInferenceProviderTask3.Translation,
                "summarization" => ResponseItemVariant2AvailableInferenceProviderTask3.Summarization,
                "feature-extraction" => ResponseItemVariant2AvailableInferenceProviderTask3.FeatureExtraction,
                "text-generation" => ResponseItemVariant2AvailableInferenceProviderTask3.TextGeneration,
                "fill-mask" => ResponseItemVariant2AvailableInferenceProviderTask3.FillMask,
                "sentence-similarity" => ResponseItemVariant2AvailableInferenceProviderTask3.SentenceSimilarity,
                "text-to-speech" => ResponseItemVariant2AvailableInferenceProviderTask3.TextToSpeech,
                "text-to-audio" => ResponseItemVariant2AvailableInferenceProviderTask3.TextToAudio,
                "automatic-speech-recognition" => ResponseItemVariant2AvailableInferenceProviderTask3.AutomaticSpeechRecognition,
                "audio-to-audio" => ResponseItemVariant2AvailableInferenceProviderTask3.AudioToAudio,
                "audio-classification" => ResponseItemVariant2AvailableInferenceProviderTask3.AudioClassification,
                "audio-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask3.AudioTextToText,
                "voice-activity-detection" => ResponseItemVariant2AvailableInferenceProviderTask3.VoiceActivityDetection,
                "depth-estimation" => ResponseItemVariant2AvailableInferenceProviderTask3.DepthEstimation,
                "image-classification" => ResponseItemVariant2AvailableInferenceProviderTask3.ImageClassification,
                "object-detection" => ResponseItemVariant2AvailableInferenceProviderTask3.ObjectDetection,
                "image-segmentation" => ResponseItemVariant2AvailableInferenceProviderTask3.ImageSegmentation,
                "text-to-image" => ResponseItemVariant2AvailableInferenceProviderTask3.TextToImage,
                "image-to-text" => ResponseItemVariant2AvailableInferenceProviderTask3.ImageToText,
                "image-to-image" => ResponseItemVariant2AvailableInferenceProviderTask3.ImageToImage,
                "image-to-video" => ResponseItemVariant2AvailableInferenceProviderTask3.ImageToVideo,
                "unconditional-image-generation" => ResponseItemVariant2AvailableInferenceProviderTask3.UnconditionalImageGeneration,
                "video-classification" => ResponseItemVariant2AvailableInferenceProviderTask3.VideoClassification,
                "reinforcement-learning" => ResponseItemVariant2AvailableInferenceProviderTask3.ReinforcementLearning,
                "robotics" => ResponseItemVariant2AvailableInferenceProviderTask3.Robotics,
                "tabular-classification" => ResponseItemVariant2AvailableInferenceProviderTask3.TabularClassification,
                "tabular-regression" => ResponseItemVariant2AvailableInferenceProviderTask3.TabularRegression,
                "tabular-to-text" => ResponseItemVariant2AvailableInferenceProviderTask3.TabularToText,
                "table-to-text" => ResponseItemVariant2AvailableInferenceProviderTask3.TableToText,
                "multiple-choice" => ResponseItemVariant2AvailableInferenceProviderTask3.MultipleChoice,
                "text-ranking" => ResponseItemVariant2AvailableInferenceProviderTask3.TextRanking,
                "text-retrieval" => ResponseItemVariant2AvailableInferenceProviderTask3.TextRetrieval,
                "time-series-forecasting" => ResponseItemVariant2AvailableInferenceProviderTask3.TimeSeriesForecasting,
                "text-to-video" => ResponseItemVariant2AvailableInferenceProviderTask3.TextToVideo,
                "image-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask3.ImageTextToText,
                "image-text-to-image" => ResponseItemVariant2AvailableInferenceProviderTask3.ImageTextToImage,
                "image-text-to-video" => ResponseItemVariant2AvailableInferenceProviderTask3.ImageTextToVideo,
                "visual-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask3.VisualQuestionAnswering,
                "document-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask3.DocumentQuestionAnswering,
                "zero-shot-image-classification" => ResponseItemVariant2AvailableInferenceProviderTask3.ZeroShotImageClassification,
                "graph-ml" => ResponseItemVariant2AvailableInferenceProviderTask3.GraphMl,
                "mask-generation" => ResponseItemVariant2AvailableInferenceProviderTask3.MaskGeneration,
                "zero-shot-object-detection" => ResponseItemVariant2AvailableInferenceProviderTask3.ZeroShotObjectDetection,
                "text-to-3d" => ResponseItemVariant2AvailableInferenceProviderTask3.TextTo3d,
                "image-to-3d" => ResponseItemVariant2AvailableInferenceProviderTask3.ImageTo3d,
                "image-feature-extraction" => ResponseItemVariant2AvailableInferenceProviderTask3.ImageFeatureExtraction,
                "video-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask3.VideoTextToText,
                "keypoint-detection" => ResponseItemVariant2AvailableInferenceProviderTask3.KeypointDetection,
                "visual-document-retrieval" => ResponseItemVariant2AvailableInferenceProviderTask3.VisualDocumentRetrieval,
                "any-to-any" => ResponseItemVariant2AvailableInferenceProviderTask3.AnyToAny,
                "video-to-video" => ResponseItemVariant2AvailableInferenceProviderTask3.VideoToVideo,
                "other" => ResponseItemVariant2AvailableInferenceProviderTask3.Other,
                "conversational" => ResponseItemVariant2AvailableInferenceProviderTask3.Conversational,
                _ => null,
            };
        }
    }
}