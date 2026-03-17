
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesVariant1Item
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesVariant1Item value)
        {
            return value switch
            {
                PipelinesVariant1Item.TextClassification => "text-classification",
                PipelinesVariant1Item.TokenClassification => "token-classification",
                PipelinesVariant1Item.TableQuestionAnswering => "table-question-answering",
                PipelinesVariant1Item.QuestionAnswering => "question-answering",
                PipelinesVariant1Item.ZeroShotClassification => "zero-shot-classification",
                PipelinesVariant1Item.Translation => "translation",
                PipelinesVariant1Item.Summarization => "summarization",
                PipelinesVariant1Item.FeatureExtraction => "feature-extraction",
                PipelinesVariant1Item.TextGeneration => "text-generation",
                PipelinesVariant1Item.FillMask => "fill-mask",
                PipelinesVariant1Item.SentenceSimilarity => "sentence-similarity",
                PipelinesVariant1Item.TextToSpeech => "text-to-speech",
                PipelinesVariant1Item.TextToAudio => "text-to-audio",
                PipelinesVariant1Item.AutomaticSpeechRecognition => "automatic-speech-recognition",
                PipelinesVariant1Item.AudioToAudio => "audio-to-audio",
                PipelinesVariant1Item.AudioClassification => "audio-classification",
                PipelinesVariant1Item.AudioTextToText => "audio-text-to-text",
                PipelinesVariant1Item.VoiceActivityDetection => "voice-activity-detection",
                PipelinesVariant1Item.DepthEstimation => "depth-estimation",
                PipelinesVariant1Item.ImageClassification => "image-classification",
                PipelinesVariant1Item.ObjectDetection => "object-detection",
                PipelinesVariant1Item.ImageSegmentation => "image-segmentation",
                PipelinesVariant1Item.TextToImage => "text-to-image",
                PipelinesVariant1Item.ImageToText => "image-to-text",
                PipelinesVariant1Item.ImageToImage => "image-to-image",
                PipelinesVariant1Item.ImageToVideo => "image-to-video",
                PipelinesVariant1Item.UnconditionalImageGeneration => "unconditional-image-generation",
                PipelinesVariant1Item.VideoClassification => "video-classification",
                PipelinesVariant1Item.ReinforcementLearning => "reinforcement-learning",
                PipelinesVariant1Item.Robotics => "robotics",
                PipelinesVariant1Item.TabularClassification => "tabular-classification",
                PipelinesVariant1Item.TabularRegression => "tabular-regression",
                PipelinesVariant1Item.TabularToText => "tabular-to-text",
                PipelinesVariant1Item.TableToText => "table-to-text",
                PipelinesVariant1Item.MultipleChoice => "multiple-choice",
                PipelinesVariant1Item.TextRanking => "text-ranking",
                PipelinesVariant1Item.TextRetrieval => "text-retrieval",
                PipelinesVariant1Item.TimeSeriesForecasting => "time-series-forecasting",
                PipelinesVariant1Item.TextToVideo => "text-to-video",
                PipelinesVariant1Item.ImageTextToText => "image-text-to-text",
                PipelinesVariant1Item.ImageTextToImage => "image-text-to-image",
                PipelinesVariant1Item.ImageTextToVideo => "image-text-to-video",
                PipelinesVariant1Item.VisualQuestionAnswering => "visual-question-answering",
                PipelinesVariant1Item.DocumentQuestionAnswering => "document-question-answering",
                PipelinesVariant1Item.ZeroShotImageClassification => "zero-shot-image-classification",
                PipelinesVariant1Item.GraphMl => "graph-ml",
                PipelinesVariant1Item.MaskGeneration => "mask-generation",
                PipelinesVariant1Item.ZeroShotObjectDetection => "zero-shot-object-detection",
                PipelinesVariant1Item.TextTo3d => "text-to-3d",
                PipelinesVariant1Item.ImageTo3d => "image-to-3d",
                PipelinesVariant1Item.ImageFeatureExtraction => "image-feature-extraction",
                PipelinesVariant1Item.VideoTextToText => "video-text-to-text",
                PipelinesVariant1Item.KeypointDetection => "keypoint-detection",
                PipelinesVariant1Item.VisualDocumentRetrieval => "visual-document-retrieval",
                PipelinesVariant1Item.AnyToAny => "any-to-any",
                PipelinesVariant1Item.VideoToVideo => "video-to-video",
                PipelinesVariant1Item.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "text-classification" => PipelinesVariant1Item.TextClassification,
                "token-classification" => PipelinesVariant1Item.TokenClassification,
                "table-question-answering" => PipelinesVariant1Item.TableQuestionAnswering,
                "question-answering" => PipelinesVariant1Item.QuestionAnswering,
                "zero-shot-classification" => PipelinesVariant1Item.ZeroShotClassification,
                "translation" => PipelinesVariant1Item.Translation,
                "summarization" => PipelinesVariant1Item.Summarization,
                "feature-extraction" => PipelinesVariant1Item.FeatureExtraction,
                "text-generation" => PipelinesVariant1Item.TextGeneration,
                "fill-mask" => PipelinesVariant1Item.FillMask,
                "sentence-similarity" => PipelinesVariant1Item.SentenceSimilarity,
                "text-to-speech" => PipelinesVariant1Item.TextToSpeech,
                "text-to-audio" => PipelinesVariant1Item.TextToAudio,
                "automatic-speech-recognition" => PipelinesVariant1Item.AutomaticSpeechRecognition,
                "audio-to-audio" => PipelinesVariant1Item.AudioToAudio,
                "audio-classification" => PipelinesVariant1Item.AudioClassification,
                "audio-text-to-text" => PipelinesVariant1Item.AudioTextToText,
                "voice-activity-detection" => PipelinesVariant1Item.VoiceActivityDetection,
                "depth-estimation" => PipelinesVariant1Item.DepthEstimation,
                "image-classification" => PipelinesVariant1Item.ImageClassification,
                "object-detection" => PipelinesVariant1Item.ObjectDetection,
                "image-segmentation" => PipelinesVariant1Item.ImageSegmentation,
                "text-to-image" => PipelinesVariant1Item.TextToImage,
                "image-to-text" => PipelinesVariant1Item.ImageToText,
                "image-to-image" => PipelinesVariant1Item.ImageToImage,
                "image-to-video" => PipelinesVariant1Item.ImageToVideo,
                "unconditional-image-generation" => PipelinesVariant1Item.UnconditionalImageGeneration,
                "video-classification" => PipelinesVariant1Item.VideoClassification,
                "reinforcement-learning" => PipelinesVariant1Item.ReinforcementLearning,
                "robotics" => PipelinesVariant1Item.Robotics,
                "tabular-classification" => PipelinesVariant1Item.TabularClassification,
                "tabular-regression" => PipelinesVariant1Item.TabularRegression,
                "tabular-to-text" => PipelinesVariant1Item.TabularToText,
                "table-to-text" => PipelinesVariant1Item.TableToText,
                "multiple-choice" => PipelinesVariant1Item.MultipleChoice,
                "text-ranking" => PipelinesVariant1Item.TextRanking,
                "text-retrieval" => PipelinesVariant1Item.TextRetrieval,
                "time-series-forecasting" => PipelinesVariant1Item.TimeSeriesForecasting,
                "text-to-video" => PipelinesVariant1Item.TextToVideo,
                "image-text-to-text" => PipelinesVariant1Item.ImageTextToText,
                "image-text-to-image" => PipelinesVariant1Item.ImageTextToImage,
                "image-text-to-video" => PipelinesVariant1Item.ImageTextToVideo,
                "visual-question-answering" => PipelinesVariant1Item.VisualQuestionAnswering,
                "document-question-answering" => PipelinesVariant1Item.DocumentQuestionAnswering,
                "zero-shot-image-classification" => PipelinesVariant1Item.ZeroShotImageClassification,
                "graph-ml" => PipelinesVariant1Item.GraphMl,
                "mask-generation" => PipelinesVariant1Item.MaskGeneration,
                "zero-shot-object-detection" => PipelinesVariant1Item.ZeroShotObjectDetection,
                "text-to-3d" => PipelinesVariant1Item.TextTo3d,
                "image-to-3d" => PipelinesVariant1Item.ImageTo3d,
                "image-feature-extraction" => PipelinesVariant1Item.ImageFeatureExtraction,
                "video-text-to-text" => PipelinesVariant1Item.VideoTextToText,
                "keypoint-detection" => PipelinesVariant1Item.KeypointDetection,
                "visual-document-retrieval" => PipelinesVariant1Item.VisualDocumentRetrieval,
                "any-to-any" => PipelinesVariant1Item.AnyToAny,
                "video-to-video" => PipelinesVariant1Item.VideoToVideo,
                "other" => PipelinesVariant1Item.Other,
                _ => null,
            };
        }
    }
}