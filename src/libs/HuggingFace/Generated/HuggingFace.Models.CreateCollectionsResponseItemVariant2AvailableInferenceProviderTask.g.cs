
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask
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
    public static class CreateCollectionsResponseItemVariant2AvailableInferenceProviderTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.AnyToAny => "any-to-any",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.AudioClassification => "audio-classification",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.AudioTextToText => "audio-text-to-text",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.AudioToAudio => "audio-to-audio",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition => "automatic-speech-recognition",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.Conversational => "conversational",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.DepthEstimation => "depth-estimation",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering => "document-question-answering",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.FeatureExtraction => "feature-extraction",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.FillMask => "fill-mask",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.GraphMl => "graph-ml",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageClassification => "image-classification",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction => "image-feature-extraction",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageSegmentation => "image-segmentation",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToImage => "image-text-to-image",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToText => "image-text-to-text",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToVideo => "image-text-to-video",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTo3d => "image-to-3d",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageToImage => "image-to-image",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageToText => "image-to-text",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageToVideo => "image-to-video",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.KeypointDetection => "keypoint-detection",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.MaskGeneration => "mask-generation",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.MultipleChoice => "multiple-choice",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ObjectDetection => "object-detection",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.Other => "other",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.QuestionAnswering => "question-answering",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ReinforcementLearning => "reinforcement-learning",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.Robotics => "robotics",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.SentenceSimilarity => "sentence-similarity",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.Summarization => "summarization",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering => "table-question-answering",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TableToText => "table-to-text",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TabularClassification => "tabular-classification",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TabularRegression => "tabular-regression",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TabularToText => "tabular-to-text",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextClassification => "text-classification",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextGeneration => "text-generation",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextRanking => "text-ranking",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextRetrieval => "text-retrieval",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextTo3d => "text-to-3d",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToAudio => "text-to-audio",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToImage => "text-to-image",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToSpeech => "text-to-speech",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToVideo => "text-to-video",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting => "time-series-forecasting",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TokenClassification => "token-classification",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.Translation => "translation",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration => "unconditional-image-generation",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.VideoClassification => "video-classification",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.VideoTextToText => "video-text-to-text",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.VideoToVideo => "video-to-video",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval => "visual-document-retrieval",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering => "visual-question-answering",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection => "voice-activity-detection",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotClassification => "zero-shot-classification",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification => "zero-shot-image-classification",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.AnyToAny,
                "audio-classification" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.AudioClassification,
                "audio-text-to-text" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.AudioTextToText,
                "audio-to-audio" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.AudioToAudio,
                "automatic-speech-recognition" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.AutomaticSpeechRecognition,
                "conversational" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.Conversational,
                "depth-estimation" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.DepthEstimation,
                "document-question-answering" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.DocumentQuestionAnswering,
                "feature-extraction" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.FeatureExtraction,
                "fill-mask" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.FillMask,
                "graph-ml" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.GraphMl,
                "image-classification" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageClassification,
                "image-feature-extraction" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageFeatureExtraction,
                "image-segmentation" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageSegmentation,
                "image-text-to-image" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToImage,
                "image-text-to-text" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToText,
                "image-text-to-video" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTextToVideo,
                "image-to-3d" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageTo3d,
                "image-to-image" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageToImage,
                "image-to-text" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageToText,
                "image-to-video" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ImageToVideo,
                "keypoint-detection" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.KeypointDetection,
                "mask-generation" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.MaskGeneration,
                "multiple-choice" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.MultipleChoice,
                "object-detection" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ObjectDetection,
                "other" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.Other,
                "question-answering" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.QuestionAnswering,
                "reinforcement-learning" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ReinforcementLearning,
                "robotics" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.Robotics,
                "sentence-similarity" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.SentenceSimilarity,
                "summarization" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.Summarization,
                "table-question-answering" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TableQuestionAnswering,
                "table-to-text" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TableToText,
                "tabular-classification" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TabularClassification,
                "tabular-regression" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TabularRegression,
                "tabular-to-text" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TabularToText,
                "text-classification" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextClassification,
                "text-generation" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextGeneration,
                "text-ranking" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextRanking,
                "text-retrieval" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextRetrieval,
                "text-to-3d" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextTo3d,
                "text-to-audio" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToAudio,
                "text-to-image" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToImage,
                "text-to-speech" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToSpeech,
                "text-to-video" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TextToVideo,
                "time-series-forecasting" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TimeSeriesForecasting,
                "token-classification" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.TokenClassification,
                "translation" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.Translation,
                "unconditional-image-generation" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.UnconditionalImageGeneration,
                "video-classification" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.VideoClassification,
                "video-text-to-text" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.VideoTextToText,
                "video-to-video" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.VideoToVideo,
                "visual-document-retrieval" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.VisualDocumentRetrieval,
                "visual-question-answering" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.VisualQuestionAnswering,
                "voice-activity-detection" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.VoiceActivityDetection,
                "zero-shot-classification" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotClassification,
                "zero-shot-image-classification" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotImageClassification,
                "zero-shot-object-detection" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}