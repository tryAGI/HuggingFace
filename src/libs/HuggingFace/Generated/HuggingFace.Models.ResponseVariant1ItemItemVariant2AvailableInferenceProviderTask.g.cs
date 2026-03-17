
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask
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
    public static class ResponseVariant1ItemItemVariant2AvailableInferenceProviderTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextClassification => "text-classification",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TokenClassification => "token-classification",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering => "table-question-answering",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.QuestionAnswering => "question-answering",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ZeroShotClassification => "zero-shot-classification",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.Translation => "translation",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.Summarization => "summarization",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.FeatureExtraction => "feature-extraction",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextGeneration => "text-generation",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.FillMask => "fill-mask",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.SentenceSimilarity => "sentence-similarity",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextToSpeech => "text-to-speech",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextToAudio => "text-to-audio",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition => "automatic-speech-recognition",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.AudioToAudio => "audio-to-audio",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.AudioClassification => "audio-classification",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.AudioTextToText => "audio-text-to-text",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection => "voice-activity-detection",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.DepthEstimation => "depth-estimation",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageClassification => "image-classification",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ObjectDetection => "object-detection",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageSegmentation => "image-segmentation",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextToImage => "text-to-image",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageToText => "image-to-text",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageToImage => "image-to-image",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageToVideo => "image-to-video",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration => "unconditional-image-generation",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.VideoClassification => "video-classification",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ReinforcementLearning => "reinforcement-learning",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.Robotics => "robotics",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TabularClassification => "tabular-classification",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TabularRegression => "tabular-regression",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TabularToText => "tabular-to-text",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TableToText => "table-to-text",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.MultipleChoice => "multiple-choice",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextRanking => "text-ranking",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextRetrieval => "text-retrieval",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting => "time-series-forecasting",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextToVideo => "text-to-video",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageTextToText => "image-text-to-text",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageTextToImage => "image-text-to-image",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageTextToVideo => "image-text-to-video",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering => "visual-question-answering",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering => "document-question-answering",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification => "zero-shot-image-classification",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.GraphMl => "graph-ml",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.MaskGeneration => "mask-generation",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection => "zero-shot-object-detection",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextTo3d => "text-to-3d",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageTo3d => "image-to-3d",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction => "image-feature-extraction",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.VideoTextToText => "video-text-to-text",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.KeypointDetection => "keypoint-detection",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval => "visual-document-retrieval",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.AnyToAny => "any-to-any",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.VideoToVideo => "video-to-video",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.Other => "other",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.Conversational => "conversational",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask? ToEnum(string value)
        {
            return value switch
            {
                "text-classification" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextClassification,
                "token-classification" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TokenClassification,
                "table-question-answering" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering,
                "question-answering" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.QuestionAnswering,
                "zero-shot-classification" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ZeroShotClassification,
                "translation" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.Translation,
                "summarization" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.Summarization,
                "feature-extraction" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.FeatureExtraction,
                "text-generation" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextGeneration,
                "fill-mask" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.FillMask,
                "sentence-similarity" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.SentenceSimilarity,
                "text-to-speech" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextToSpeech,
                "text-to-audio" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextToAudio,
                "automatic-speech-recognition" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition,
                "audio-to-audio" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.AudioToAudio,
                "audio-classification" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.AudioClassification,
                "audio-text-to-text" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.AudioTextToText,
                "voice-activity-detection" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection,
                "depth-estimation" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.DepthEstimation,
                "image-classification" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageClassification,
                "object-detection" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ObjectDetection,
                "image-segmentation" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageSegmentation,
                "text-to-image" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextToImage,
                "image-to-text" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageToText,
                "image-to-image" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageToImage,
                "image-to-video" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageToVideo,
                "unconditional-image-generation" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration,
                "video-classification" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.VideoClassification,
                "reinforcement-learning" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ReinforcementLearning,
                "robotics" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.Robotics,
                "tabular-classification" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TabularClassification,
                "tabular-regression" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TabularRegression,
                "tabular-to-text" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TabularToText,
                "table-to-text" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TableToText,
                "multiple-choice" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.MultipleChoice,
                "text-ranking" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextRanking,
                "text-retrieval" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextRetrieval,
                "time-series-forecasting" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting,
                "text-to-video" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextToVideo,
                "image-text-to-text" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageTextToText,
                "image-text-to-image" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageTextToImage,
                "image-text-to-video" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageTextToVideo,
                "visual-question-answering" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering,
                "document-question-answering" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering,
                "zero-shot-image-classification" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification,
                "graph-ml" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.GraphMl,
                "mask-generation" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.MaskGeneration,
                "zero-shot-object-detection" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection,
                "text-to-3d" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.TextTo3d,
                "image-to-3d" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageTo3d,
                "image-feature-extraction" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction,
                "video-text-to-text" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.VideoTextToText,
                "keypoint-detection" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.KeypointDetection,
                "visual-document-retrieval" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval,
                "any-to-any" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.AnyToAny,
                "video-to-video" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.VideoToVideo,
                "other" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.Other,
                "conversational" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderTask.Conversational,
                _ => null,
            };
        }
    }
}