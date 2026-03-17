
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderTask5
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
    public static class ResponseItemVariant2AvailableInferenceProviderTask5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderTask5 value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderTask5.TextClassification => "text-classification",
                ResponseItemVariant2AvailableInferenceProviderTask5.TokenClassification => "token-classification",
                ResponseItemVariant2AvailableInferenceProviderTask5.TableQuestionAnswering => "table-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask5.QuestionAnswering => "question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask5.ZeroShotClassification => "zero-shot-classification",
                ResponseItemVariant2AvailableInferenceProviderTask5.Translation => "translation",
                ResponseItemVariant2AvailableInferenceProviderTask5.Summarization => "summarization",
                ResponseItemVariant2AvailableInferenceProviderTask5.FeatureExtraction => "feature-extraction",
                ResponseItemVariant2AvailableInferenceProviderTask5.TextGeneration => "text-generation",
                ResponseItemVariant2AvailableInferenceProviderTask5.FillMask => "fill-mask",
                ResponseItemVariant2AvailableInferenceProviderTask5.SentenceSimilarity => "sentence-similarity",
                ResponseItemVariant2AvailableInferenceProviderTask5.TextToSpeech => "text-to-speech",
                ResponseItemVariant2AvailableInferenceProviderTask5.TextToAudio => "text-to-audio",
                ResponseItemVariant2AvailableInferenceProviderTask5.AutomaticSpeechRecognition => "automatic-speech-recognition",
                ResponseItemVariant2AvailableInferenceProviderTask5.AudioToAudio => "audio-to-audio",
                ResponseItemVariant2AvailableInferenceProviderTask5.AudioClassification => "audio-classification",
                ResponseItemVariant2AvailableInferenceProviderTask5.AudioTextToText => "audio-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask5.VoiceActivityDetection => "voice-activity-detection",
                ResponseItemVariant2AvailableInferenceProviderTask5.DepthEstimation => "depth-estimation",
                ResponseItemVariant2AvailableInferenceProviderTask5.ImageClassification => "image-classification",
                ResponseItemVariant2AvailableInferenceProviderTask5.ObjectDetection => "object-detection",
                ResponseItemVariant2AvailableInferenceProviderTask5.ImageSegmentation => "image-segmentation",
                ResponseItemVariant2AvailableInferenceProviderTask5.TextToImage => "text-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask5.ImageToText => "image-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask5.ImageToImage => "image-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask5.ImageToVideo => "image-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask5.UnconditionalImageGeneration => "unconditional-image-generation",
                ResponseItemVariant2AvailableInferenceProviderTask5.VideoClassification => "video-classification",
                ResponseItemVariant2AvailableInferenceProviderTask5.ReinforcementLearning => "reinforcement-learning",
                ResponseItemVariant2AvailableInferenceProviderTask5.Robotics => "robotics",
                ResponseItemVariant2AvailableInferenceProviderTask5.TabularClassification => "tabular-classification",
                ResponseItemVariant2AvailableInferenceProviderTask5.TabularRegression => "tabular-regression",
                ResponseItemVariant2AvailableInferenceProviderTask5.TabularToText => "tabular-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask5.TableToText => "table-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask5.MultipleChoice => "multiple-choice",
                ResponseItemVariant2AvailableInferenceProviderTask5.TextRanking => "text-ranking",
                ResponseItemVariant2AvailableInferenceProviderTask5.TextRetrieval => "text-retrieval",
                ResponseItemVariant2AvailableInferenceProviderTask5.TimeSeriesForecasting => "time-series-forecasting",
                ResponseItemVariant2AvailableInferenceProviderTask5.TextToVideo => "text-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask5.ImageTextToText => "image-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask5.ImageTextToImage => "image-text-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask5.ImageTextToVideo => "image-text-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask5.VisualQuestionAnswering => "visual-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask5.DocumentQuestionAnswering => "document-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask5.ZeroShotImageClassification => "zero-shot-image-classification",
                ResponseItemVariant2AvailableInferenceProviderTask5.GraphMl => "graph-ml",
                ResponseItemVariant2AvailableInferenceProviderTask5.MaskGeneration => "mask-generation",
                ResponseItemVariant2AvailableInferenceProviderTask5.ZeroShotObjectDetection => "zero-shot-object-detection",
                ResponseItemVariant2AvailableInferenceProviderTask5.TextTo3d => "text-to-3d",
                ResponseItemVariant2AvailableInferenceProviderTask5.ImageTo3d => "image-to-3d",
                ResponseItemVariant2AvailableInferenceProviderTask5.ImageFeatureExtraction => "image-feature-extraction",
                ResponseItemVariant2AvailableInferenceProviderTask5.VideoTextToText => "video-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask5.KeypointDetection => "keypoint-detection",
                ResponseItemVariant2AvailableInferenceProviderTask5.VisualDocumentRetrieval => "visual-document-retrieval",
                ResponseItemVariant2AvailableInferenceProviderTask5.AnyToAny => "any-to-any",
                ResponseItemVariant2AvailableInferenceProviderTask5.VideoToVideo => "video-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask5.Other => "other",
                ResponseItemVariant2AvailableInferenceProviderTask5.Conversational => "conversational",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderTask5? ToEnum(string value)
        {
            return value switch
            {
                "text-classification" => ResponseItemVariant2AvailableInferenceProviderTask5.TextClassification,
                "token-classification" => ResponseItemVariant2AvailableInferenceProviderTask5.TokenClassification,
                "table-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask5.TableQuestionAnswering,
                "question-answering" => ResponseItemVariant2AvailableInferenceProviderTask5.QuestionAnswering,
                "zero-shot-classification" => ResponseItemVariant2AvailableInferenceProviderTask5.ZeroShotClassification,
                "translation" => ResponseItemVariant2AvailableInferenceProviderTask5.Translation,
                "summarization" => ResponseItemVariant2AvailableInferenceProviderTask5.Summarization,
                "feature-extraction" => ResponseItemVariant2AvailableInferenceProviderTask5.FeatureExtraction,
                "text-generation" => ResponseItemVariant2AvailableInferenceProviderTask5.TextGeneration,
                "fill-mask" => ResponseItemVariant2AvailableInferenceProviderTask5.FillMask,
                "sentence-similarity" => ResponseItemVariant2AvailableInferenceProviderTask5.SentenceSimilarity,
                "text-to-speech" => ResponseItemVariant2AvailableInferenceProviderTask5.TextToSpeech,
                "text-to-audio" => ResponseItemVariant2AvailableInferenceProviderTask5.TextToAudio,
                "automatic-speech-recognition" => ResponseItemVariant2AvailableInferenceProviderTask5.AutomaticSpeechRecognition,
                "audio-to-audio" => ResponseItemVariant2AvailableInferenceProviderTask5.AudioToAudio,
                "audio-classification" => ResponseItemVariant2AvailableInferenceProviderTask5.AudioClassification,
                "audio-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask5.AudioTextToText,
                "voice-activity-detection" => ResponseItemVariant2AvailableInferenceProviderTask5.VoiceActivityDetection,
                "depth-estimation" => ResponseItemVariant2AvailableInferenceProviderTask5.DepthEstimation,
                "image-classification" => ResponseItemVariant2AvailableInferenceProviderTask5.ImageClassification,
                "object-detection" => ResponseItemVariant2AvailableInferenceProviderTask5.ObjectDetection,
                "image-segmentation" => ResponseItemVariant2AvailableInferenceProviderTask5.ImageSegmentation,
                "text-to-image" => ResponseItemVariant2AvailableInferenceProviderTask5.TextToImage,
                "image-to-text" => ResponseItemVariant2AvailableInferenceProviderTask5.ImageToText,
                "image-to-image" => ResponseItemVariant2AvailableInferenceProviderTask5.ImageToImage,
                "image-to-video" => ResponseItemVariant2AvailableInferenceProviderTask5.ImageToVideo,
                "unconditional-image-generation" => ResponseItemVariant2AvailableInferenceProviderTask5.UnconditionalImageGeneration,
                "video-classification" => ResponseItemVariant2AvailableInferenceProviderTask5.VideoClassification,
                "reinforcement-learning" => ResponseItemVariant2AvailableInferenceProviderTask5.ReinforcementLearning,
                "robotics" => ResponseItemVariant2AvailableInferenceProviderTask5.Robotics,
                "tabular-classification" => ResponseItemVariant2AvailableInferenceProviderTask5.TabularClassification,
                "tabular-regression" => ResponseItemVariant2AvailableInferenceProviderTask5.TabularRegression,
                "tabular-to-text" => ResponseItemVariant2AvailableInferenceProviderTask5.TabularToText,
                "table-to-text" => ResponseItemVariant2AvailableInferenceProviderTask5.TableToText,
                "multiple-choice" => ResponseItemVariant2AvailableInferenceProviderTask5.MultipleChoice,
                "text-ranking" => ResponseItemVariant2AvailableInferenceProviderTask5.TextRanking,
                "text-retrieval" => ResponseItemVariant2AvailableInferenceProviderTask5.TextRetrieval,
                "time-series-forecasting" => ResponseItemVariant2AvailableInferenceProviderTask5.TimeSeriesForecasting,
                "text-to-video" => ResponseItemVariant2AvailableInferenceProviderTask5.TextToVideo,
                "image-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask5.ImageTextToText,
                "image-text-to-image" => ResponseItemVariant2AvailableInferenceProviderTask5.ImageTextToImage,
                "image-text-to-video" => ResponseItemVariant2AvailableInferenceProviderTask5.ImageTextToVideo,
                "visual-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask5.VisualQuestionAnswering,
                "document-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask5.DocumentQuestionAnswering,
                "zero-shot-image-classification" => ResponseItemVariant2AvailableInferenceProviderTask5.ZeroShotImageClassification,
                "graph-ml" => ResponseItemVariant2AvailableInferenceProviderTask5.GraphMl,
                "mask-generation" => ResponseItemVariant2AvailableInferenceProviderTask5.MaskGeneration,
                "zero-shot-object-detection" => ResponseItemVariant2AvailableInferenceProviderTask5.ZeroShotObjectDetection,
                "text-to-3d" => ResponseItemVariant2AvailableInferenceProviderTask5.TextTo3d,
                "image-to-3d" => ResponseItemVariant2AvailableInferenceProviderTask5.ImageTo3d,
                "image-feature-extraction" => ResponseItemVariant2AvailableInferenceProviderTask5.ImageFeatureExtraction,
                "video-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask5.VideoTextToText,
                "keypoint-detection" => ResponseItemVariant2AvailableInferenceProviderTask5.KeypointDetection,
                "visual-document-retrieval" => ResponseItemVariant2AvailableInferenceProviderTask5.VisualDocumentRetrieval,
                "any-to-any" => ResponseItemVariant2AvailableInferenceProviderTask5.AnyToAny,
                "video-to-video" => ResponseItemVariant2AvailableInferenceProviderTask5.VideoToVideo,
                "other" => ResponseItemVariant2AvailableInferenceProviderTask5.Other,
                "conversational" => ResponseItemVariant2AvailableInferenceProviderTask5.Conversational,
                _ => null,
            };
        }
    }
}