
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseLinkedModelAvailableInferenceProviderTask
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
    public static class GetPapersResponseLinkedModelAvailableInferenceProviderTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedModelAvailableInferenceProviderTask value)
        {
            return value switch
            {
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.AnyToAny => "any-to-any",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.AudioClassification => "audio-classification",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.AudioTextToText => "audio-text-to-text",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.AudioToAudio => "audio-to-audio",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.AutomaticSpeechRecognition => "automatic-speech-recognition",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.Conversational => "conversational",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.DepthEstimation => "depth-estimation",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.DocumentQuestionAnswering => "document-question-answering",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.FeatureExtraction => "feature-extraction",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.FillMask => "fill-mask",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.GraphMl => "graph-ml",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageClassification => "image-classification",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageFeatureExtraction => "image-feature-extraction",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageSegmentation => "image-segmentation",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageTextToImage => "image-text-to-image",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageTextToText => "image-text-to-text",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageTextToVideo => "image-text-to-video",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageTo3d => "image-to-3d",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageToImage => "image-to-image",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageToText => "image-to-text",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageToVideo => "image-to-video",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.KeypointDetection => "keypoint-detection",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.MaskGeneration => "mask-generation",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.MultipleChoice => "multiple-choice",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ObjectDetection => "object-detection",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.Other => "other",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.QuestionAnswering => "question-answering",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ReinforcementLearning => "reinforcement-learning",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.Robotics => "robotics",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.SentenceSimilarity => "sentence-similarity",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.Summarization => "summarization",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TableQuestionAnswering => "table-question-answering",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TableToText => "table-to-text",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TabularClassification => "tabular-classification",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TabularRegression => "tabular-regression",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TabularToText => "tabular-to-text",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextClassification => "text-classification",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextGeneration => "text-generation",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextRanking => "text-ranking",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextRetrieval => "text-retrieval",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextTo3d => "text-to-3d",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextToAudio => "text-to-audio",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextToImage => "text-to-image",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextToSpeech => "text-to-speech",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextToVideo => "text-to-video",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TimeSeriesForecasting => "time-series-forecasting",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.TokenClassification => "token-classification",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.Translation => "translation",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.UnconditionalImageGeneration => "unconditional-image-generation",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.VideoClassification => "video-classification",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.VideoTextToText => "video-text-to-text",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.VideoToVideo => "video-to-video",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.VisualDocumentRetrieval => "visual-document-retrieval",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.VisualQuestionAnswering => "visual-question-answering",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.VoiceActivityDetection => "voice-activity-detection",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ZeroShotClassification => "zero-shot-classification",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ZeroShotImageClassification => "zero-shot-image-classification",
                GetPapersResponseLinkedModelAvailableInferenceProviderTask.ZeroShotObjectDetection => "zero-shot-object-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedModelAvailableInferenceProviderTask? ToEnum(string value)
        {
            return value switch
            {
                "any-to-any" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.AnyToAny,
                "audio-classification" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.AudioClassification,
                "audio-text-to-text" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.AudioTextToText,
                "audio-to-audio" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.AudioToAudio,
                "automatic-speech-recognition" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.AutomaticSpeechRecognition,
                "conversational" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.Conversational,
                "depth-estimation" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.DepthEstimation,
                "document-question-answering" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.DocumentQuestionAnswering,
                "feature-extraction" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.FeatureExtraction,
                "fill-mask" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.FillMask,
                "graph-ml" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.GraphMl,
                "image-classification" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageClassification,
                "image-feature-extraction" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageFeatureExtraction,
                "image-segmentation" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageSegmentation,
                "image-text-to-image" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageTextToImage,
                "image-text-to-text" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageTextToText,
                "image-text-to-video" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageTextToVideo,
                "image-to-3d" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageTo3d,
                "image-to-image" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageToImage,
                "image-to-text" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageToText,
                "image-to-video" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ImageToVideo,
                "keypoint-detection" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.KeypointDetection,
                "mask-generation" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.MaskGeneration,
                "multiple-choice" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.MultipleChoice,
                "object-detection" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ObjectDetection,
                "other" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.Other,
                "question-answering" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.QuestionAnswering,
                "reinforcement-learning" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ReinforcementLearning,
                "robotics" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.Robotics,
                "sentence-similarity" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.SentenceSimilarity,
                "summarization" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.Summarization,
                "table-question-answering" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TableQuestionAnswering,
                "table-to-text" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TableToText,
                "tabular-classification" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TabularClassification,
                "tabular-regression" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TabularRegression,
                "tabular-to-text" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TabularToText,
                "text-classification" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextClassification,
                "text-generation" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextGeneration,
                "text-ranking" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextRanking,
                "text-retrieval" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextRetrieval,
                "text-to-3d" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextTo3d,
                "text-to-audio" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextToAudio,
                "text-to-image" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextToImage,
                "text-to-speech" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextToSpeech,
                "text-to-video" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TextToVideo,
                "time-series-forecasting" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TimeSeriesForecasting,
                "token-classification" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.TokenClassification,
                "translation" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.Translation,
                "unconditional-image-generation" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.UnconditionalImageGeneration,
                "video-classification" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.VideoClassification,
                "video-text-to-text" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.VideoTextToText,
                "video-to-video" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.VideoToVideo,
                "visual-document-retrieval" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.VisualDocumentRetrieval,
                "visual-question-answering" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.VisualQuestionAnswering,
                "voice-activity-detection" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.VoiceActivityDetection,
                "zero-shot-classification" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ZeroShotClassification,
                "zero-shot-image-classification" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ZeroShotImageClassification,
                "zero-shot-object-detection" => GetPapersResponseLinkedModelAvailableInferenceProviderTask.ZeroShotObjectDetection,
                _ => null,
            };
        }
    }
}