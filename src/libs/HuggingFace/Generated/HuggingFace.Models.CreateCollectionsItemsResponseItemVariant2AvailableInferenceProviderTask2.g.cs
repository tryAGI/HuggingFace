
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2
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
    public static class CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.AnyToAny => "any-to-any",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.AudioClassification => "audio-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.AudioTextToText => "audio-text-to-text",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.AudioToAudio => "audio-to-audio",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.AutomaticSpeechRecognition => "automatic-speech-recognition",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.Conversational => "conversational",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.DepthEstimation => "depth-estimation",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.DocumentQuestionAnswering => "document-question-answering",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.FeatureExtraction => "feature-extraction",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.FillMask => "fill-mask",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.GraphMl => "graph-ml",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageClassification => "image-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageFeatureExtraction => "image-feature-extraction",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageSegmentation => "image-segmentation",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToImage => "image-text-to-image",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToText => "image-text-to-text",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToVideo => "image-text-to-video",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageTo3d => "image-to-3d",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageToImage => "image-to-image",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageToText => "image-to-text",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageToVideo => "image-to-video",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.KeypointDetection => "keypoint-detection",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.MaskGeneration => "mask-generation",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.MultipleChoice => "multiple-choice",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ObjectDetection => "object-detection",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.Other => "other",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.QuestionAnswering => "question-answering",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ReinforcementLearning => "reinforcement-learning",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.Robotics => "robotics",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.SentenceSimilarity => "sentence-similarity",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.Summarization => "summarization",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TableQuestionAnswering => "table-question-answering",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TableToText => "table-to-text",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TabularClassification => "tabular-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TabularRegression => "tabular-regression",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TabularToText => "tabular-to-text",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextClassification => "text-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextGeneration => "text-generation",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextRanking => "text-ranking",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextRetrieval => "text-retrieval",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextTo3d => "text-to-3d",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextToAudio => "text-to-audio",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextToImage => "text-to-image",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextToSpeech => "text-to-speech",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextToVideo => "text-to-video",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TimeSeriesForecasting => "time-series-forecasting",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TokenClassification => "token-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.Translation => "translation",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.UnconditionalImageGeneration => "unconditional-image-generation",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.VideoClassification => "video-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.VideoTextToText => "video-text-to-text",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.VideoToVideo => "video-to-video",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.VisualDocumentRetrieval => "visual-document-retrieval",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.VisualQuestionAnswering => "visual-question-answering",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.VoiceActivityDetection => "voice-activity-detection",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotClassification => "zero-shot-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotImageClassification => "zero-shot-image-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.AnyToAny,
                "audio-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.AudioClassification,
                "audio-text-to-text" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.AudioTextToText,
                "audio-to-audio" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.AudioToAudio,
                "automatic-speech-recognition" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.AutomaticSpeechRecognition,
                "conversational" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.Conversational,
                "depth-estimation" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.DepthEstimation,
                "document-question-answering" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.DocumentQuestionAnswering,
                "feature-extraction" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.FeatureExtraction,
                "fill-mask" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.FillMask,
                "graph-ml" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.GraphMl,
                "image-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageClassification,
                "image-feature-extraction" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageFeatureExtraction,
                "image-segmentation" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageSegmentation,
                "image-text-to-image" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToImage,
                "image-text-to-text" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToText,
                "image-text-to-video" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageTextToVideo,
                "image-to-3d" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageTo3d,
                "image-to-image" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageToImage,
                "image-to-text" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageToText,
                "image-to-video" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ImageToVideo,
                "keypoint-detection" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.KeypointDetection,
                "mask-generation" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.MaskGeneration,
                "multiple-choice" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.MultipleChoice,
                "object-detection" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ObjectDetection,
                "other" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.Other,
                "question-answering" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.QuestionAnswering,
                "reinforcement-learning" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ReinforcementLearning,
                "robotics" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.Robotics,
                "sentence-similarity" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.SentenceSimilarity,
                "summarization" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.Summarization,
                "table-question-answering" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TableQuestionAnswering,
                "table-to-text" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TableToText,
                "tabular-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TabularClassification,
                "tabular-regression" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TabularRegression,
                "tabular-to-text" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TabularToText,
                "text-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextClassification,
                "text-generation" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextGeneration,
                "text-ranking" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextRanking,
                "text-retrieval" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextRetrieval,
                "text-to-3d" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextTo3d,
                "text-to-audio" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextToAudio,
                "text-to-image" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextToImage,
                "text-to-speech" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextToSpeech,
                "text-to-video" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TextToVideo,
                "time-series-forecasting" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TimeSeriesForecasting,
                "token-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.TokenClassification,
                "translation" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.Translation,
                "unconditional-image-generation" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.UnconditionalImageGeneration,
                "video-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.VideoClassification,
                "video-text-to-text" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.VideoTextToText,
                "video-to-video" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.VideoToVideo,
                "visual-document-retrieval" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.VisualDocumentRetrieval,
                "visual-question-answering" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.VisualQuestionAnswering,
                "voice-activity-detection" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.VoiceActivityDetection,
                "zero-shot-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotClassification,
                "zero-shot-image-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotImageClassification,
                "zero-shot-object-detection" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}