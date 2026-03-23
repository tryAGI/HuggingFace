
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask
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
    public static class CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.AnyToAny => "any-to-any",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.AudioClassification => "audio-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.AudioTextToText => "audio-text-to-text",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.AudioToAudio => "audio-to-audio",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition => "automatic-speech-recognition",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.Conversational => "conversational",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.DepthEstimation => "depth-estimation",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering => "document-question-answering",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.FeatureExtraction => "feature-extraction",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.FillMask => "fill-mask",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.GraphMl => "graph-ml",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageClassification => "image-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction => "image-feature-extraction",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageSegmentation => "image-segmentation",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToImage => "image-text-to-image",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToText => "image-text-to-text",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToVideo => "image-text-to-video",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageTo3d => "image-to-3d",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageToImage => "image-to-image",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageToText => "image-to-text",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageToVideo => "image-to-video",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.KeypointDetection => "keypoint-detection",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.MaskGeneration => "mask-generation",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.MultipleChoice => "multiple-choice",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ObjectDetection => "object-detection",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.Other => "other",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.QuestionAnswering => "question-answering",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ReinforcementLearning => "reinforcement-learning",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.Robotics => "robotics",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.SentenceSimilarity => "sentence-similarity",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.Summarization => "summarization",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering => "table-question-answering",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TableToText => "table-to-text",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TabularClassification => "tabular-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TabularRegression => "tabular-regression",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TabularToText => "tabular-to-text",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextClassification => "text-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextGeneration => "text-generation",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextRanking => "text-ranking",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextRetrieval => "text-retrieval",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextTo3d => "text-to-3d",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextToAudio => "text-to-audio",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextToImage => "text-to-image",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextToSpeech => "text-to-speech",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextToVideo => "text-to-video",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting => "time-series-forecasting",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TokenClassification => "token-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.Translation => "translation",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration => "unconditional-image-generation",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.VideoClassification => "video-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.VideoTextToText => "video-text-to-text",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.VideoToVideo => "video-to-video",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval => "visual-document-retrieval",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering => "visual-question-answering",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection => "voice-activity-detection",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotClassification => "zero-shot-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification => "zero-shot-image-classification",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.AnyToAny,
                "audio-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.AudioClassification,
                "audio-text-to-text" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.AudioTextToText,
                "audio-to-audio" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.AudioToAudio,
                "automatic-speech-recognition" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition,
                "conversational" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.Conversational,
                "depth-estimation" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.DepthEstimation,
                "document-question-answering" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering,
                "feature-extraction" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.FeatureExtraction,
                "fill-mask" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.FillMask,
                "graph-ml" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.GraphMl,
                "image-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageClassification,
                "image-feature-extraction" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction,
                "image-segmentation" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageSegmentation,
                "image-text-to-image" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToImage,
                "image-text-to-text" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToText,
                "image-text-to-video" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToVideo,
                "image-to-3d" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageTo3d,
                "image-to-image" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageToImage,
                "image-to-text" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageToText,
                "image-to-video" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ImageToVideo,
                "keypoint-detection" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.KeypointDetection,
                "mask-generation" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.MaskGeneration,
                "multiple-choice" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.MultipleChoice,
                "object-detection" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ObjectDetection,
                "other" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.Other,
                "question-answering" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.QuestionAnswering,
                "reinforcement-learning" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ReinforcementLearning,
                "robotics" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.Robotics,
                "sentence-similarity" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.SentenceSimilarity,
                "summarization" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.Summarization,
                "table-question-answering" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering,
                "table-to-text" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TableToText,
                "tabular-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TabularClassification,
                "tabular-regression" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TabularRegression,
                "tabular-to-text" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TabularToText,
                "text-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextClassification,
                "text-generation" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextGeneration,
                "text-ranking" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextRanking,
                "text-retrieval" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextRetrieval,
                "text-to-3d" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextTo3d,
                "text-to-audio" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextToAudio,
                "text-to-image" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextToImage,
                "text-to-speech" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextToSpeech,
                "text-to-video" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TextToVideo,
                "time-series-forecasting" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting,
                "token-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.TokenClassification,
                "translation" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.Translation,
                "unconditional-image-generation" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration,
                "video-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.VideoClassification,
                "video-text-to-text" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.VideoTextToText,
                "video-to-video" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.VideoToVideo,
                "visual-document-retrieval" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval,
                "visual-question-answering" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering,
                "voice-activity-detection" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection,
                "zero-shot-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotClassification,
                "zero-shot-image-classification" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification,
                "zero-shot-object-detection" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}