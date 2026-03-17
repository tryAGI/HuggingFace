
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderTask2
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
    public static class ResponseItemVariant2AvailableInferenceProviderTask2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderTask2 value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderTask2.TextClassification => "text-classification",
                ResponseItemVariant2AvailableInferenceProviderTask2.TokenClassification => "token-classification",
                ResponseItemVariant2AvailableInferenceProviderTask2.TableQuestionAnswering => "table-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask2.QuestionAnswering => "question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotClassification => "zero-shot-classification",
                ResponseItemVariant2AvailableInferenceProviderTask2.Translation => "translation",
                ResponseItemVariant2AvailableInferenceProviderTask2.Summarization => "summarization",
                ResponseItemVariant2AvailableInferenceProviderTask2.FeatureExtraction => "feature-extraction",
                ResponseItemVariant2AvailableInferenceProviderTask2.TextGeneration => "text-generation",
                ResponseItemVariant2AvailableInferenceProviderTask2.FillMask => "fill-mask",
                ResponseItemVariant2AvailableInferenceProviderTask2.SentenceSimilarity => "sentence-similarity",
                ResponseItemVariant2AvailableInferenceProviderTask2.TextToSpeech => "text-to-speech",
                ResponseItemVariant2AvailableInferenceProviderTask2.TextToAudio => "text-to-audio",
                ResponseItemVariant2AvailableInferenceProviderTask2.AutomaticSpeechRecognition => "automatic-speech-recognition",
                ResponseItemVariant2AvailableInferenceProviderTask2.AudioToAudio => "audio-to-audio",
                ResponseItemVariant2AvailableInferenceProviderTask2.AudioClassification => "audio-classification",
                ResponseItemVariant2AvailableInferenceProviderTask2.AudioTextToText => "audio-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask2.VoiceActivityDetection => "voice-activity-detection",
                ResponseItemVariant2AvailableInferenceProviderTask2.DepthEstimation => "depth-estimation",
                ResponseItemVariant2AvailableInferenceProviderTask2.ImageClassification => "image-classification",
                ResponseItemVariant2AvailableInferenceProviderTask2.ObjectDetection => "object-detection",
                ResponseItemVariant2AvailableInferenceProviderTask2.ImageSegmentation => "image-segmentation",
                ResponseItemVariant2AvailableInferenceProviderTask2.TextToImage => "text-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask2.ImageToText => "image-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask2.ImageToImage => "image-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask2.ImageToVideo => "image-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask2.UnconditionalImageGeneration => "unconditional-image-generation",
                ResponseItemVariant2AvailableInferenceProviderTask2.VideoClassification => "video-classification",
                ResponseItemVariant2AvailableInferenceProviderTask2.ReinforcementLearning => "reinforcement-learning",
                ResponseItemVariant2AvailableInferenceProviderTask2.Robotics => "robotics",
                ResponseItemVariant2AvailableInferenceProviderTask2.TabularClassification => "tabular-classification",
                ResponseItemVariant2AvailableInferenceProviderTask2.TabularRegression => "tabular-regression",
                ResponseItemVariant2AvailableInferenceProviderTask2.TabularToText => "tabular-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask2.TableToText => "table-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask2.MultipleChoice => "multiple-choice",
                ResponseItemVariant2AvailableInferenceProviderTask2.TextRanking => "text-ranking",
                ResponseItemVariant2AvailableInferenceProviderTask2.TextRetrieval => "text-retrieval",
                ResponseItemVariant2AvailableInferenceProviderTask2.TimeSeriesForecasting => "time-series-forecasting",
                ResponseItemVariant2AvailableInferenceProviderTask2.TextToVideo => "text-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToText => "image-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToImage => "image-text-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToVideo => "image-text-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask2.VisualQuestionAnswering => "visual-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask2.DocumentQuestionAnswering => "document-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotImageClassification => "zero-shot-image-classification",
                ResponseItemVariant2AvailableInferenceProviderTask2.GraphMl => "graph-ml",
                ResponseItemVariant2AvailableInferenceProviderTask2.MaskGeneration => "mask-generation",
                ResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotObjectDetection => "zero-shot-object-detection",
                ResponseItemVariant2AvailableInferenceProviderTask2.TextTo3d => "text-to-3d",
                ResponseItemVariant2AvailableInferenceProviderTask2.ImageTo3d => "image-to-3d",
                ResponseItemVariant2AvailableInferenceProviderTask2.ImageFeatureExtraction => "image-feature-extraction",
                ResponseItemVariant2AvailableInferenceProviderTask2.VideoTextToText => "video-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask2.KeypointDetection => "keypoint-detection",
                ResponseItemVariant2AvailableInferenceProviderTask2.VisualDocumentRetrieval => "visual-document-retrieval",
                ResponseItemVariant2AvailableInferenceProviderTask2.AnyToAny => "any-to-any",
                ResponseItemVariant2AvailableInferenceProviderTask2.VideoToVideo => "video-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask2.Other => "other",
                ResponseItemVariant2AvailableInferenceProviderTask2.Conversational => "conversational",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderTask2? ToEnum(string value)
        {
            return value switch
            {
                "text-classification" => ResponseItemVariant2AvailableInferenceProviderTask2.TextClassification,
                "token-classification" => ResponseItemVariant2AvailableInferenceProviderTask2.TokenClassification,
                "table-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask2.TableQuestionAnswering,
                "question-answering" => ResponseItemVariant2AvailableInferenceProviderTask2.QuestionAnswering,
                "zero-shot-classification" => ResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotClassification,
                "translation" => ResponseItemVariant2AvailableInferenceProviderTask2.Translation,
                "summarization" => ResponseItemVariant2AvailableInferenceProviderTask2.Summarization,
                "feature-extraction" => ResponseItemVariant2AvailableInferenceProviderTask2.FeatureExtraction,
                "text-generation" => ResponseItemVariant2AvailableInferenceProviderTask2.TextGeneration,
                "fill-mask" => ResponseItemVariant2AvailableInferenceProviderTask2.FillMask,
                "sentence-similarity" => ResponseItemVariant2AvailableInferenceProviderTask2.SentenceSimilarity,
                "text-to-speech" => ResponseItemVariant2AvailableInferenceProviderTask2.TextToSpeech,
                "text-to-audio" => ResponseItemVariant2AvailableInferenceProviderTask2.TextToAudio,
                "automatic-speech-recognition" => ResponseItemVariant2AvailableInferenceProviderTask2.AutomaticSpeechRecognition,
                "audio-to-audio" => ResponseItemVariant2AvailableInferenceProviderTask2.AudioToAudio,
                "audio-classification" => ResponseItemVariant2AvailableInferenceProviderTask2.AudioClassification,
                "audio-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask2.AudioTextToText,
                "voice-activity-detection" => ResponseItemVariant2AvailableInferenceProviderTask2.VoiceActivityDetection,
                "depth-estimation" => ResponseItemVariant2AvailableInferenceProviderTask2.DepthEstimation,
                "image-classification" => ResponseItemVariant2AvailableInferenceProviderTask2.ImageClassification,
                "object-detection" => ResponseItemVariant2AvailableInferenceProviderTask2.ObjectDetection,
                "image-segmentation" => ResponseItemVariant2AvailableInferenceProviderTask2.ImageSegmentation,
                "text-to-image" => ResponseItemVariant2AvailableInferenceProviderTask2.TextToImage,
                "image-to-text" => ResponseItemVariant2AvailableInferenceProviderTask2.ImageToText,
                "image-to-image" => ResponseItemVariant2AvailableInferenceProviderTask2.ImageToImage,
                "image-to-video" => ResponseItemVariant2AvailableInferenceProviderTask2.ImageToVideo,
                "unconditional-image-generation" => ResponseItemVariant2AvailableInferenceProviderTask2.UnconditionalImageGeneration,
                "video-classification" => ResponseItemVariant2AvailableInferenceProviderTask2.VideoClassification,
                "reinforcement-learning" => ResponseItemVariant2AvailableInferenceProviderTask2.ReinforcementLearning,
                "robotics" => ResponseItemVariant2AvailableInferenceProviderTask2.Robotics,
                "tabular-classification" => ResponseItemVariant2AvailableInferenceProviderTask2.TabularClassification,
                "tabular-regression" => ResponseItemVariant2AvailableInferenceProviderTask2.TabularRegression,
                "tabular-to-text" => ResponseItemVariant2AvailableInferenceProviderTask2.TabularToText,
                "table-to-text" => ResponseItemVariant2AvailableInferenceProviderTask2.TableToText,
                "multiple-choice" => ResponseItemVariant2AvailableInferenceProviderTask2.MultipleChoice,
                "text-ranking" => ResponseItemVariant2AvailableInferenceProviderTask2.TextRanking,
                "text-retrieval" => ResponseItemVariant2AvailableInferenceProviderTask2.TextRetrieval,
                "time-series-forecasting" => ResponseItemVariant2AvailableInferenceProviderTask2.TimeSeriesForecasting,
                "text-to-video" => ResponseItemVariant2AvailableInferenceProviderTask2.TextToVideo,
                "image-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToText,
                "image-text-to-image" => ResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToImage,
                "image-text-to-video" => ResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToVideo,
                "visual-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask2.VisualQuestionAnswering,
                "document-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask2.DocumentQuestionAnswering,
                "zero-shot-image-classification" => ResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotImageClassification,
                "graph-ml" => ResponseItemVariant2AvailableInferenceProviderTask2.GraphMl,
                "mask-generation" => ResponseItemVariant2AvailableInferenceProviderTask2.MaskGeneration,
                "zero-shot-object-detection" => ResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotObjectDetection,
                "text-to-3d" => ResponseItemVariant2AvailableInferenceProviderTask2.TextTo3d,
                "image-to-3d" => ResponseItemVariant2AvailableInferenceProviderTask2.ImageTo3d,
                "image-feature-extraction" => ResponseItemVariant2AvailableInferenceProviderTask2.ImageFeatureExtraction,
                "video-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask2.VideoTextToText,
                "keypoint-detection" => ResponseItemVariant2AvailableInferenceProviderTask2.KeypointDetection,
                "visual-document-retrieval" => ResponseItemVariant2AvailableInferenceProviderTask2.VisualDocumentRetrieval,
                "any-to-any" => ResponseItemVariant2AvailableInferenceProviderTask2.AnyToAny,
                "video-to-video" => ResponseItemVariant2AvailableInferenceProviderTask2.VideoToVideo,
                "other" => ResponseItemVariant2AvailableInferenceProviderTask2.Other,
                "conversational" => ResponseItemVariant2AvailableInferenceProviderTask2.Conversational,
                _ => null,
            };
        }
    }
}