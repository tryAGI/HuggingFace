
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderTask
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
    public static class ResponseItemVariant2AvailableInferenceProviderTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderTask value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderTask.TextClassification => "text-classification",
                ResponseItemVariant2AvailableInferenceProviderTask.TokenClassification => "token-classification",
                ResponseItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering => "table-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask.QuestionAnswering => "question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask.ZeroShotClassification => "zero-shot-classification",
                ResponseItemVariant2AvailableInferenceProviderTask.Translation => "translation",
                ResponseItemVariant2AvailableInferenceProviderTask.Summarization => "summarization",
                ResponseItemVariant2AvailableInferenceProviderTask.FeatureExtraction => "feature-extraction",
                ResponseItemVariant2AvailableInferenceProviderTask.TextGeneration => "text-generation",
                ResponseItemVariant2AvailableInferenceProviderTask.FillMask => "fill-mask",
                ResponseItemVariant2AvailableInferenceProviderTask.SentenceSimilarity => "sentence-similarity",
                ResponseItemVariant2AvailableInferenceProviderTask.TextToSpeech => "text-to-speech",
                ResponseItemVariant2AvailableInferenceProviderTask.TextToAudio => "text-to-audio",
                ResponseItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition => "automatic-speech-recognition",
                ResponseItemVariant2AvailableInferenceProviderTask.AudioToAudio => "audio-to-audio",
                ResponseItemVariant2AvailableInferenceProviderTask.AudioClassification => "audio-classification",
                ResponseItemVariant2AvailableInferenceProviderTask.AudioTextToText => "audio-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection => "voice-activity-detection",
                ResponseItemVariant2AvailableInferenceProviderTask.DepthEstimation => "depth-estimation",
                ResponseItemVariant2AvailableInferenceProviderTask.ImageClassification => "image-classification",
                ResponseItemVariant2AvailableInferenceProviderTask.ObjectDetection => "object-detection",
                ResponseItemVariant2AvailableInferenceProviderTask.ImageSegmentation => "image-segmentation",
                ResponseItemVariant2AvailableInferenceProviderTask.TextToImage => "text-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask.ImageToText => "image-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask.ImageToImage => "image-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask.ImageToVideo => "image-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration => "unconditional-image-generation",
                ResponseItemVariant2AvailableInferenceProviderTask.VideoClassification => "video-classification",
                ResponseItemVariant2AvailableInferenceProviderTask.ReinforcementLearning => "reinforcement-learning",
                ResponseItemVariant2AvailableInferenceProviderTask.Robotics => "robotics",
                ResponseItemVariant2AvailableInferenceProviderTask.TabularClassification => "tabular-classification",
                ResponseItemVariant2AvailableInferenceProviderTask.TabularRegression => "tabular-regression",
                ResponseItemVariant2AvailableInferenceProviderTask.TabularToText => "tabular-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask.TableToText => "table-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask.MultipleChoice => "multiple-choice",
                ResponseItemVariant2AvailableInferenceProviderTask.TextRanking => "text-ranking",
                ResponseItemVariant2AvailableInferenceProviderTask.TextRetrieval => "text-retrieval",
                ResponseItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting => "time-series-forecasting",
                ResponseItemVariant2AvailableInferenceProviderTask.TextToVideo => "text-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask.ImageTextToText => "image-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask.ImageTextToImage => "image-text-to-image",
                ResponseItemVariant2AvailableInferenceProviderTask.ImageTextToVideo => "image-text-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering => "visual-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering => "document-question-answering",
                ResponseItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification => "zero-shot-image-classification",
                ResponseItemVariant2AvailableInferenceProviderTask.GraphMl => "graph-ml",
                ResponseItemVariant2AvailableInferenceProviderTask.MaskGeneration => "mask-generation",
                ResponseItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection => "zero-shot-object-detection",
                ResponseItemVariant2AvailableInferenceProviderTask.TextTo3d => "text-to-3d",
                ResponseItemVariant2AvailableInferenceProviderTask.ImageTo3d => "image-to-3d",
                ResponseItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction => "image-feature-extraction",
                ResponseItemVariant2AvailableInferenceProviderTask.VideoTextToText => "video-text-to-text",
                ResponseItemVariant2AvailableInferenceProviderTask.KeypointDetection => "keypoint-detection",
                ResponseItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval => "visual-document-retrieval",
                ResponseItemVariant2AvailableInferenceProviderTask.AnyToAny => "any-to-any",
                ResponseItemVariant2AvailableInferenceProviderTask.VideoToVideo => "video-to-video",
                ResponseItemVariant2AvailableInferenceProviderTask.Other => "other",
                ResponseItemVariant2AvailableInferenceProviderTask.Conversational => "conversational",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderTask? ToEnum(string value)
        {
            return value switch
            {
                "text-classification" => ResponseItemVariant2AvailableInferenceProviderTask.TextClassification,
                "token-classification" => ResponseItemVariant2AvailableInferenceProviderTask.TokenClassification,
                "table-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering,
                "question-answering" => ResponseItemVariant2AvailableInferenceProviderTask.QuestionAnswering,
                "zero-shot-classification" => ResponseItemVariant2AvailableInferenceProviderTask.ZeroShotClassification,
                "translation" => ResponseItemVariant2AvailableInferenceProviderTask.Translation,
                "summarization" => ResponseItemVariant2AvailableInferenceProviderTask.Summarization,
                "feature-extraction" => ResponseItemVariant2AvailableInferenceProviderTask.FeatureExtraction,
                "text-generation" => ResponseItemVariant2AvailableInferenceProviderTask.TextGeneration,
                "fill-mask" => ResponseItemVariant2AvailableInferenceProviderTask.FillMask,
                "sentence-similarity" => ResponseItemVariant2AvailableInferenceProviderTask.SentenceSimilarity,
                "text-to-speech" => ResponseItemVariant2AvailableInferenceProviderTask.TextToSpeech,
                "text-to-audio" => ResponseItemVariant2AvailableInferenceProviderTask.TextToAudio,
                "automatic-speech-recognition" => ResponseItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition,
                "audio-to-audio" => ResponseItemVariant2AvailableInferenceProviderTask.AudioToAudio,
                "audio-classification" => ResponseItemVariant2AvailableInferenceProviderTask.AudioClassification,
                "audio-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask.AudioTextToText,
                "voice-activity-detection" => ResponseItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection,
                "depth-estimation" => ResponseItemVariant2AvailableInferenceProviderTask.DepthEstimation,
                "image-classification" => ResponseItemVariant2AvailableInferenceProviderTask.ImageClassification,
                "object-detection" => ResponseItemVariant2AvailableInferenceProviderTask.ObjectDetection,
                "image-segmentation" => ResponseItemVariant2AvailableInferenceProviderTask.ImageSegmentation,
                "text-to-image" => ResponseItemVariant2AvailableInferenceProviderTask.TextToImage,
                "image-to-text" => ResponseItemVariant2AvailableInferenceProviderTask.ImageToText,
                "image-to-image" => ResponseItemVariant2AvailableInferenceProviderTask.ImageToImage,
                "image-to-video" => ResponseItemVariant2AvailableInferenceProviderTask.ImageToVideo,
                "unconditional-image-generation" => ResponseItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration,
                "video-classification" => ResponseItemVariant2AvailableInferenceProviderTask.VideoClassification,
                "reinforcement-learning" => ResponseItemVariant2AvailableInferenceProviderTask.ReinforcementLearning,
                "robotics" => ResponseItemVariant2AvailableInferenceProviderTask.Robotics,
                "tabular-classification" => ResponseItemVariant2AvailableInferenceProviderTask.TabularClassification,
                "tabular-regression" => ResponseItemVariant2AvailableInferenceProviderTask.TabularRegression,
                "tabular-to-text" => ResponseItemVariant2AvailableInferenceProviderTask.TabularToText,
                "table-to-text" => ResponseItemVariant2AvailableInferenceProviderTask.TableToText,
                "multiple-choice" => ResponseItemVariant2AvailableInferenceProviderTask.MultipleChoice,
                "text-ranking" => ResponseItemVariant2AvailableInferenceProviderTask.TextRanking,
                "text-retrieval" => ResponseItemVariant2AvailableInferenceProviderTask.TextRetrieval,
                "time-series-forecasting" => ResponseItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting,
                "text-to-video" => ResponseItemVariant2AvailableInferenceProviderTask.TextToVideo,
                "image-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask.ImageTextToText,
                "image-text-to-image" => ResponseItemVariant2AvailableInferenceProviderTask.ImageTextToImage,
                "image-text-to-video" => ResponseItemVariant2AvailableInferenceProviderTask.ImageTextToVideo,
                "visual-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering,
                "document-question-answering" => ResponseItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering,
                "zero-shot-image-classification" => ResponseItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification,
                "graph-ml" => ResponseItemVariant2AvailableInferenceProviderTask.GraphMl,
                "mask-generation" => ResponseItemVariant2AvailableInferenceProviderTask.MaskGeneration,
                "zero-shot-object-detection" => ResponseItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection,
                "text-to-3d" => ResponseItemVariant2AvailableInferenceProviderTask.TextTo3d,
                "image-to-3d" => ResponseItemVariant2AvailableInferenceProviderTask.ImageTo3d,
                "image-feature-extraction" => ResponseItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction,
                "video-text-to-text" => ResponseItemVariant2AvailableInferenceProviderTask.VideoTextToText,
                "keypoint-detection" => ResponseItemVariant2AvailableInferenceProviderTask.KeypointDetection,
                "visual-document-retrieval" => ResponseItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval,
                "any-to-any" => ResponseItemVariant2AvailableInferenceProviderTask.AnyToAny,
                "video-to-video" => ResponseItemVariant2AvailableInferenceProviderTask.VideoToVideo,
                "other" => ResponseItemVariant2AvailableInferenceProviderTask.Other,
                "conversational" => ResponseItemVariant2AvailableInferenceProviderTask.Conversational,
                _ => null,
            };
        }
    }
}