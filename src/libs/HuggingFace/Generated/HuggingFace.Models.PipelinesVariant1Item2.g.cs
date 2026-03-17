
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesVariant1Item2
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
    public static class PipelinesVariant1Item2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesVariant1Item2 value)
        {
            return value switch
            {
                PipelinesVariant1Item2.TextClassification => "text-classification",
                PipelinesVariant1Item2.TokenClassification => "token-classification",
                PipelinesVariant1Item2.TableQuestionAnswering => "table-question-answering",
                PipelinesVariant1Item2.QuestionAnswering => "question-answering",
                PipelinesVariant1Item2.ZeroShotClassification => "zero-shot-classification",
                PipelinesVariant1Item2.Translation => "translation",
                PipelinesVariant1Item2.Summarization => "summarization",
                PipelinesVariant1Item2.FeatureExtraction => "feature-extraction",
                PipelinesVariant1Item2.TextGeneration => "text-generation",
                PipelinesVariant1Item2.FillMask => "fill-mask",
                PipelinesVariant1Item2.SentenceSimilarity => "sentence-similarity",
                PipelinesVariant1Item2.TextToSpeech => "text-to-speech",
                PipelinesVariant1Item2.TextToAudio => "text-to-audio",
                PipelinesVariant1Item2.AutomaticSpeechRecognition => "automatic-speech-recognition",
                PipelinesVariant1Item2.AudioToAudio => "audio-to-audio",
                PipelinesVariant1Item2.AudioClassification => "audio-classification",
                PipelinesVariant1Item2.AudioTextToText => "audio-text-to-text",
                PipelinesVariant1Item2.VoiceActivityDetection => "voice-activity-detection",
                PipelinesVariant1Item2.DepthEstimation => "depth-estimation",
                PipelinesVariant1Item2.ImageClassification => "image-classification",
                PipelinesVariant1Item2.ObjectDetection => "object-detection",
                PipelinesVariant1Item2.ImageSegmentation => "image-segmentation",
                PipelinesVariant1Item2.TextToImage => "text-to-image",
                PipelinesVariant1Item2.ImageToText => "image-to-text",
                PipelinesVariant1Item2.ImageToImage => "image-to-image",
                PipelinesVariant1Item2.ImageToVideo => "image-to-video",
                PipelinesVariant1Item2.UnconditionalImageGeneration => "unconditional-image-generation",
                PipelinesVariant1Item2.VideoClassification => "video-classification",
                PipelinesVariant1Item2.ReinforcementLearning => "reinforcement-learning",
                PipelinesVariant1Item2.Robotics => "robotics",
                PipelinesVariant1Item2.TabularClassification => "tabular-classification",
                PipelinesVariant1Item2.TabularRegression => "tabular-regression",
                PipelinesVariant1Item2.TabularToText => "tabular-to-text",
                PipelinesVariant1Item2.TableToText => "table-to-text",
                PipelinesVariant1Item2.MultipleChoice => "multiple-choice",
                PipelinesVariant1Item2.TextRanking => "text-ranking",
                PipelinesVariant1Item2.TextRetrieval => "text-retrieval",
                PipelinesVariant1Item2.TimeSeriesForecasting => "time-series-forecasting",
                PipelinesVariant1Item2.TextToVideo => "text-to-video",
                PipelinesVariant1Item2.ImageTextToText => "image-text-to-text",
                PipelinesVariant1Item2.ImageTextToImage => "image-text-to-image",
                PipelinesVariant1Item2.ImageTextToVideo => "image-text-to-video",
                PipelinesVariant1Item2.VisualQuestionAnswering => "visual-question-answering",
                PipelinesVariant1Item2.DocumentQuestionAnswering => "document-question-answering",
                PipelinesVariant1Item2.ZeroShotImageClassification => "zero-shot-image-classification",
                PipelinesVariant1Item2.GraphMl => "graph-ml",
                PipelinesVariant1Item2.MaskGeneration => "mask-generation",
                PipelinesVariant1Item2.ZeroShotObjectDetection => "zero-shot-object-detection",
                PipelinesVariant1Item2.TextTo3d => "text-to-3d",
                PipelinesVariant1Item2.ImageTo3d => "image-to-3d",
                PipelinesVariant1Item2.ImageFeatureExtraction => "image-feature-extraction",
                PipelinesVariant1Item2.VideoTextToText => "video-text-to-text",
                PipelinesVariant1Item2.KeypointDetection => "keypoint-detection",
                PipelinesVariant1Item2.VisualDocumentRetrieval => "visual-document-retrieval",
                PipelinesVariant1Item2.AnyToAny => "any-to-any",
                PipelinesVariant1Item2.VideoToVideo => "video-to-video",
                PipelinesVariant1Item2.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesVariant1Item2? ToEnum(string value)
        {
            return value switch
            {
                "text-classification" => PipelinesVariant1Item2.TextClassification,
                "token-classification" => PipelinesVariant1Item2.TokenClassification,
                "table-question-answering" => PipelinesVariant1Item2.TableQuestionAnswering,
                "question-answering" => PipelinesVariant1Item2.QuestionAnswering,
                "zero-shot-classification" => PipelinesVariant1Item2.ZeroShotClassification,
                "translation" => PipelinesVariant1Item2.Translation,
                "summarization" => PipelinesVariant1Item2.Summarization,
                "feature-extraction" => PipelinesVariant1Item2.FeatureExtraction,
                "text-generation" => PipelinesVariant1Item2.TextGeneration,
                "fill-mask" => PipelinesVariant1Item2.FillMask,
                "sentence-similarity" => PipelinesVariant1Item2.SentenceSimilarity,
                "text-to-speech" => PipelinesVariant1Item2.TextToSpeech,
                "text-to-audio" => PipelinesVariant1Item2.TextToAudio,
                "automatic-speech-recognition" => PipelinesVariant1Item2.AutomaticSpeechRecognition,
                "audio-to-audio" => PipelinesVariant1Item2.AudioToAudio,
                "audio-classification" => PipelinesVariant1Item2.AudioClassification,
                "audio-text-to-text" => PipelinesVariant1Item2.AudioTextToText,
                "voice-activity-detection" => PipelinesVariant1Item2.VoiceActivityDetection,
                "depth-estimation" => PipelinesVariant1Item2.DepthEstimation,
                "image-classification" => PipelinesVariant1Item2.ImageClassification,
                "object-detection" => PipelinesVariant1Item2.ObjectDetection,
                "image-segmentation" => PipelinesVariant1Item2.ImageSegmentation,
                "text-to-image" => PipelinesVariant1Item2.TextToImage,
                "image-to-text" => PipelinesVariant1Item2.ImageToText,
                "image-to-image" => PipelinesVariant1Item2.ImageToImage,
                "image-to-video" => PipelinesVariant1Item2.ImageToVideo,
                "unconditional-image-generation" => PipelinesVariant1Item2.UnconditionalImageGeneration,
                "video-classification" => PipelinesVariant1Item2.VideoClassification,
                "reinforcement-learning" => PipelinesVariant1Item2.ReinforcementLearning,
                "robotics" => PipelinesVariant1Item2.Robotics,
                "tabular-classification" => PipelinesVariant1Item2.TabularClassification,
                "tabular-regression" => PipelinesVariant1Item2.TabularRegression,
                "tabular-to-text" => PipelinesVariant1Item2.TabularToText,
                "table-to-text" => PipelinesVariant1Item2.TableToText,
                "multiple-choice" => PipelinesVariant1Item2.MultipleChoice,
                "text-ranking" => PipelinesVariant1Item2.TextRanking,
                "text-retrieval" => PipelinesVariant1Item2.TextRetrieval,
                "time-series-forecasting" => PipelinesVariant1Item2.TimeSeriesForecasting,
                "text-to-video" => PipelinesVariant1Item2.TextToVideo,
                "image-text-to-text" => PipelinesVariant1Item2.ImageTextToText,
                "image-text-to-image" => PipelinesVariant1Item2.ImageTextToImage,
                "image-text-to-video" => PipelinesVariant1Item2.ImageTextToVideo,
                "visual-question-answering" => PipelinesVariant1Item2.VisualQuestionAnswering,
                "document-question-answering" => PipelinesVariant1Item2.DocumentQuestionAnswering,
                "zero-shot-image-classification" => PipelinesVariant1Item2.ZeroShotImageClassification,
                "graph-ml" => PipelinesVariant1Item2.GraphMl,
                "mask-generation" => PipelinesVariant1Item2.MaskGeneration,
                "zero-shot-object-detection" => PipelinesVariant1Item2.ZeroShotObjectDetection,
                "text-to-3d" => PipelinesVariant1Item2.TextTo3d,
                "image-to-3d" => PipelinesVariant1Item2.ImageTo3d,
                "image-feature-extraction" => PipelinesVariant1Item2.ImageFeatureExtraction,
                "video-text-to-text" => PipelinesVariant1Item2.VideoTextToText,
                "keypoint-detection" => PipelinesVariant1Item2.KeypointDetection,
                "visual-document-retrieval" => PipelinesVariant1Item2.VisualDocumentRetrieval,
                "any-to-any" => PipelinesVariant1Item2.AnyToAny,
                "video-to-video" => PipelinesVariant1Item2.VideoToVideo,
                "other" => PipelinesVariant1Item2.Other,
                _ => null,
            };
        }
    }
}