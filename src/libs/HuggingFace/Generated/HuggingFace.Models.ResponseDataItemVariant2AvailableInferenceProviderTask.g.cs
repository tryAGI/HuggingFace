
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant2AvailableInferenceProviderTask
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
    public static class ResponseDataItemVariant2AvailableInferenceProviderTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant2AvailableInferenceProviderTask value)
        {
            return value switch
            {
                ResponseDataItemVariant2AvailableInferenceProviderTask.TextClassification => "text-classification",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TokenClassification => "token-classification",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering => "table-question-answering",
                ResponseDataItemVariant2AvailableInferenceProviderTask.QuestionAnswering => "question-answering",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ZeroShotClassification => "zero-shot-classification",
                ResponseDataItemVariant2AvailableInferenceProviderTask.Translation => "translation",
                ResponseDataItemVariant2AvailableInferenceProviderTask.Summarization => "summarization",
                ResponseDataItemVariant2AvailableInferenceProviderTask.FeatureExtraction => "feature-extraction",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TextGeneration => "text-generation",
                ResponseDataItemVariant2AvailableInferenceProviderTask.FillMask => "fill-mask",
                ResponseDataItemVariant2AvailableInferenceProviderTask.SentenceSimilarity => "sentence-similarity",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TextToSpeech => "text-to-speech",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TextToAudio => "text-to-audio",
                ResponseDataItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition => "automatic-speech-recognition",
                ResponseDataItemVariant2AvailableInferenceProviderTask.AudioToAudio => "audio-to-audio",
                ResponseDataItemVariant2AvailableInferenceProviderTask.AudioClassification => "audio-classification",
                ResponseDataItemVariant2AvailableInferenceProviderTask.AudioTextToText => "audio-text-to-text",
                ResponseDataItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection => "voice-activity-detection",
                ResponseDataItemVariant2AvailableInferenceProviderTask.DepthEstimation => "depth-estimation",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ImageClassification => "image-classification",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ObjectDetection => "object-detection",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ImageSegmentation => "image-segmentation",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TextToImage => "text-to-image",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ImageToText => "image-to-text",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ImageToImage => "image-to-image",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ImageToVideo => "image-to-video",
                ResponseDataItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration => "unconditional-image-generation",
                ResponseDataItemVariant2AvailableInferenceProviderTask.VideoClassification => "video-classification",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ReinforcementLearning => "reinforcement-learning",
                ResponseDataItemVariant2AvailableInferenceProviderTask.Robotics => "robotics",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TabularClassification => "tabular-classification",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TabularRegression => "tabular-regression",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TabularToText => "tabular-to-text",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TableToText => "table-to-text",
                ResponseDataItemVariant2AvailableInferenceProviderTask.MultipleChoice => "multiple-choice",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TextRanking => "text-ranking",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TextRetrieval => "text-retrieval",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting => "time-series-forecasting",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TextToVideo => "text-to-video",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ImageTextToText => "image-text-to-text",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ImageTextToImage => "image-text-to-image",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ImageTextToVideo => "image-text-to-video",
                ResponseDataItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering => "visual-question-answering",
                ResponseDataItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering => "document-question-answering",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification => "zero-shot-image-classification",
                ResponseDataItemVariant2AvailableInferenceProviderTask.GraphMl => "graph-ml",
                ResponseDataItemVariant2AvailableInferenceProviderTask.MaskGeneration => "mask-generation",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection => "zero-shot-object-detection",
                ResponseDataItemVariant2AvailableInferenceProviderTask.TextTo3d => "text-to-3d",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ImageTo3d => "image-to-3d",
                ResponseDataItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction => "image-feature-extraction",
                ResponseDataItemVariant2AvailableInferenceProviderTask.VideoTextToText => "video-text-to-text",
                ResponseDataItemVariant2AvailableInferenceProviderTask.KeypointDetection => "keypoint-detection",
                ResponseDataItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval => "visual-document-retrieval",
                ResponseDataItemVariant2AvailableInferenceProviderTask.AnyToAny => "any-to-any",
                ResponseDataItemVariant2AvailableInferenceProviderTask.VideoToVideo => "video-to-video",
                ResponseDataItemVariant2AvailableInferenceProviderTask.Other => "other",
                ResponseDataItemVariant2AvailableInferenceProviderTask.Conversational => "conversational",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant2AvailableInferenceProviderTask? ToEnum(string value)
        {
            return value switch
            {
                "text-classification" => ResponseDataItemVariant2AvailableInferenceProviderTask.TextClassification,
                "token-classification" => ResponseDataItemVariant2AvailableInferenceProviderTask.TokenClassification,
                "table-question-answering" => ResponseDataItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering,
                "question-answering" => ResponseDataItemVariant2AvailableInferenceProviderTask.QuestionAnswering,
                "zero-shot-classification" => ResponseDataItemVariant2AvailableInferenceProviderTask.ZeroShotClassification,
                "translation" => ResponseDataItemVariant2AvailableInferenceProviderTask.Translation,
                "summarization" => ResponseDataItemVariant2AvailableInferenceProviderTask.Summarization,
                "feature-extraction" => ResponseDataItemVariant2AvailableInferenceProviderTask.FeatureExtraction,
                "text-generation" => ResponseDataItemVariant2AvailableInferenceProviderTask.TextGeneration,
                "fill-mask" => ResponseDataItemVariant2AvailableInferenceProviderTask.FillMask,
                "sentence-similarity" => ResponseDataItemVariant2AvailableInferenceProviderTask.SentenceSimilarity,
                "text-to-speech" => ResponseDataItemVariant2AvailableInferenceProviderTask.TextToSpeech,
                "text-to-audio" => ResponseDataItemVariant2AvailableInferenceProviderTask.TextToAudio,
                "automatic-speech-recognition" => ResponseDataItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition,
                "audio-to-audio" => ResponseDataItemVariant2AvailableInferenceProviderTask.AudioToAudio,
                "audio-classification" => ResponseDataItemVariant2AvailableInferenceProviderTask.AudioClassification,
                "audio-text-to-text" => ResponseDataItemVariant2AvailableInferenceProviderTask.AudioTextToText,
                "voice-activity-detection" => ResponseDataItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection,
                "depth-estimation" => ResponseDataItemVariant2AvailableInferenceProviderTask.DepthEstimation,
                "image-classification" => ResponseDataItemVariant2AvailableInferenceProviderTask.ImageClassification,
                "object-detection" => ResponseDataItemVariant2AvailableInferenceProviderTask.ObjectDetection,
                "image-segmentation" => ResponseDataItemVariant2AvailableInferenceProviderTask.ImageSegmentation,
                "text-to-image" => ResponseDataItemVariant2AvailableInferenceProviderTask.TextToImage,
                "image-to-text" => ResponseDataItemVariant2AvailableInferenceProviderTask.ImageToText,
                "image-to-image" => ResponseDataItemVariant2AvailableInferenceProviderTask.ImageToImage,
                "image-to-video" => ResponseDataItemVariant2AvailableInferenceProviderTask.ImageToVideo,
                "unconditional-image-generation" => ResponseDataItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration,
                "video-classification" => ResponseDataItemVariant2AvailableInferenceProviderTask.VideoClassification,
                "reinforcement-learning" => ResponseDataItemVariant2AvailableInferenceProviderTask.ReinforcementLearning,
                "robotics" => ResponseDataItemVariant2AvailableInferenceProviderTask.Robotics,
                "tabular-classification" => ResponseDataItemVariant2AvailableInferenceProviderTask.TabularClassification,
                "tabular-regression" => ResponseDataItemVariant2AvailableInferenceProviderTask.TabularRegression,
                "tabular-to-text" => ResponseDataItemVariant2AvailableInferenceProviderTask.TabularToText,
                "table-to-text" => ResponseDataItemVariant2AvailableInferenceProviderTask.TableToText,
                "multiple-choice" => ResponseDataItemVariant2AvailableInferenceProviderTask.MultipleChoice,
                "text-ranking" => ResponseDataItemVariant2AvailableInferenceProviderTask.TextRanking,
                "text-retrieval" => ResponseDataItemVariant2AvailableInferenceProviderTask.TextRetrieval,
                "time-series-forecasting" => ResponseDataItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting,
                "text-to-video" => ResponseDataItemVariant2AvailableInferenceProviderTask.TextToVideo,
                "image-text-to-text" => ResponseDataItemVariant2AvailableInferenceProviderTask.ImageTextToText,
                "image-text-to-image" => ResponseDataItemVariant2AvailableInferenceProviderTask.ImageTextToImage,
                "image-text-to-video" => ResponseDataItemVariant2AvailableInferenceProviderTask.ImageTextToVideo,
                "visual-question-answering" => ResponseDataItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering,
                "document-question-answering" => ResponseDataItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering,
                "zero-shot-image-classification" => ResponseDataItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification,
                "graph-ml" => ResponseDataItemVariant2AvailableInferenceProviderTask.GraphMl,
                "mask-generation" => ResponseDataItemVariant2AvailableInferenceProviderTask.MaskGeneration,
                "zero-shot-object-detection" => ResponseDataItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection,
                "text-to-3d" => ResponseDataItemVariant2AvailableInferenceProviderTask.TextTo3d,
                "image-to-3d" => ResponseDataItemVariant2AvailableInferenceProviderTask.ImageTo3d,
                "image-feature-extraction" => ResponseDataItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction,
                "video-text-to-text" => ResponseDataItemVariant2AvailableInferenceProviderTask.VideoTextToText,
                "keypoint-detection" => ResponseDataItemVariant2AvailableInferenceProviderTask.KeypointDetection,
                "visual-document-retrieval" => ResponseDataItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval,
                "any-to-any" => ResponseDataItemVariant2AvailableInferenceProviderTask.AnyToAny,
                "video-to-video" => ResponseDataItemVariant2AvailableInferenceProviderTask.VideoToVideo,
                "other" => ResponseDataItemVariant2AvailableInferenceProviderTask.Other,
                "conversational" => ResponseDataItemVariant2AvailableInferenceProviderTask.Conversational,
                _ => null,
            };
        }
    }
}