
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask
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
    public static class PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.AnyToAny => "any-to-any",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.AudioClassification => "audio-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.AudioTextToText => "audio-text-to-text",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.AudioToAudio => "audio-to-audio",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition => "automatic-speech-recognition",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.Conversational => "conversational",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.DepthEstimation => "depth-estimation",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering => "document-question-answering",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.FeatureExtraction => "feature-extraction",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.FillMask => "fill-mask",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.GraphMl => "graph-ml",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageClassification => "image-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction => "image-feature-extraction",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageSegmentation => "image-segmentation",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageTextToImage => "image-text-to-image",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageTextToText => "image-text-to-text",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageTextToVideo => "image-text-to-video",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageTo3d => "image-to-3d",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageToImage => "image-to-image",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageToText => "image-to-text",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageToVideo => "image-to-video",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.KeypointDetection => "keypoint-detection",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.MaskGeneration => "mask-generation",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.MultipleChoice => "multiple-choice",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ObjectDetection => "object-detection",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.Other => "other",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.QuestionAnswering => "question-answering",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ReinforcementLearning => "reinforcement-learning",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.Robotics => "robotics",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.SentenceSimilarity => "sentence-similarity",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.Summarization => "summarization",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering => "table-question-answering",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TableToText => "table-to-text",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TabularClassification => "tabular-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TabularRegression => "tabular-regression",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TabularToText => "tabular-to-text",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextClassification => "text-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextGeneration => "text-generation",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextRanking => "text-ranking",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextRetrieval => "text-retrieval",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextTo3d => "text-to-3d",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextToAudio => "text-to-audio",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextToImage => "text-to-image",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextToSpeech => "text-to-speech",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextToVideo => "text-to-video",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting => "time-series-forecasting",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TokenClassification => "token-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.Translation => "translation",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration => "unconditional-image-generation",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.VideoClassification => "video-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.VideoTextToText => "video-text-to-text",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.VideoToVideo => "video-to-video",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval => "visual-document-retrieval",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering => "visual-question-answering",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection => "voice-activity-detection",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ZeroShotClassification => "zero-shot-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification => "zero-shot-image-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.AnyToAny,
                "audio-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.AudioClassification,
                "audio-text-to-text" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.AudioTextToText,
                "audio-to-audio" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.AudioToAudio,
                "automatic-speech-recognition" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition,
                "conversational" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.Conversational,
                "depth-estimation" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.DepthEstimation,
                "document-question-answering" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering,
                "feature-extraction" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.FeatureExtraction,
                "fill-mask" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.FillMask,
                "graph-ml" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.GraphMl,
                "image-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageClassification,
                "image-feature-extraction" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction,
                "image-segmentation" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageSegmentation,
                "image-text-to-image" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageTextToImage,
                "image-text-to-text" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageTextToText,
                "image-text-to-video" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageTextToVideo,
                "image-to-3d" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageTo3d,
                "image-to-image" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageToImage,
                "image-to-text" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageToText,
                "image-to-video" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ImageToVideo,
                "keypoint-detection" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.KeypointDetection,
                "mask-generation" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.MaskGeneration,
                "multiple-choice" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.MultipleChoice,
                "object-detection" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ObjectDetection,
                "other" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.Other,
                "question-answering" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.QuestionAnswering,
                "reinforcement-learning" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ReinforcementLearning,
                "robotics" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.Robotics,
                "sentence-similarity" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.SentenceSimilarity,
                "summarization" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.Summarization,
                "table-question-answering" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering,
                "table-to-text" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TableToText,
                "tabular-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TabularClassification,
                "tabular-regression" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TabularRegression,
                "tabular-to-text" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TabularToText,
                "text-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextClassification,
                "text-generation" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextGeneration,
                "text-ranking" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextRanking,
                "text-retrieval" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextRetrieval,
                "text-to-3d" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextTo3d,
                "text-to-audio" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextToAudio,
                "text-to-image" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextToImage,
                "text-to-speech" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextToSpeech,
                "text-to-video" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TextToVideo,
                "time-series-forecasting" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting,
                "token-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.TokenClassification,
                "translation" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.Translation,
                "unconditional-image-generation" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration,
                "video-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.VideoClassification,
                "video-text-to-text" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.VideoTextToText,
                "video-to-video" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.VideoToVideo,
                "visual-document-retrieval" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval,
                "visual-question-answering" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering,
                "voice-activity-detection" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection,
                "zero-shot-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ZeroShotClassification,
                "zero-shot-image-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification,
                "zero-shot-object-detection" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}