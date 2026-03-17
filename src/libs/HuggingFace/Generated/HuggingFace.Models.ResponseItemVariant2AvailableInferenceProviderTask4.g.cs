
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderTask4
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
    public static class ResponseItemVariant2AvailableInferenceProviderTask4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderTask4 value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderTask4.TextClassification => "text-classification",
                ResponseItemVariant2AvailableInferenceProviderTask4.TokenClassification => "token-classification",
                ResponseItemVariant2AvailableInferenceProviderTask4.TableQuestionAnswering => "table-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask4.QuestionAnswering => "question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask4.ZeroShotClassification => "zero-shot-classification",
                ResponseItemVariant2AvailableInferenceProviderTask4.Translation => "translation",
                ResponseItemVariant2AvailableInferenceProviderTask4.Summarization => "summarization",
                ResponseItemVariant2AvailableInferenceProviderTask4.FeatureExtraction => "feature-extraction",
                ResponseItemVariant2AvailableInferenceProviderTask4.TextGeneration => "text-generation",
                ResponseItemVariant2AvailableInferenceProviderTask4.FillMask => "fill-mask",
                ResponseItemVariant2AvailableInferenceProviderTask4.SentenceSimilarity => "sentence-similarity",
                ResponseItemVariant2AvailableInferenceProviderTask4.TextToSpeech => "text-to-speech",
                ResponseItemVariant2AvailableInferenceProviderTask4.TextToAudio => "text-to-audio",
                ResponseItemVariant2AvailableInferenceProviderTask4.AutomaticSpeechRecognition => "automatic-speech-recognition",
                ResponseItemVariant2AvailableInferenceProviderTask4.AudioToAudio => "audio-to-audio",
                ResponseItemVariant2AvailableInferenceProviderTask4.AudioClassification => "audio-classification",
                ResponseItemVariant2AvailableInferenceProviderTask4.AudioTextToText => "audio-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask4.VoiceActivityDetection => "voice-activity-detection",
                ResponseItemVariant2AvailableInferenceProviderTask4.DepthEstimation => "depth-estimation",
                ResponseItemVariant2AvailableInferenceProviderTask4.ImageClassification => "image-classification",
                ResponseItemVariant2AvailableInferenceProviderTask4.ObjectDetection => "object-detection",
                ResponseItemVariant2AvailableInferenceProviderTask4.ImageSegmentation => "image-segmentation",
                ResponseItemVariant2AvailableInferenceProviderTask4.TextToImage => "text-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask4.ImageToText => "image-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask4.ImageToImage => "image-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask4.ImageToVideo => "image-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask4.UnconditionalImageGeneration => "unconditional-image-generation",
                ResponseItemVariant2AvailableInferenceProviderTask4.VideoClassification => "video-classification",
                ResponseItemVariant2AvailableInferenceProviderTask4.ReinforcementLearning => "reinforcement-learning",
                ResponseItemVariant2AvailableInferenceProviderTask4.Robotics => "robotics",
                ResponseItemVariant2AvailableInferenceProviderTask4.TabularClassification => "tabular-classification",
                ResponseItemVariant2AvailableInferenceProviderTask4.TabularRegression => "tabular-regression",
                ResponseItemVariant2AvailableInferenceProviderTask4.TabularToText => "tabular-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask4.TableToText => "table-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask4.MultipleChoice => "multiple-choice",
                ResponseItemVariant2AvailableInferenceProviderTask4.TextRanking => "text-ranking",
                ResponseItemVariant2AvailableInferenceProviderTask4.TextRetrieval => "text-retrieval",
                ResponseItemVariant2AvailableInferenceProviderTask4.TimeSeriesForecasting => "time-series-forecasting",
                ResponseItemVariant2AvailableInferenceProviderTask4.TextToVideo => "text-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask4.ImageTextToText => "image-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask4.ImageTextToImage => "image-text-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask4.ImageTextToVideo => "image-text-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask4.VisualQuestionAnswering => "visual-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask4.DocumentQuestionAnswering => "document-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask4.ZeroShotImageClassification => "zero-shot-image-classification",
                ResponseItemVariant2AvailableInferenceProviderTask4.GraphMl => "graph-ml",
                ResponseItemVariant2AvailableInferenceProviderTask4.MaskGeneration => "mask-generation",
                ResponseItemVariant2AvailableInferenceProviderTask4.ZeroShotObjectDetection => "zero-shot-object-detection",
                ResponseItemVariant2AvailableInferenceProviderTask4.TextTo3d => "text-to-3d",
                ResponseItemVariant2AvailableInferenceProviderTask4.ImageTo3d => "image-to-3d",
                ResponseItemVariant2AvailableInferenceProviderTask4.ImageFeatureExtraction => "image-feature-extraction",
                ResponseItemVariant2AvailableInferenceProviderTask4.VideoTextToText => "video-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask4.KeypointDetection => "keypoint-detection",
                ResponseItemVariant2AvailableInferenceProviderTask4.VisualDocumentRetrieval => "visual-document-retrieval",
                ResponseItemVariant2AvailableInferenceProviderTask4.AnyToAny => "any-to-any",
                ResponseItemVariant2AvailableInferenceProviderTask4.VideoToVideo => "video-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask4.Other => "other",
                ResponseItemVariant2AvailableInferenceProviderTask4.Conversational => "conversational",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderTask4? ToEnum(string value)
        {
            return value switch
            {
                "text-classification" => ResponseItemVariant2AvailableInferenceProviderTask4.TextClassification,
                "token-classification" => ResponseItemVariant2AvailableInferenceProviderTask4.TokenClassification,
                "table-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask4.TableQuestionAnswering,
                "question-answering" => ResponseItemVariant2AvailableInferenceProviderTask4.QuestionAnswering,
                "zero-shot-classification" => ResponseItemVariant2AvailableInferenceProviderTask4.ZeroShotClassification,
                "translation" => ResponseItemVariant2AvailableInferenceProviderTask4.Translation,
                "summarization" => ResponseItemVariant2AvailableInferenceProviderTask4.Summarization,
                "feature-extraction" => ResponseItemVariant2AvailableInferenceProviderTask4.FeatureExtraction,
                "text-generation" => ResponseItemVariant2AvailableInferenceProviderTask4.TextGeneration,
                "fill-mask" => ResponseItemVariant2AvailableInferenceProviderTask4.FillMask,
                "sentence-similarity" => ResponseItemVariant2AvailableInferenceProviderTask4.SentenceSimilarity,
                "text-to-speech" => ResponseItemVariant2AvailableInferenceProviderTask4.TextToSpeech,
                "text-to-audio" => ResponseItemVariant2AvailableInferenceProviderTask4.TextToAudio,
                "automatic-speech-recognition" => ResponseItemVariant2AvailableInferenceProviderTask4.AutomaticSpeechRecognition,
                "audio-to-audio" => ResponseItemVariant2AvailableInferenceProviderTask4.AudioToAudio,
                "audio-classification" => ResponseItemVariant2AvailableInferenceProviderTask4.AudioClassification,
                "audio-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask4.AudioTextToText,
                "voice-activity-detection" => ResponseItemVariant2AvailableInferenceProviderTask4.VoiceActivityDetection,
                "depth-estimation" => ResponseItemVariant2AvailableInferenceProviderTask4.DepthEstimation,
                "image-classification" => ResponseItemVariant2AvailableInferenceProviderTask4.ImageClassification,
                "object-detection" => ResponseItemVariant2AvailableInferenceProviderTask4.ObjectDetection,
                "image-segmentation" => ResponseItemVariant2AvailableInferenceProviderTask4.ImageSegmentation,
                "text-to-image" => ResponseItemVariant2AvailableInferenceProviderTask4.TextToImage,
                "image-to-text" => ResponseItemVariant2AvailableInferenceProviderTask4.ImageToText,
                "image-to-image" => ResponseItemVariant2AvailableInferenceProviderTask4.ImageToImage,
                "image-to-video" => ResponseItemVariant2AvailableInferenceProviderTask4.ImageToVideo,
                "unconditional-image-generation" => ResponseItemVariant2AvailableInferenceProviderTask4.UnconditionalImageGeneration,
                "video-classification" => ResponseItemVariant2AvailableInferenceProviderTask4.VideoClassification,
                "reinforcement-learning" => ResponseItemVariant2AvailableInferenceProviderTask4.ReinforcementLearning,
                "robotics" => ResponseItemVariant2AvailableInferenceProviderTask4.Robotics,
                "tabular-classification" => ResponseItemVariant2AvailableInferenceProviderTask4.TabularClassification,
                "tabular-regression" => ResponseItemVariant2AvailableInferenceProviderTask4.TabularRegression,
                "tabular-to-text" => ResponseItemVariant2AvailableInferenceProviderTask4.TabularToText,
                "table-to-text" => ResponseItemVariant2AvailableInferenceProviderTask4.TableToText,
                "multiple-choice" => ResponseItemVariant2AvailableInferenceProviderTask4.MultipleChoice,
                "text-ranking" => ResponseItemVariant2AvailableInferenceProviderTask4.TextRanking,
                "text-retrieval" => ResponseItemVariant2AvailableInferenceProviderTask4.TextRetrieval,
                "time-series-forecasting" => ResponseItemVariant2AvailableInferenceProviderTask4.TimeSeriesForecasting,
                "text-to-video" => ResponseItemVariant2AvailableInferenceProviderTask4.TextToVideo,
                "image-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask4.ImageTextToText,
                "image-text-to-image" => ResponseItemVariant2AvailableInferenceProviderTask4.ImageTextToImage,
                "image-text-to-video" => ResponseItemVariant2AvailableInferenceProviderTask4.ImageTextToVideo,
                "visual-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask4.VisualQuestionAnswering,
                "document-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask4.DocumentQuestionAnswering,
                "zero-shot-image-classification" => ResponseItemVariant2AvailableInferenceProviderTask4.ZeroShotImageClassification,
                "graph-ml" => ResponseItemVariant2AvailableInferenceProviderTask4.GraphMl,
                "mask-generation" => ResponseItemVariant2AvailableInferenceProviderTask4.MaskGeneration,
                "zero-shot-object-detection" => ResponseItemVariant2AvailableInferenceProviderTask4.ZeroShotObjectDetection,
                "text-to-3d" => ResponseItemVariant2AvailableInferenceProviderTask4.TextTo3d,
                "image-to-3d" => ResponseItemVariant2AvailableInferenceProviderTask4.ImageTo3d,
                "image-feature-extraction" => ResponseItemVariant2AvailableInferenceProviderTask4.ImageFeatureExtraction,
                "video-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask4.VideoTextToText,
                "keypoint-detection" => ResponseItemVariant2AvailableInferenceProviderTask4.KeypointDetection,
                "visual-document-retrieval" => ResponseItemVariant2AvailableInferenceProviderTask4.VisualDocumentRetrieval,
                "any-to-any" => ResponseItemVariant2AvailableInferenceProviderTask4.AnyToAny,
                "video-to-video" => ResponseItemVariant2AvailableInferenceProviderTask4.VideoToVideo,
                "other" => ResponseItemVariant2AvailableInferenceProviderTask4.Other,
                "conversational" => ResponseItemVariant2AvailableInferenceProviderTask4.Conversational,
                _ => null,
            };
        }
    }
}