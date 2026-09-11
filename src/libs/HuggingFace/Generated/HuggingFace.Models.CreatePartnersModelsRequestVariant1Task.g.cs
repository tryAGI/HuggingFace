
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreatePartnersModelsRequestVariant1Task
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
    public static class CreatePartnersModelsRequestVariant1TaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePartnersModelsRequestVariant1Task value)
        {
            return value switch
            {
                CreatePartnersModelsRequestVariant1Task.AnyToAny => "any-to-any",
                CreatePartnersModelsRequestVariant1Task.AudioClassification => "audio-classification",
                CreatePartnersModelsRequestVariant1Task.AudioTextToText => "audio-text-to-text",
                CreatePartnersModelsRequestVariant1Task.AudioToAudio => "audio-to-audio",
                CreatePartnersModelsRequestVariant1Task.AutomaticSpeechRecognition => "automatic-speech-recognition",
                CreatePartnersModelsRequestVariant1Task.Conversational => "conversational",
                CreatePartnersModelsRequestVariant1Task.DepthEstimation => "depth-estimation",
                CreatePartnersModelsRequestVariant1Task.DocumentQuestionAnswering => "document-question-answering",
                CreatePartnersModelsRequestVariant1Task.FeatureExtraction => "feature-extraction",
                CreatePartnersModelsRequestVariant1Task.FillMask => "fill-mask",
                CreatePartnersModelsRequestVariant1Task.GraphMl => "graph-ml",
                CreatePartnersModelsRequestVariant1Task.ImageClassification => "image-classification",
                CreatePartnersModelsRequestVariant1Task.ImageFeatureExtraction => "image-feature-extraction",
                CreatePartnersModelsRequestVariant1Task.ImageSegmentation => "image-segmentation",
                CreatePartnersModelsRequestVariant1Task.ImageTextToImage => "image-text-to-image",
                CreatePartnersModelsRequestVariant1Task.ImageTextToText => "image-text-to-text",
                CreatePartnersModelsRequestVariant1Task.ImageTextToVideo => "image-text-to-video",
                CreatePartnersModelsRequestVariant1Task.ImageTo3d => "image-to-3d",
                CreatePartnersModelsRequestVariant1Task.ImageToImage => "image-to-image",
                CreatePartnersModelsRequestVariant1Task.ImageToText => "image-to-text",
                CreatePartnersModelsRequestVariant1Task.ImageToVideo => "image-to-video",
                CreatePartnersModelsRequestVariant1Task.KeypointDetection => "keypoint-detection",
                CreatePartnersModelsRequestVariant1Task.MaskGeneration => "mask-generation",
                CreatePartnersModelsRequestVariant1Task.MultipleChoice => "multiple-choice",
                CreatePartnersModelsRequestVariant1Task.ObjectDetection => "object-detection",
                CreatePartnersModelsRequestVariant1Task.QuestionAnswering => "question-answering",
                CreatePartnersModelsRequestVariant1Task.ReinforcementLearning => "reinforcement-learning",
                CreatePartnersModelsRequestVariant1Task.Robotics => "robotics",
                CreatePartnersModelsRequestVariant1Task.SentenceSimilarity => "sentence-similarity",
                CreatePartnersModelsRequestVariant1Task.Summarization => "summarization",
                CreatePartnersModelsRequestVariant1Task.TableQuestionAnswering => "table-question-answering",
                CreatePartnersModelsRequestVariant1Task.TableToText => "table-to-text",
                CreatePartnersModelsRequestVariant1Task.TabularClassification => "tabular-classification",
                CreatePartnersModelsRequestVariant1Task.TabularRegression => "tabular-regression",
                CreatePartnersModelsRequestVariant1Task.TabularToText => "tabular-to-text",
                CreatePartnersModelsRequestVariant1Task.TextClassification => "text-classification",
                CreatePartnersModelsRequestVariant1Task.TextGeneration => "text-generation",
                CreatePartnersModelsRequestVariant1Task.TextRanking => "text-ranking",
                CreatePartnersModelsRequestVariant1Task.TextRetrieval => "text-retrieval",
                CreatePartnersModelsRequestVariant1Task.TextTo3d => "text-to-3d",
                CreatePartnersModelsRequestVariant1Task.TextToAudio => "text-to-audio",
                CreatePartnersModelsRequestVariant1Task.TextToImage => "text-to-image",
                CreatePartnersModelsRequestVariant1Task.TextToSpeech => "text-to-speech",
                CreatePartnersModelsRequestVariant1Task.TextToVideo => "text-to-video",
                CreatePartnersModelsRequestVariant1Task.TimeSeriesForecasting => "time-series-forecasting",
                CreatePartnersModelsRequestVariant1Task.TokenClassification => "token-classification",
                CreatePartnersModelsRequestVariant1Task.Translation => "translation",
                CreatePartnersModelsRequestVariant1Task.UnconditionalImageGeneration => "unconditional-image-generation",
                CreatePartnersModelsRequestVariant1Task.VideoClassification => "video-classification",
                CreatePartnersModelsRequestVariant1Task.VideoTextToText => "video-text-to-text",
                CreatePartnersModelsRequestVariant1Task.VideoToVideo => "video-to-video",
                CreatePartnersModelsRequestVariant1Task.VisualDocumentRetrieval => "visual-document-retrieval",
                CreatePartnersModelsRequestVariant1Task.VisualQuestionAnswering => "visual-question-answering",
                CreatePartnersModelsRequestVariant1Task.VoiceActivityDetection => "voice-activity-detection",
                CreatePartnersModelsRequestVariant1Task.ZeroShotClassification => "zero-shot-classification",
                CreatePartnersModelsRequestVariant1Task.ZeroShotImageClassification => "zero-shot-image-classification",
                CreatePartnersModelsRequestVariant1Task.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePartnersModelsRequestVariant1Task? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => CreatePartnersModelsRequestVariant1Task.AnyToAny,
                "audio-classification" => CreatePartnersModelsRequestVariant1Task.AudioClassification,
                "audio-text-to-text" => CreatePartnersModelsRequestVariant1Task.AudioTextToText,
                "audio-to-audio" => CreatePartnersModelsRequestVariant1Task.AudioToAudio,
                "automatic-speech-recognition" => CreatePartnersModelsRequestVariant1Task.AutomaticSpeechRecognition,
                "conversational" => CreatePartnersModelsRequestVariant1Task.Conversational,
                "depth-estimation" => CreatePartnersModelsRequestVariant1Task.DepthEstimation,
                "document-question-answering" => CreatePartnersModelsRequestVariant1Task.DocumentQuestionAnswering,
                "feature-extraction" => CreatePartnersModelsRequestVariant1Task.FeatureExtraction,
                "fill-mask" => CreatePartnersModelsRequestVariant1Task.FillMask,
                "graph-ml" => CreatePartnersModelsRequestVariant1Task.GraphMl,
                "image-classification" => CreatePartnersModelsRequestVariant1Task.ImageClassification,
                "image-feature-extraction" => CreatePartnersModelsRequestVariant1Task.ImageFeatureExtraction,
                "image-segmentation" => CreatePartnersModelsRequestVariant1Task.ImageSegmentation,
                "image-text-to-image" => CreatePartnersModelsRequestVariant1Task.ImageTextToImage,
                "image-text-to-text" => CreatePartnersModelsRequestVariant1Task.ImageTextToText,
                "image-text-to-video" => CreatePartnersModelsRequestVariant1Task.ImageTextToVideo,
                "image-to-3d" => CreatePartnersModelsRequestVariant1Task.ImageTo3d,
                "image-to-image" => CreatePartnersModelsRequestVariant1Task.ImageToImage,
                "image-to-text" => CreatePartnersModelsRequestVariant1Task.ImageToText,
                "image-to-video" => CreatePartnersModelsRequestVariant1Task.ImageToVideo,
                "keypoint-detection" => CreatePartnersModelsRequestVariant1Task.KeypointDetection,
                "mask-generation" => CreatePartnersModelsRequestVariant1Task.MaskGeneration,
                "multiple-choice" => CreatePartnersModelsRequestVariant1Task.MultipleChoice,
                "object-detection" => CreatePartnersModelsRequestVariant1Task.ObjectDetection,
                "question-answering" => CreatePartnersModelsRequestVariant1Task.QuestionAnswering,
                "reinforcement-learning" => CreatePartnersModelsRequestVariant1Task.ReinforcementLearning,
                "robotics" => CreatePartnersModelsRequestVariant1Task.Robotics,
                "sentence-similarity" => CreatePartnersModelsRequestVariant1Task.SentenceSimilarity,
                "summarization" => CreatePartnersModelsRequestVariant1Task.Summarization,
                "table-question-answering" => CreatePartnersModelsRequestVariant1Task.TableQuestionAnswering,
                "table-to-text" => CreatePartnersModelsRequestVariant1Task.TableToText,
                "tabular-classification" => CreatePartnersModelsRequestVariant1Task.TabularClassification,
                "tabular-regression" => CreatePartnersModelsRequestVariant1Task.TabularRegression,
                "tabular-to-text" => CreatePartnersModelsRequestVariant1Task.TabularToText,
                "text-classification" => CreatePartnersModelsRequestVariant1Task.TextClassification,
                "text-generation" => CreatePartnersModelsRequestVariant1Task.TextGeneration,
                "text-ranking" => CreatePartnersModelsRequestVariant1Task.TextRanking,
                "text-retrieval" => CreatePartnersModelsRequestVariant1Task.TextRetrieval,
                "text-to-3d" => CreatePartnersModelsRequestVariant1Task.TextTo3d,
                "text-to-audio" => CreatePartnersModelsRequestVariant1Task.TextToAudio,
                "text-to-image" => CreatePartnersModelsRequestVariant1Task.TextToImage,
                "text-to-speech" => CreatePartnersModelsRequestVariant1Task.TextToSpeech,
                "text-to-video" => CreatePartnersModelsRequestVariant1Task.TextToVideo,
                "time-series-forecasting" => CreatePartnersModelsRequestVariant1Task.TimeSeriesForecasting,
                "token-classification" => CreatePartnersModelsRequestVariant1Task.TokenClassification,
                "translation" => CreatePartnersModelsRequestVariant1Task.Translation,
                "unconditional-image-generation" => CreatePartnersModelsRequestVariant1Task.UnconditionalImageGeneration,
                "video-classification" => CreatePartnersModelsRequestVariant1Task.VideoClassification,
                "video-text-to-text" => CreatePartnersModelsRequestVariant1Task.VideoTextToText,
                "video-to-video" => CreatePartnersModelsRequestVariant1Task.VideoToVideo,
                "visual-document-retrieval" => CreatePartnersModelsRequestVariant1Task.VisualDocumentRetrieval,
                "visual-question-answering" => CreatePartnersModelsRequestVariant1Task.VisualQuestionAnswering,
                "voice-activity-detection" => CreatePartnersModelsRequestVariant1Task.VoiceActivityDetection,
                "zero-shot-classification" => CreatePartnersModelsRequestVariant1Task.ZeroShotClassification,
                "zero-shot-image-classification" => CreatePartnersModelsRequestVariant1Task.ZeroShotImageClassification,
                "zero-shot-object-detection" => CreatePartnersModelsRequestVariant1Task.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}