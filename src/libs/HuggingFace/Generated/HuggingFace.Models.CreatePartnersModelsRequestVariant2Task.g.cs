
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreatePartnersModelsRequestVariant2Task
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
    public static class CreatePartnersModelsRequestVariant2TaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePartnersModelsRequestVariant2Task value)
        {
            return value switch
            {
                CreatePartnersModelsRequestVariant2Task.AnyToAny => "any-to-any",
                CreatePartnersModelsRequestVariant2Task.AudioClassification => "audio-classification",
                CreatePartnersModelsRequestVariant2Task.AudioTextToText => "audio-text-to-text",
                CreatePartnersModelsRequestVariant2Task.AudioToAudio => "audio-to-audio",
                CreatePartnersModelsRequestVariant2Task.AutomaticSpeechRecognition => "automatic-speech-recognition",
                CreatePartnersModelsRequestVariant2Task.Conversational => "conversational",
                CreatePartnersModelsRequestVariant2Task.DepthEstimation => "depth-estimation",
                CreatePartnersModelsRequestVariant2Task.DocumentQuestionAnswering => "document-question-answering",
                CreatePartnersModelsRequestVariant2Task.FeatureExtraction => "feature-extraction",
                CreatePartnersModelsRequestVariant2Task.FillMask => "fill-mask",
                CreatePartnersModelsRequestVariant2Task.GraphMl => "graph-ml",
                CreatePartnersModelsRequestVariant2Task.ImageClassification => "image-classification",
                CreatePartnersModelsRequestVariant2Task.ImageFeatureExtraction => "image-feature-extraction",
                CreatePartnersModelsRequestVariant2Task.ImageSegmentation => "image-segmentation",
                CreatePartnersModelsRequestVariant2Task.ImageTextToImage => "image-text-to-image",
                CreatePartnersModelsRequestVariant2Task.ImageTextToText => "image-text-to-text",
                CreatePartnersModelsRequestVariant2Task.ImageTextToVideo => "image-text-to-video",
                CreatePartnersModelsRequestVariant2Task.ImageTo3d => "image-to-3d",
                CreatePartnersModelsRequestVariant2Task.ImageToImage => "image-to-image",
                CreatePartnersModelsRequestVariant2Task.ImageToText => "image-to-text",
                CreatePartnersModelsRequestVariant2Task.ImageToVideo => "image-to-video",
                CreatePartnersModelsRequestVariant2Task.KeypointDetection => "keypoint-detection",
                CreatePartnersModelsRequestVariant2Task.MaskGeneration => "mask-generation",
                CreatePartnersModelsRequestVariant2Task.MultipleChoice => "multiple-choice",
                CreatePartnersModelsRequestVariant2Task.ObjectDetection => "object-detection",
                CreatePartnersModelsRequestVariant2Task.QuestionAnswering => "question-answering",
                CreatePartnersModelsRequestVariant2Task.ReinforcementLearning => "reinforcement-learning",
                CreatePartnersModelsRequestVariant2Task.Robotics => "robotics",
                CreatePartnersModelsRequestVariant2Task.SentenceSimilarity => "sentence-similarity",
                CreatePartnersModelsRequestVariant2Task.Summarization => "summarization",
                CreatePartnersModelsRequestVariant2Task.TableQuestionAnswering => "table-question-answering",
                CreatePartnersModelsRequestVariant2Task.TableToText => "table-to-text",
                CreatePartnersModelsRequestVariant2Task.TabularClassification => "tabular-classification",
                CreatePartnersModelsRequestVariant2Task.TabularRegression => "tabular-regression",
                CreatePartnersModelsRequestVariant2Task.TabularToText => "tabular-to-text",
                CreatePartnersModelsRequestVariant2Task.TextClassification => "text-classification",
                CreatePartnersModelsRequestVariant2Task.TextGeneration => "text-generation",
                CreatePartnersModelsRequestVariant2Task.TextRanking => "text-ranking",
                CreatePartnersModelsRequestVariant2Task.TextRetrieval => "text-retrieval",
                CreatePartnersModelsRequestVariant2Task.TextTo3d => "text-to-3d",
                CreatePartnersModelsRequestVariant2Task.TextToAudio => "text-to-audio",
                CreatePartnersModelsRequestVariant2Task.TextToImage => "text-to-image",
                CreatePartnersModelsRequestVariant2Task.TextToSpeech => "text-to-speech",
                CreatePartnersModelsRequestVariant2Task.TextToVideo => "text-to-video",
                CreatePartnersModelsRequestVariant2Task.TimeSeriesForecasting => "time-series-forecasting",
                CreatePartnersModelsRequestVariant2Task.TokenClassification => "token-classification",
                CreatePartnersModelsRequestVariant2Task.Translation => "translation",
                CreatePartnersModelsRequestVariant2Task.UnconditionalImageGeneration => "unconditional-image-generation",
                CreatePartnersModelsRequestVariant2Task.VideoClassification => "video-classification",
                CreatePartnersModelsRequestVariant2Task.VideoTextToText => "video-text-to-text",
                CreatePartnersModelsRequestVariant2Task.VideoToVideo => "video-to-video",
                CreatePartnersModelsRequestVariant2Task.VisualDocumentRetrieval => "visual-document-retrieval",
                CreatePartnersModelsRequestVariant2Task.VisualQuestionAnswering => "visual-question-answering",
                CreatePartnersModelsRequestVariant2Task.VoiceActivityDetection => "voice-activity-detection",
                CreatePartnersModelsRequestVariant2Task.ZeroShotClassification => "zero-shot-classification",
                CreatePartnersModelsRequestVariant2Task.ZeroShotImageClassification => "zero-shot-image-classification",
                CreatePartnersModelsRequestVariant2Task.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePartnersModelsRequestVariant2Task? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => CreatePartnersModelsRequestVariant2Task.AnyToAny,
                "audio-classification" => CreatePartnersModelsRequestVariant2Task.AudioClassification,
                "audio-text-to-text" => CreatePartnersModelsRequestVariant2Task.AudioTextToText,
                "audio-to-audio" => CreatePartnersModelsRequestVariant2Task.AudioToAudio,
                "automatic-speech-recognition" => CreatePartnersModelsRequestVariant2Task.AutomaticSpeechRecognition,
                "conversational" => CreatePartnersModelsRequestVariant2Task.Conversational,
                "depth-estimation" => CreatePartnersModelsRequestVariant2Task.DepthEstimation,
                "document-question-answering" => CreatePartnersModelsRequestVariant2Task.DocumentQuestionAnswering,
                "feature-extraction" => CreatePartnersModelsRequestVariant2Task.FeatureExtraction,
                "fill-mask" => CreatePartnersModelsRequestVariant2Task.FillMask,
                "graph-ml" => CreatePartnersModelsRequestVariant2Task.GraphMl,
                "image-classification" => CreatePartnersModelsRequestVariant2Task.ImageClassification,
                "image-feature-extraction" => CreatePartnersModelsRequestVariant2Task.ImageFeatureExtraction,
                "image-segmentation" => CreatePartnersModelsRequestVariant2Task.ImageSegmentation,
                "image-text-to-image" => CreatePartnersModelsRequestVariant2Task.ImageTextToImage,
                "image-text-to-text" => CreatePartnersModelsRequestVariant2Task.ImageTextToText,
                "image-text-to-video" => CreatePartnersModelsRequestVariant2Task.ImageTextToVideo,
                "image-to-3d" => CreatePartnersModelsRequestVariant2Task.ImageTo3d,
                "image-to-image" => CreatePartnersModelsRequestVariant2Task.ImageToImage,
                "image-to-text" => CreatePartnersModelsRequestVariant2Task.ImageToText,
                "image-to-video" => CreatePartnersModelsRequestVariant2Task.ImageToVideo,
                "keypoint-detection" => CreatePartnersModelsRequestVariant2Task.KeypointDetection,
                "mask-generation" => CreatePartnersModelsRequestVariant2Task.MaskGeneration,
                "multiple-choice" => CreatePartnersModelsRequestVariant2Task.MultipleChoice,
                "object-detection" => CreatePartnersModelsRequestVariant2Task.ObjectDetection,
                "question-answering" => CreatePartnersModelsRequestVariant2Task.QuestionAnswering,
                "reinforcement-learning" => CreatePartnersModelsRequestVariant2Task.ReinforcementLearning,
                "robotics" => CreatePartnersModelsRequestVariant2Task.Robotics,
                "sentence-similarity" => CreatePartnersModelsRequestVariant2Task.SentenceSimilarity,
                "summarization" => CreatePartnersModelsRequestVariant2Task.Summarization,
                "table-question-answering" => CreatePartnersModelsRequestVariant2Task.TableQuestionAnswering,
                "table-to-text" => CreatePartnersModelsRequestVariant2Task.TableToText,
                "tabular-classification" => CreatePartnersModelsRequestVariant2Task.TabularClassification,
                "tabular-regression" => CreatePartnersModelsRequestVariant2Task.TabularRegression,
                "tabular-to-text" => CreatePartnersModelsRequestVariant2Task.TabularToText,
                "text-classification" => CreatePartnersModelsRequestVariant2Task.TextClassification,
                "text-generation" => CreatePartnersModelsRequestVariant2Task.TextGeneration,
                "text-ranking" => CreatePartnersModelsRequestVariant2Task.TextRanking,
                "text-retrieval" => CreatePartnersModelsRequestVariant2Task.TextRetrieval,
                "text-to-3d" => CreatePartnersModelsRequestVariant2Task.TextTo3d,
                "text-to-audio" => CreatePartnersModelsRequestVariant2Task.TextToAudio,
                "text-to-image" => CreatePartnersModelsRequestVariant2Task.TextToImage,
                "text-to-speech" => CreatePartnersModelsRequestVariant2Task.TextToSpeech,
                "text-to-video" => CreatePartnersModelsRequestVariant2Task.TextToVideo,
                "time-series-forecasting" => CreatePartnersModelsRequestVariant2Task.TimeSeriesForecasting,
                "token-classification" => CreatePartnersModelsRequestVariant2Task.TokenClassification,
                "translation" => CreatePartnersModelsRequestVariant2Task.Translation,
                "unconditional-image-generation" => CreatePartnersModelsRequestVariant2Task.UnconditionalImageGeneration,
                "video-classification" => CreatePartnersModelsRequestVariant2Task.VideoClassification,
                "video-text-to-text" => CreatePartnersModelsRequestVariant2Task.VideoTextToText,
                "video-to-video" => CreatePartnersModelsRequestVariant2Task.VideoToVideo,
                "visual-document-retrieval" => CreatePartnersModelsRequestVariant2Task.VisualDocumentRetrieval,
                "visual-question-answering" => CreatePartnersModelsRequestVariant2Task.VisualQuestionAnswering,
                "voice-activity-detection" => CreatePartnersModelsRequestVariant2Task.VoiceActivityDetection,
                "zero-shot-classification" => CreatePartnersModelsRequestVariant2Task.ZeroShotClassification,
                "zero-shot-image-classification" => CreatePartnersModelsRequestVariant2Task.ZeroShotImageClassification,
                "zero-shot-object-detection" => CreatePartnersModelsRequestVariant2Task.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}