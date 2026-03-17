
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestPipelinesVariant1Item
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
    public static class RequestPipelinesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestPipelinesVariant1Item value)
        {
            return value switch
            {
                RequestPipelinesVariant1Item.TextClassification => "text-classification",
                RequestPipelinesVariant1Item.TokenClassification => "token-classification",
                RequestPipelinesVariant1Item.TableQuestionAnswering => "table-question-answering",
                RequestPipelinesVariant1Item.QuestionAnswering => "question-answering",
                RequestPipelinesVariant1Item.ZeroShotClassification => "zero-shot-classification",
                RequestPipelinesVariant1Item.Translation => "translation",
                RequestPipelinesVariant1Item.Summarization => "summarization",
                RequestPipelinesVariant1Item.FeatureExtraction => "feature-extraction",
                RequestPipelinesVariant1Item.TextGeneration => "text-generation",
                RequestPipelinesVariant1Item.FillMask => "fill-mask",
                RequestPipelinesVariant1Item.SentenceSimilarity => "sentence-similarity",
                RequestPipelinesVariant1Item.TextToSpeech => "text-to-speech",
                RequestPipelinesVariant1Item.TextToAudio => "text-to-audio",
                RequestPipelinesVariant1Item.AutomaticSpeechRecognition => "automatic-speech-recognition",
                RequestPipelinesVariant1Item.AudioToAudio => "audio-to-audio",
                RequestPipelinesVariant1Item.AudioClassification => "audio-classification",
                RequestPipelinesVariant1Item.AudioTextToText => "audio-text-to-text",
                RequestPipelinesVariant1Item.VoiceActivityDetection => "voice-activity-detection",
                RequestPipelinesVariant1Item.DepthEstimation => "depth-estimation",
                RequestPipelinesVariant1Item.ImageClassification => "image-classification",
                RequestPipelinesVariant1Item.ObjectDetection => "object-detection",
                RequestPipelinesVariant1Item.ImageSegmentation => "image-segmentation",
                RequestPipelinesVariant1Item.TextToImage => "text-to-image",
                RequestPipelinesVariant1Item.ImageToText => "image-to-text",
                RequestPipelinesVariant1Item.ImageToImage => "image-to-image",
                RequestPipelinesVariant1Item.ImageToVideo => "image-to-video",
                RequestPipelinesVariant1Item.UnconditionalImageGeneration => "unconditional-image-generation",
                RequestPipelinesVariant1Item.VideoClassification => "video-classification",
                RequestPipelinesVariant1Item.ReinforcementLearning => "reinforcement-learning",
                RequestPipelinesVariant1Item.Robotics => "robotics",
                RequestPipelinesVariant1Item.TabularClassification => "tabular-classification",
                RequestPipelinesVariant1Item.TabularRegression => "tabular-regression",
                RequestPipelinesVariant1Item.TabularToText => "tabular-to-text",
                RequestPipelinesVariant1Item.TableToText => "table-to-text",
                RequestPipelinesVariant1Item.MultipleChoice => "multiple-choice",
                RequestPipelinesVariant1Item.TextRanking => "text-ranking",
                RequestPipelinesVariant1Item.TextRetrieval => "text-retrieval",
                RequestPipelinesVariant1Item.TimeSeriesForecasting => "time-series-forecasting",
                RequestPipelinesVariant1Item.TextToVideo => "text-to-video",
                RequestPipelinesVariant1Item.ImageTextToText => "image-text-to-text",
                RequestPipelinesVariant1Item.ImageTextToImage => "image-text-to-image",
                RequestPipelinesVariant1Item.ImageTextToVideo => "image-text-to-video",
                RequestPipelinesVariant1Item.VisualQuestionAnswering => "visual-question-answering",
                RequestPipelinesVariant1Item.DocumentQuestionAnswering => "document-question-answering",
                RequestPipelinesVariant1Item.ZeroShotImageClassification => "zero-shot-image-classification",
                RequestPipelinesVariant1Item.GraphMl => "graph-ml",
                RequestPipelinesVariant1Item.MaskGeneration => "mask-generation",
                RequestPipelinesVariant1Item.ZeroShotObjectDetection => "zero-shot-object-detection",
                RequestPipelinesVariant1Item.TextTo3d => "text-to-3d",
                RequestPipelinesVariant1Item.ImageTo3d => "image-to-3d",
                RequestPipelinesVariant1Item.ImageFeatureExtraction => "image-feature-extraction",
                RequestPipelinesVariant1Item.VideoTextToText => "video-text-to-text",
                RequestPipelinesVariant1Item.KeypointDetection => "keypoint-detection",
                RequestPipelinesVariant1Item.VisualDocumentRetrieval => "visual-document-retrieval",
                RequestPipelinesVariant1Item.AnyToAny => "any-to-any",
                RequestPipelinesVariant1Item.VideoToVideo => "video-to-video",
                RequestPipelinesVariant1Item.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestPipelinesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "text-classification" => RequestPipelinesVariant1Item.TextClassification,
                "token-classification" => RequestPipelinesVariant1Item.TokenClassification,
                "table-question-answering" => RequestPipelinesVariant1Item.TableQuestionAnswering,
                "question-answering" => RequestPipelinesVariant1Item.QuestionAnswering,
                "zero-shot-classification" => RequestPipelinesVariant1Item.ZeroShotClassification,
                "translation" => RequestPipelinesVariant1Item.Translation,
                "summarization" => RequestPipelinesVariant1Item.Summarization,
                "feature-extraction" => RequestPipelinesVariant1Item.FeatureExtraction,
                "text-generation" => RequestPipelinesVariant1Item.TextGeneration,
                "fill-mask" => RequestPipelinesVariant1Item.FillMask,
                "sentence-similarity" => RequestPipelinesVariant1Item.SentenceSimilarity,
                "text-to-speech" => RequestPipelinesVariant1Item.TextToSpeech,
                "text-to-audio" => RequestPipelinesVariant1Item.TextToAudio,
                "automatic-speech-recognition" => RequestPipelinesVariant1Item.AutomaticSpeechRecognition,
                "audio-to-audio" => RequestPipelinesVariant1Item.AudioToAudio,
                "audio-classification" => RequestPipelinesVariant1Item.AudioClassification,
                "audio-text-to-text" => RequestPipelinesVariant1Item.AudioTextToText,
                "voice-activity-detection" => RequestPipelinesVariant1Item.VoiceActivityDetection,
                "depth-estimation" => RequestPipelinesVariant1Item.DepthEstimation,
                "image-classification" => RequestPipelinesVariant1Item.ImageClassification,
                "object-detection" => RequestPipelinesVariant1Item.ObjectDetection,
                "image-segmentation" => RequestPipelinesVariant1Item.ImageSegmentation,
                "text-to-image" => RequestPipelinesVariant1Item.TextToImage,
                "image-to-text" => RequestPipelinesVariant1Item.ImageToText,
                "image-to-image" => RequestPipelinesVariant1Item.ImageToImage,
                "image-to-video" => RequestPipelinesVariant1Item.ImageToVideo,
                "unconditional-image-generation" => RequestPipelinesVariant1Item.UnconditionalImageGeneration,
                "video-classification" => RequestPipelinesVariant1Item.VideoClassification,
                "reinforcement-learning" => RequestPipelinesVariant1Item.ReinforcementLearning,
                "robotics" => RequestPipelinesVariant1Item.Robotics,
                "tabular-classification" => RequestPipelinesVariant1Item.TabularClassification,
                "tabular-regression" => RequestPipelinesVariant1Item.TabularRegression,
                "tabular-to-text" => RequestPipelinesVariant1Item.TabularToText,
                "table-to-text" => RequestPipelinesVariant1Item.TableToText,
                "multiple-choice" => RequestPipelinesVariant1Item.MultipleChoice,
                "text-ranking" => RequestPipelinesVariant1Item.TextRanking,
                "text-retrieval" => RequestPipelinesVariant1Item.TextRetrieval,
                "time-series-forecasting" => RequestPipelinesVariant1Item.TimeSeriesForecasting,
                "text-to-video" => RequestPipelinesVariant1Item.TextToVideo,
                "image-text-to-text" => RequestPipelinesVariant1Item.ImageTextToText,
                "image-text-to-image" => RequestPipelinesVariant1Item.ImageTextToImage,
                "image-text-to-video" => RequestPipelinesVariant1Item.ImageTextToVideo,
                "visual-question-answering" => RequestPipelinesVariant1Item.VisualQuestionAnswering,
                "document-question-answering" => RequestPipelinesVariant1Item.DocumentQuestionAnswering,
                "zero-shot-image-classification" => RequestPipelinesVariant1Item.ZeroShotImageClassification,
                "graph-ml" => RequestPipelinesVariant1Item.GraphMl,
                "mask-generation" => RequestPipelinesVariant1Item.MaskGeneration,
                "zero-shot-object-detection" => RequestPipelinesVariant1Item.ZeroShotObjectDetection,
                "text-to-3d" => RequestPipelinesVariant1Item.TextTo3d,
                "image-to-3d" => RequestPipelinesVariant1Item.ImageTo3d,
                "image-feature-extraction" => RequestPipelinesVariant1Item.ImageFeatureExtraction,
                "video-text-to-text" => RequestPipelinesVariant1Item.VideoTextToText,
                "keypoint-detection" => RequestPipelinesVariant1Item.KeypointDetection,
                "visual-document-retrieval" => RequestPipelinesVariant1Item.VisualDocumentRetrieval,
                "any-to-any" => RequestPipelinesVariant1Item.AnyToAny,
                "video-to-video" => RequestPipelinesVariant1Item.VideoToVideo,
                "other" => RequestPipelinesVariant1Item.Other,
                _ => null,
            };
        }
    }
}