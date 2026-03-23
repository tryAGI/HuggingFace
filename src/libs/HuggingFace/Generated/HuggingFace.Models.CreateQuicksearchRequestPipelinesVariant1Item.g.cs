
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQuicksearchRequestPipelinesVariant1Item
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
    public static class CreateQuicksearchRequestPipelinesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchRequestPipelinesVariant1Item value)
        {
            return value switch
            {
                CreateQuicksearchRequestPipelinesVariant1Item.AnyToAny => "any-to-any",
                CreateQuicksearchRequestPipelinesVariant1Item.AudioClassification => "audio-classification",
                CreateQuicksearchRequestPipelinesVariant1Item.AudioTextToText => "audio-text-to-text",
                CreateQuicksearchRequestPipelinesVariant1Item.AudioToAudio => "audio-to-audio",
                CreateQuicksearchRequestPipelinesVariant1Item.AutomaticSpeechRecognition => "automatic-speech-recognition",
                CreateQuicksearchRequestPipelinesVariant1Item.DepthEstimation => "depth-estimation",
                CreateQuicksearchRequestPipelinesVariant1Item.DocumentQuestionAnswering => "document-question-answering",
                CreateQuicksearchRequestPipelinesVariant1Item.FeatureExtraction => "feature-extraction",
                CreateQuicksearchRequestPipelinesVariant1Item.FillMask => "fill-mask",
                CreateQuicksearchRequestPipelinesVariant1Item.GraphMl => "graph-ml",
                CreateQuicksearchRequestPipelinesVariant1Item.ImageClassification => "image-classification",
                CreateQuicksearchRequestPipelinesVariant1Item.ImageFeatureExtraction => "image-feature-extraction",
                CreateQuicksearchRequestPipelinesVariant1Item.ImageSegmentation => "image-segmentation",
                CreateQuicksearchRequestPipelinesVariant1Item.ImageTextToImage => "image-text-to-image",
                CreateQuicksearchRequestPipelinesVariant1Item.ImageTextToText => "image-text-to-text",
                CreateQuicksearchRequestPipelinesVariant1Item.ImageTextToVideo => "image-text-to-video",
                CreateQuicksearchRequestPipelinesVariant1Item.ImageTo3d => "image-to-3d",
                CreateQuicksearchRequestPipelinesVariant1Item.ImageToImage => "image-to-image",
                CreateQuicksearchRequestPipelinesVariant1Item.ImageToText => "image-to-text",
                CreateQuicksearchRequestPipelinesVariant1Item.ImageToVideo => "image-to-video",
                CreateQuicksearchRequestPipelinesVariant1Item.KeypointDetection => "keypoint-detection",
                CreateQuicksearchRequestPipelinesVariant1Item.MaskGeneration => "mask-generation",
                CreateQuicksearchRequestPipelinesVariant1Item.MultipleChoice => "multiple-choice",
                CreateQuicksearchRequestPipelinesVariant1Item.ObjectDetection => "object-detection",
                CreateQuicksearchRequestPipelinesVariant1Item.Other => "other",
                CreateQuicksearchRequestPipelinesVariant1Item.QuestionAnswering => "question-answering",
                CreateQuicksearchRequestPipelinesVariant1Item.ReinforcementLearning => "reinforcement-learning",
                CreateQuicksearchRequestPipelinesVariant1Item.Robotics => "robotics",
                CreateQuicksearchRequestPipelinesVariant1Item.SentenceSimilarity => "sentence-similarity",
                CreateQuicksearchRequestPipelinesVariant1Item.Summarization => "summarization",
                CreateQuicksearchRequestPipelinesVariant1Item.TableQuestionAnswering => "table-question-answering",
                CreateQuicksearchRequestPipelinesVariant1Item.TableToText => "table-to-text",
                CreateQuicksearchRequestPipelinesVariant1Item.TabularClassification => "tabular-classification",
                CreateQuicksearchRequestPipelinesVariant1Item.TabularRegression => "tabular-regression",
                CreateQuicksearchRequestPipelinesVariant1Item.TabularToText => "tabular-to-text",
                CreateQuicksearchRequestPipelinesVariant1Item.TextClassification => "text-classification",
                CreateQuicksearchRequestPipelinesVariant1Item.TextGeneration => "text-generation",
                CreateQuicksearchRequestPipelinesVariant1Item.TextRanking => "text-ranking",
                CreateQuicksearchRequestPipelinesVariant1Item.TextRetrieval => "text-retrieval",
                CreateQuicksearchRequestPipelinesVariant1Item.TextTo3d => "text-to-3d",
                CreateQuicksearchRequestPipelinesVariant1Item.TextToAudio => "text-to-audio",
                CreateQuicksearchRequestPipelinesVariant1Item.TextToImage => "text-to-image",
                CreateQuicksearchRequestPipelinesVariant1Item.TextToSpeech => "text-to-speech",
                CreateQuicksearchRequestPipelinesVariant1Item.TextToVideo => "text-to-video",
                CreateQuicksearchRequestPipelinesVariant1Item.TimeSeriesForecasting => "time-series-forecasting",
                CreateQuicksearchRequestPipelinesVariant1Item.TokenClassification => "token-classification",
                CreateQuicksearchRequestPipelinesVariant1Item.Translation => "translation",
                CreateQuicksearchRequestPipelinesVariant1Item.UnconditionalImageGeneration => "unconditional-image-generation",
                CreateQuicksearchRequestPipelinesVariant1Item.VideoClassification => "video-classification",
                CreateQuicksearchRequestPipelinesVariant1Item.VideoTextToText => "video-text-to-text",
                CreateQuicksearchRequestPipelinesVariant1Item.VideoToVideo => "video-to-video",
                CreateQuicksearchRequestPipelinesVariant1Item.VisualDocumentRetrieval => "visual-document-retrieval",
                CreateQuicksearchRequestPipelinesVariant1Item.VisualQuestionAnswering => "visual-question-answering",
                CreateQuicksearchRequestPipelinesVariant1Item.VoiceActivityDetection => "voice-activity-detection",
                CreateQuicksearchRequestPipelinesVariant1Item.ZeroShotClassification => "zero-shot-classification",
                CreateQuicksearchRequestPipelinesVariant1Item.ZeroShotImageClassification => "zero-shot-image-classification",
                CreateQuicksearchRequestPipelinesVariant1Item.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchRequestPipelinesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => CreateQuicksearchRequestPipelinesVariant1Item.AnyToAny,
                "audio-classification" => CreateQuicksearchRequestPipelinesVariant1Item.AudioClassification,
                "audio-text-to-text" => CreateQuicksearchRequestPipelinesVariant1Item.AudioTextToText,
                "audio-to-audio" => CreateQuicksearchRequestPipelinesVariant1Item.AudioToAudio,
                "automatic-speech-recognition" => CreateQuicksearchRequestPipelinesVariant1Item.AutomaticSpeechRecognition,
                "depth-estimation" => CreateQuicksearchRequestPipelinesVariant1Item.DepthEstimation,
                "document-question-answering" => CreateQuicksearchRequestPipelinesVariant1Item.DocumentQuestionAnswering,
                "feature-extraction" => CreateQuicksearchRequestPipelinesVariant1Item.FeatureExtraction,
                "fill-mask" => CreateQuicksearchRequestPipelinesVariant1Item.FillMask,
                "graph-ml" => CreateQuicksearchRequestPipelinesVariant1Item.GraphMl,
                "image-classification" => CreateQuicksearchRequestPipelinesVariant1Item.ImageClassification,
                "image-feature-extraction" => CreateQuicksearchRequestPipelinesVariant1Item.ImageFeatureExtraction,
                "image-segmentation" => CreateQuicksearchRequestPipelinesVariant1Item.ImageSegmentation,
                "image-text-to-image" => CreateQuicksearchRequestPipelinesVariant1Item.ImageTextToImage,
                "image-text-to-text" => CreateQuicksearchRequestPipelinesVariant1Item.ImageTextToText,
                "image-text-to-video" => CreateQuicksearchRequestPipelinesVariant1Item.ImageTextToVideo,
                "image-to-3d" => CreateQuicksearchRequestPipelinesVariant1Item.ImageTo3d,
                "image-to-image" => CreateQuicksearchRequestPipelinesVariant1Item.ImageToImage,
                "image-to-text" => CreateQuicksearchRequestPipelinesVariant1Item.ImageToText,
                "image-to-video" => CreateQuicksearchRequestPipelinesVariant1Item.ImageToVideo,
                "keypoint-detection" => CreateQuicksearchRequestPipelinesVariant1Item.KeypointDetection,
                "mask-generation" => CreateQuicksearchRequestPipelinesVariant1Item.MaskGeneration,
                "multiple-choice" => CreateQuicksearchRequestPipelinesVariant1Item.MultipleChoice,
                "object-detection" => CreateQuicksearchRequestPipelinesVariant1Item.ObjectDetection,
                "other" => CreateQuicksearchRequestPipelinesVariant1Item.Other,
                "question-answering" => CreateQuicksearchRequestPipelinesVariant1Item.QuestionAnswering,
                "reinforcement-learning" => CreateQuicksearchRequestPipelinesVariant1Item.ReinforcementLearning,
                "robotics" => CreateQuicksearchRequestPipelinesVariant1Item.Robotics,
                "sentence-similarity" => CreateQuicksearchRequestPipelinesVariant1Item.SentenceSimilarity,
                "summarization" => CreateQuicksearchRequestPipelinesVariant1Item.Summarization,
                "table-question-answering" => CreateQuicksearchRequestPipelinesVariant1Item.TableQuestionAnswering,
                "table-to-text" => CreateQuicksearchRequestPipelinesVariant1Item.TableToText,
                "tabular-classification" => CreateQuicksearchRequestPipelinesVariant1Item.TabularClassification,
                "tabular-regression" => CreateQuicksearchRequestPipelinesVariant1Item.TabularRegression,
                "tabular-to-text" => CreateQuicksearchRequestPipelinesVariant1Item.TabularToText,
                "text-classification" => CreateQuicksearchRequestPipelinesVariant1Item.TextClassification,
                "text-generation" => CreateQuicksearchRequestPipelinesVariant1Item.TextGeneration,
                "text-ranking" => CreateQuicksearchRequestPipelinesVariant1Item.TextRanking,
                "text-retrieval" => CreateQuicksearchRequestPipelinesVariant1Item.TextRetrieval,
                "text-to-3d" => CreateQuicksearchRequestPipelinesVariant1Item.TextTo3d,
                "text-to-audio" => CreateQuicksearchRequestPipelinesVariant1Item.TextToAudio,
                "text-to-image" => CreateQuicksearchRequestPipelinesVariant1Item.TextToImage,
                "text-to-speech" => CreateQuicksearchRequestPipelinesVariant1Item.TextToSpeech,
                "text-to-video" => CreateQuicksearchRequestPipelinesVariant1Item.TextToVideo,
                "time-series-forecasting" => CreateQuicksearchRequestPipelinesVariant1Item.TimeSeriesForecasting,
                "token-classification" => CreateQuicksearchRequestPipelinesVariant1Item.TokenClassification,
                "translation" => CreateQuicksearchRequestPipelinesVariant1Item.Translation,
                "unconditional-image-generation" => CreateQuicksearchRequestPipelinesVariant1Item.UnconditionalImageGeneration,
                "video-classification" => CreateQuicksearchRequestPipelinesVariant1Item.VideoClassification,
                "video-text-to-text" => CreateQuicksearchRequestPipelinesVariant1Item.VideoTextToText,
                "video-to-video" => CreateQuicksearchRequestPipelinesVariant1Item.VideoToVideo,
                "visual-document-retrieval" => CreateQuicksearchRequestPipelinesVariant1Item.VisualDocumentRetrieval,
                "visual-question-answering" => CreateQuicksearchRequestPipelinesVariant1Item.VisualQuestionAnswering,
                "voice-activity-detection" => CreateQuicksearchRequestPipelinesVariant1Item.VoiceActivityDetection,
                "zero-shot-classification" => CreateQuicksearchRequestPipelinesVariant1Item.ZeroShotClassification,
                "zero-shot-image-classification" => CreateQuicksearchRequestPipelinesVariant1Item.ZeroShotImageClassification,
                "zero-shot-object-detection" => CreateQuicksearchRequestPipelinesVariant1Item.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}