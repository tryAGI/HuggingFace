
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQuicksearchPipelinesVariant1Item
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
    public static class CreateQuicksearchPipelinesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchPipelinesVariant1Item value)
        {
            return value switch
            {
                CreateQuicksearchPipelinesVariant1Item.AnyToAny => "any-to-any",
                CreateQuicksearchPipelinesVariant1Item.AudioClassification => "audio-classification",
                CreateQuicksearchPipelinesVariant1Item.AudioTextToText => "audio-text-to-text",
                CreateQuicksearchPipelinesVariant1Item.AudioToAudio => "audio-to-audio",
                CreateQuicksearchPipelinesVariant1Item.AutomaticSpeechRecognition => "automatic-speech-recognition",
                CreateQuicksearchPipelinesVariant1Item.DepthEstimation => "depth-estimation",
                CreateQuicksearchPipelinesVariant1Item.DocumentQuestionAnswering => "document-question-answering",
                CreateQuicksearchPipelinesVariant1Item.FeatureExtraction => "feature-extraction",
                CreateQuicksearchPipelinesVariant1Item.FillMask => "fill-mask",
                CreateQuicksearchPipelinesVariant1Item.GraphMl => "graph-ml",
                CreateQuicksearchPipelinesVariant1Item.ImageClassification => "image-classification",
                CreateQuicksearchPipelinesVariant1Item.ImageFeatureExtraction => "image-feature-extraction",
                CreateQuicksearchPipelinesVariant1Item.ImageSegmentation => "image-segmentation",
                CreateQuicksearchPipelinesVariant1Item.ImageTextToImage => "image-text-to-image",
                CreateQuicksearchPipelinesVariant1Item.ImageTextToText => "image-text-to-text",
                CreateQuicksearchPipelinesVariant1Item.ImageTextToVideo => "image-text-to-video",
                CreateQuicksearchPipelinesVariant1Item.ImageTo3d => "image-to-3d",
                CreateQuicksearchPipelinesVariant1Item.ImageToImage => "image-to-image",
                CreateQuicksearchPipelinesVariant1Item.ImageToText => "image-to-text",
                CreateQuicksearchPipelinesVariant1Item.ImageToVideo => "image-to-video",
                CreateQuicksearchPipelinesVariant1Item.KeypointDetection => "keypoint-detection",
                CreateQuicksearchPipelinesVariant1Item.MaskGeneration => "mask-generation",
                CreateQuicksearchPipelinesVariant1Item.MultipleChoice => "multiple-choice",
                CreateQuicksearchPipelinesVariant1Item.ObjectDetection => "object-detection",
                CreateQuicksearchPipelinesVariant1Item.Other => "other",
                CreateQuicksearchPipelinesVariant1Item.QuestionAnswering => "question-answering",
                CreateQuicksearchPipelinesVariant1Item.ReinforcementLearning => "reinforcement-learning",
                CreateQuicksearchPipelinesVariant1Item.Robotics => "robotics",
                CreateQuicksearchPipelinesVariant1Item.SentenceSimilarity => "sentence-similarity",
                CreateQuicksearchPipelinesVariant1Item.Summarization => "summarization",
                CreateQuicksearchPipelinesVariant1Item.TableQuestionAnswering => "table-question-answering",
                CreateQuicksearchPipelinesVariant1Item.TableToText => "table-to-text",
                CreateQuicksearchPipelinesVariant1Item.TabularClassification => "tabular-classification",
                CreateQuicksearchPipelinesVariant1Item.TabularRegression => "tabular-regression",
                CreateQuicksearchPipelinesVariant1Item.TabularToText => "tabular-to-text",
                CreateQuicksearchPipelinesVariant1Item.TextClassification => "text-classification",
                CreateQuicksearchPipelinesVariant1Item.TextGeneration => "text-generation",
                CreateQuicksearchPipelinesVariant1Item.TextRanking => "text-ranking",
                CreateQuicksearchPipelinesVariant1Item.TextRetrieval => "text-retrieval",
                CreateQuicksearchPipelinesVariant1Item.TextTo3d => "text-to-3d",
                CreateQuicksearchPipelinesVariant1Item.TextToAudio => "text-to-audio",
                CreateQuicksearchPipelinesVariant1Item.TextToImage => "text-to-image",
                CreateQuicksearchPipelinesVariant1Item.TextToSpeech => "text-to-speech",
                CreateQuicksearchPipelinesVariant1Item.TextToVideo => "text-to-video",
                CreateQuicksearchPipelinesVariant1Item.TimeSeriesForecasting => "time-series-forecasting",
                CreateQuicksearchPipelinesVariant1Item.TokenClassification => "token-classification",
                CreateQuicksearchPipelinesVariant1Item.Translation => "translation",
                CreateQuicksearchPipelinesVariant1Item.UnconditionalImageGeneration => "unconditional-image-generation",
                CreateQuicksearchPipelinesVariant1Item.VideoClassification => "video-classification",
                CreateQuicksearchPipelinesVariant1Item.VideoTextToText => "video-text-to-text",
                CreateQuicksearchPipelinesVariant1Item.VideoToVideo => "video-to-video",
                CreateQuicksearchPipelinesVariant1Item.VisualDocumentRetrieval => "visual-document-retrieval",
                CreateQuicksearchPipelinesVariant1Item.VisualQuestionAnswering => "visual-question-answering",
                CreateQuicksearchPipelinesVariant1Item.VoiceActivityDetection => "voice-activity-detection",
                CreateQuicksearchPipelinesVariant1Item.ZeroShotClassification => "zero-shot-classification",
                CreateQuicksearchPipelinesVariant1Item.ZeroShotImageClassification => "zero-shot-image-classification",
                CreateQuicksearchPipelinesVariant1Item.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchPipelinesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => CreateQuicksearchPipelinesVariant1Item.AnyToAny,
                "audio-classification" => CreateQuicksearchPipelinesVariant1Item.AudioClassification,
                "audio-text-to-text" => CreateQuicksearchPipelinesVariant1Item.AudioTextToText,
                "audio-to-audio" => CreateQuicksearchPipelinesVariant1Item.AudioToAudio,
                "automatic-speech-recognition" => CreateQuicksearchPipelinesVariant1Item.AutomaticSpeechRecognition,
                "depth-estimation" => CreateQuicksearchPipelinesVariant1Item.DepthEstimation,
                "document-question-answering" => CreateQuicksearchPipelinesVariant1Item.DocumentQuestionAnswering,
                "feature-extraction" => CreateQuicksearchPipelinesVariant1Item.FeatureExtraction,
                "fill-mask" => CreateQuicksearchPipelinesVariant1Item.FillMask,
                "graph-ml" => CreateQuicksearchPipelinesVariant1Item.GraphMl,
                "image-classification" => CreateQuicksearchPipelinesVariant1Item.ImageClassification,
                "image-feature-extraction" => CreateQuicksearchPipelinesVariant1Item.ImageFeatureExtraction,
                "image-segmentation" => CreateQuicksearchPipelinesVariant1Item.ImageSegmentation,
                "image-text-to-image" => CreateQuicksearchPipelinesVariant1Item.ImageTextToImage,
                "image-text-to-text" => CreateQuicksearchPipelinesVariant1Item.ImageTextToText,
                "image-text-to-video" => CreateQuicksearchPipelinesVariant1Item.ImageTextToVideo,
                "image-to-3d" => CreateQuicksearchPipelinesVariant1Item.ImageTo3d,
                "image-to-image" => CreateQuicksearchPipelinesVariant1Item.ImageToImage,
                "image-to-text" => CreateQuicksearchPipelinesVariant1Item.ImageToText,
                "image-to-video" => CreateQuicksearchPipelinesVariant1Item.ImageToVideo,
                "keypoint-detection" => CreateQuicksearchPipelinesVariant1Item.KeypointDetection,
                "mask-generation" => CreateQuicksearchPipelinesVariant1Item.MaskGeneration,
                "multiple-choice" => CreateQuicksearchPipelinesVariant1Item.MultipleChoice,
                "object-detection" => CreateQuicksearchPipelinesVariant1Item.ObjectDetection,
                "other" => CreateQuicksearchPipelinesVariant1Item.Other,
                "question-answering" => CreateQuicksearchPipelinesVariant1Item.QuestionAnswering,
                "reinforcement-learning" => CreateQuicksearchPipelinesVariant1Item.ReinforcementLearning,
                "robotics" => CreateQuicksearchPipelinesVariant1Item.Robotics,
                "sentence-similarity" => CreateQuicksearchPipelinesVariant1Item.SentenceSimilarity,
                "summarization" => CreateQuicksearchPipelinesVariant1Item.Summarization,
                "table-question-answering" => CreateQuicksearchPipelinesVariant1Item.TableQuestionAnswering,
                "table-to-text" => CreateQuicksearchPipelinesVariant1Item.TableToText,
                "tabular-classification" => CreateQuicksearchPipelinesVariant1Item.TabularClassification,
                "tabular-regression" => CreateQuicksearchPipelinesVariant1Item.TabularRegression,
                "tabular-to-text" => CreateQuicksearchPipelinesVariant1Item.TabularToText,
                "text-classification" => CreateQuicksearchPipelinesVariant1Item.TextClassification,
                "text-generation" => CreateQuicksearchPipelinesVariant1Item.TextGeneration,
                "text-ranking" => CreateQuicksearchPipelinesVariant1Item.TextRanking,
                "text-retrieval" => CreateQuicksearchPipelinesVariant1Item.TextRetrieval,
                "text-to-3d" => CreateQuicksearchPipelinesVariant1Item.TextTo3d,
                "text-to-audio" => CreateQuicksearchPipelinesVariant1Item.TextToAudio,
                "text-to-image" => CreateQuicksearchPipelinesVariant1Item.TextToImage,
                "text-to-speech" => CreateQuicksearchPipelinesVariant1Item.TextToSpeech,
                "text-to-video" => CreateQuicksearchPipelinesVariant1Item.TextToVideo,
                "time-series-forecasting" => CreateQuicksearchPipelinesVariant1Item.TimeSeriesForecasting,
                "token-classification" => CreateQuicksearchPipelinesVariant1Item.TokenClassification,
                "translation" => CreateQuicksearchPipelinesVariant1Item.Translation,
                "unconditional-image-generation" => CreateQuicksearchPipelinesVariant1Item.UnconditionalImageGeneration,
                "video-classification" => CreateQuicksearchPipelinesVariant1Item.VideoClassification,
                "video-text-to-text" => CreateQuicksearchPipelinesVariant1Item.VideoTextToText,
                "video-to-video" => CreateQuicksearchPipelinesVariant1Item.VideoToVideo,
                "visual-document-retrieval" => CreateQuicksearchPipelinesVariant1Item.VisualDocumentRetrieval,
                "visual-question-answering" => CreateQuicksearchPipelinesVariant1Item.VisualQuestionAnswering,
                "voice-activity-detection" => CreateQuicksearchPipelinesVariant1Item.VoiceActivityDetection,
                "zero-shot-classification" => CreateQuicksearchPipelinesVariant1Item.ZeroShotClassification,
                "zero-shot-image-classification" => CreateQuicksearchPipelinesVariant1Item.ZeroShotImageClassification,
                "zero-shot-object-detection" => CreateQuicksearchPipelinesVariant1Item.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}