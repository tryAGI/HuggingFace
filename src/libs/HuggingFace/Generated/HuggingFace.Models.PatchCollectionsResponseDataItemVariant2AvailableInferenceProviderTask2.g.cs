
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2
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
    public static class PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.AnyToAny => "any-to-any",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.AudioClassification => "audio-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.AudioTextToText => "audio-text-to-text",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.AudioToAudio => "audio-to-audio",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.AutomaticSpeechRecognition => "automatic-speech-recognition",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.Conversational => "conversational",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.DepthEstimation => "depth-estimation",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.DocumentQuestionAnswering => "document-question-answering",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.FeatureExtraction => "feature-extraction",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.FillMask => "fill-mask",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.GraphMl => "graph-ml",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageClassification => "image-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageFeatureExtraction => "image-feature-extraction",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageSegmentation => "image-segmentation",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageTextToImage => "image-text-to-image",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageTextToText => "image-text-to-text",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageTextToVideo => "image-text-to-video",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageTo3d => "image-to-3d",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageToImage => "image-to-image",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageToText => "image-to-text",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageToVideo => "image-to-video",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.KeypointDetection => "keypoint-detection",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.MaskGeneration => "mask-generation",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.MultipleChoice => "multiple-choice",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ObjectDetection => "object-detection",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.Other => "other",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.QuestionAnswering => "question-answering",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ReinforcementLearning => "reinforcement-learning",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.Robotics => "robotics",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.SentenceSimilarity => "sentence-similarity",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.Summarization => "summarization",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TableQuestionAnswering => "table-question-answering",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TableToText => "table-to-text",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TabularClassification => "tabular-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TabularRegression => "tabular-regression",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TabularToText => "tabular-to-text",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextClassification => "text-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextGeneration => "text-generation",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextRanking => "text-ranking",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextRetrieval => "text-retrieval",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextTo3d => "text-to-3d",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextToAudio => "text-to-audio",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextToImage => "text-to-image",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextToSpeech => "text-to-speech",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextToVideo => "text-to-video",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TimeSeriesForecasting => "time-series-forecasting",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TokenClassification => "token-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.Translation => "translation",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.UnconditionalImageGeneration => "unconditional-image-generation",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.VideoClassification => "video-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.VideoTextToText => "video-text-to-text",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.VideoToVideo => "video-to-video",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.VisualDocumentRetrieval => "visual-document-retrieval",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.VisualQuestionAnswering => "visual-question-answering",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.VoiceActivityDetection => "voice-activity-detection",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ZeroShotClassification => "zero-shot-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ZeroShotImageClassification => "zero-shot-image-classification",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.AnyToAny,
                "audio-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.AudioClassification,
                "audio-text-to-text" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.AudioTextToText,
                "audio-to-audio" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.AudioToAudio,
                "automatic-speech-recognition" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.AutomaticSpeechRecognition,
                "conversational" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.Conversational,
                "depth-estimation" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.DepthEstimation,
                "document-question-answering" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.DocumentQuestionAnswering,
                "feature-extraction" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.FeatureExtraction,
                "fill-mask" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.FillMask,
                "graph-ml" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.GraphMl,
                "image-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageClassification,
                "image-feature-extraction" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageFeatureExtraction,
                "image-segmentation" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageSegmentation,
                "image-text-to-image" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageTextToImage,
                "image-text-to-text" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageTextToText,
                "image-text-to-video" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageTextToVideo,
                "image-to-3d" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageTo3d,
                "image-to-image" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageToImage,
                "image-to-text" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageToText,
                "image-to-video" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ImageToVideo,
                "keypoint-detection" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.KeypointDetection,
                "mask-generation" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.MaskGeneration,
                "multiple-choice" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.MultipleChoice,
                "object-detection" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ObjectDetection,
                "other" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.Other,
                "question-answering" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.QuestionAnswering,
                "reinforcement-learning" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ReinforcementLearning,
                "robotics" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.Robotics,
                "sentence-similarity" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.SentenceSimilarity,
                "summarization" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.Summarization,
                "table-question-answering" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TableQuestionAnswering,
                "table-to-text" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TableToText,
                "tabular-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TabularClassification,
                "tabular-regression" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TabularRegression,
                "tabular-to-text" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TabularToText,
                "text-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextClassification,
                "text-generation" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextGeneration,
                "text-ranking" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextRanking,
                "text-retrieval" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextRetrieval,
                "text-to-3d" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextTo3d,
                "text-to-audio" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextToAudio,
                "text-to-image" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextToImage,
                "text-to-speech" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextToSpeech,
                "text-to-video" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TextToVideo,
                "time-series-forecasting" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TimeSeriesForecasting,
                "token-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.TokenClassification,
                "translation" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.Translation,
                "unconditional-image-generation" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.UnconditionalImageGeneration,
                "video-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.VideoClassification,
                "video-text-to-text" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.VideoTextToText,
                "video-to-video" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.VideoToVideo,
                "visual-document-retrieval" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.VisualDocumentRetrieval,
                "visual-question-answering" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.VisualQuestionAnswering,
                "voice-activity-detection" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.VoiceActivityDetection,
                "zero-shot-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ZeroShotClassification,
                "zero-shot-image-classification" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ZeroShotImageClassification,
                "zero-shot-object-detection" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}