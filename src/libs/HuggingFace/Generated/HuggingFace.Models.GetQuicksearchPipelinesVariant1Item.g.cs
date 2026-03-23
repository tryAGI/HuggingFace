
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetQuicksearchPipelinesVariant1Item
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
    public static class GetQuicksearchPipelinesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetQuicksearchPipelinesVariant1Item value)
        {
            return value switch
            {
                GetQuicksearchPipelinesVariant1Item.AnyToAny => "any-to-any",
                GetQuicksearchPipelinesVariant1Item.AudioClassification => "audio-classification",
                GetQuicksearchPipelinesVariant1Item.AudioTextToText => "audio-text-to-text",
                GetQuicksearchPipelinesVariant1Item.AudioToAudio => "audio-to-audio",
                GetQuicksearchPipelinesVariant1Item.AutomaticSpeechRecognition => "automatic-speech-recognition",
                GetQuicksearchPipelinesVariant1Item.DepthEstimation => "depth-estimation",
                GetQuicksearchPipelinesVariant1Item.DocumentQuestionAnswering => "document-question-answering",
                GetQuicksearchPipelinesVariant1Item.FeatureExtraction => "feature-extraction",
                GetQuicksearchPipelinesVariant1Item.FillMask => "fill-mask",
                GetQuicksearchPipelinesVariant1Item.GraphMl => "graph-ml",
                GetQuicksearchPipelinesVariant1Item.ImageClassification => "image-classification",
                GetQuicksearchPipelinesVariant1Item.ImageFeatureExtraction => "image-feature-extraction",
                GetQuicksearchPipelinesVariant1Item.ImageSegmentation => "image-segmentation",
                GetQuicksearchPipelinesVariant1Item.ImageTextToImage => "image-text-to-image",
                GetQuicksearchPipelinesVariant1Item.ImageTextToText => "image-text-to-text",
                GetQuicksearchPipelinesVariant1Item.ImageTextToVideo => "image-text-to-video",
                GetQuicksearchPipelinesVariant1Item.ImageTo3d => "image-to-3d",
                GetQuicksearchPipelinesVariant1Item.ImageToImage => "image-to-image",
                GetQuicksearchPipelinesVariant1Item.ImageToText => "image-to-text",
                GetQuicksearchPipelinesVariant1Item.ImageToVideo => "image-to-video",
                GetQuicksearchPipelinesVariant1Item.KeypointDetection => "keypoint-detection",
                GetQuicksearchPipelinesVariant1Item.MaskGeneration => "mask-generation",
                GetQuicksearchPipelinesVariant1Item.MultipleChoice => "multiple-choice",
                GetQuicksearchPipelinesVariant1Item.ObjectDetection => "object-detection",
                GetQuicksearchPipelinesVariant1Item.Other => "other",
                GetQuicksearchPipelinesVariant1Item.QuestionAnswering => "question-answering",
                GetQuicksearchPipelinesVariant1Item.ReinforcementLearning => "reinforcement-learning",
                GetQuicksearchPipelinesVariant1Item.Robotics => "robotics",
                GetQuicksearchPipelinesVariant1Item.SentenceSimilarity => "sentence-similarity",
                GetQuicksearchPipelinesVariant1Item.Summarization => "summarization",
                GetQuicksearchPipelinesVariant1Item.TableQuestionAnswering => "table-question-answering",
                GetQuicksearchPipelinesVariant1Item.TableToText => "table-to-text",
                GetQuicksearchPipelinesVariant1Item.TabularClassification => "tabular-classification",
                GetQuicksearchPipelinesVariant1Item.TabularRegression => "tabular-regression",
                GetQuicksearchPipelinesVariant1Item.TabularToText => "tabular-to-text",
                GetQuicksearchPipelinesVariant1Item.TextClassification => "text-classification",
                GetQuicksearchPipelinesVariant1Item.TextGeneration => "text-generation",
                GetQuicksearchPipelinesVariant1Item.TextRanking => "text-ranking",
                GetQuicksearchPipelinesVariant1Item.TextRetrieval => "text-retrieval",
                GetQuicksearchPipelinesVariant1Item.TextTo3d => "text-to-3d",
                GetQuicksearchPipelinesVariant1Item.TextToAudio => "text-to-audio",
                GetQuicksearchPipelinesVariant1Item.TextToImage => "text-to-image",
                GetQuicksearchPipelinesVariant1Item.TextToSpeech => "text-to-speech",
                GetQuicksearchPipelinesVariant1Item.TextToVideo => "text-to-video",
                GetQuicksearchPipelinesVariant1Item.TimeSeriesForecasting => "time-series-forecasting",
                GetQuicksearchPipelinesVariant1Item.TokenClassification => "token-classification",
                GetQuicksearchPipelinesVariant1Item.Translation => "translation",
                GetQuicksearchPipelinesVariant1Item.UnconditionalImageGeneration => "unconditional-image-generation",
                GetQuicksearchPipelinesVariant1Item.VideoClassification => "video-classification",
                GetQuicksearchPipelinesVariant1Item.VideoTextToText => "video-text-to-text",
                GetQuicksearchPipelinesVariant1Item.VideoToVideo => "video-to-video",
                GetQuicksearchPipelinesVariant1Item.VisualDocumentRetrieval => "visual-document-retrieval",
                GetQuicksearchPipelinesVariant1Item.VisualQuestionAnswering => "visual-question-answering",
                GetQuicksearchPipelinesVariant1Item.VoiceActivityDetection => "voice-activity-detection",
                GetQuicksearchPipelinesVariant1Item.ZeroShotClassification => "zero-shot-classification",
                GetQuicksearchPipelinesVariant1Item.ZeroShotImageClassification => "zero-shot-image-classification",
                GetQuicksearchPipelinesVariant1Item.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetQuicksearchPipelinesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => GetQuicksearchPipelinesVariant1Item.AnyToAny,
                "audio-classification" => GetQuicksearchPipelinesVariant1Item.AudioClassification,
                "audio-text-to-text" => GetQuicksearchPipelinesVariant1Item.AudioTextToText,
                "audio-to-audio" => GetQuicksearchPipelinesVariant1Item.AudioToAudio,
                "automatic-speech-recognition" => GetQuicksearchPipelinesVariant1Item.AutomaticSpeechRecognition,
                "depth-estimation" => GetQuicksearchPipelinesVariant1Item.DepthEstimation,
                "document-question-answering" => GetQuicksearchPipelinesVariant1Item.DocumentQuestionAnswering,
                "feature-extraction" => GetQuicksearchPipelinesVariant1Item.FeatureExtraction,
                "fill-mask" => GetQuicksearchPipelinesVariant1Item.FillMask,
                "graph-ml" => GetQuicksearchPipelinesVariant1Item.GraphMl,
                "image-classification" => GetQuicksearchPipelinesVariant1Item.ImageClassification,
                "image-feature-extraction" => GetQuicksearchPipelinesVariant1Item.ImageFeatureExtraction,
                "image-segmentation" => GetQuicksearchPipelinesVariant1Item.ImageSegmentation,
                "image-text-to-image" => GetQuicksearchPipelinesVariant1Item.ImageTextToImage,
                "image-text-to-text" => GetQuicksearchPipelinesVariant1Item.ImageTextToText,
                "image-text-to-video" => GetQuicksearchPipelinesVariant1Item.ImageTextToVideo,
                "image-to-3d" => GetQuicksearchPipelinesVariant1Item.ImageTo3d,
                "image-to-image" => GetQuicksearchPipelinesVariant1Item.ImageToImage,
                "image-to-text" => GetQuicksearchPipelinesVariant1Item.ImageToText,
                "image-to-video" => GetQuicksearchPipelinesVariant1Item.ImageToVideo,
                "keypoint-detection" => GetQuicksearchPipelinesVariant1Item.KeypointDetection,
                "mask-generation" => GetQuicksearchPipelinesVariant1Item.MaskGeneration,
                "multiple-choice" => GetQuicksearchPipelinesVariant1Item.MultipleChoice,
                "object-detection" => GetQuicksearchPipelinesVariant1Item.ObjectDetection,
                "other" => GetQuicksearchPipelinesVariant1Item.Other,
                "question-answering" => GetQuicksearchPipelinesVariant1Item.QuestionAnswering,
                "reinforcement-learning" => GetQuicksearchPipelinesVariant1Item.ReinforcementLearning,
                "robotics" => GetQuicksearchPipelinesVariant1Item.Robotics,
                "sentence-similarity" => GetQuicksearchPipelinesVariant1Item.SentenceSimilarity,
                "summarization" => GetQuicksearchPipelinesVariant1Item.Summarization,
                "table-question-answering" => GetQuicksearchPipelinesVariant1Item.TableQuestionAnswering,
                "table-to-text" => GetQuicksearchPipelinesVariant1Item.TableToText,
                "tabular-classification" => GetQuicksearchPipelinesVariant1Item.TabularClassification,
                "tabular-regression" => GetQuicksearchPipelinesVariant1Item.TabularRegression,
                "tabular-to-text" => GetQuicksearchPipelinesVariant1Item.TabularToText,
                "text-classification" => GetQuicksearchPipelinesVariant1Item.TextClassification,
                "text-generation" => GetQuicksearchPipelinesVariant1Item.TextGeneration,
                "text-ranking" => GetQuicksearchPipelinesVariant1Item.TextRanking,
                "text-retrieval" => GetQuicksearchPipelinesVariant1Item.TextRetrieval,
                "text-to-3d" => GetQuicksearchPipelinesVariant1Item.TextTo3d,
                "text-to-audio" => GetQuicksearchPipelinesVariant1Item.TextToAudio,
                "text-to-image" => GetQuicksearchPipelinesVariant1Item.TextToImage,
                "text-to-speech" => GetQuicksearchPipelinesVariant1Item.TextToSpeech,
                "text-to-video" => GetQuicksearchPipelinesVariant1Item.TextToVideo,
                "time-series-forecasting" => GetQuicksearchPipelinesVariant1Item.TimeSeriesForecasting,
                "token-classification" => GetQuicksearchPipelinesVariant1Item.TokenClassification,
                "translation" => GetQuicksearchPipelinesVariant1Item.Translation,
                "unconditional-image-generation" => GetQuicksearchPipelinesVariant1Item.UnconditionalImageGeneration,
                "video-classification" => GetQuicksearchPipelinesVariant1Item.VideoClassification,
                "video-text-to-text" => GetQuicksearchPipelinesVariant1Item.VideoTextToText,
                "video-to-video" => GetQuicksearchPipelinesVariant1Item.VideoToVideo,
                "visual-document-retrieval" => GetQuicksearchPipelinesVariant1Item.VisualDocumentRetrieval,
                "visual-question-answering" => GetQuicksearchPipelinesVariant1Item.VisualQuestionAnswering,
                "voice-activity-detection" => GetQuicksearchPipelinesVariant1Item.VoiceActivityDetection,
                "zero-shot-classification" => GetQuicksearchPipelinesVariant1Item.ZeroShotClassification,
                "zero-shot-image-classification" => GetQuicksearchPipelinesVariant1Item.ZeroShotImageClassification,
                "zero-shot-object-detection" => GetQuicksearchPipelinesVariant1Item.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}