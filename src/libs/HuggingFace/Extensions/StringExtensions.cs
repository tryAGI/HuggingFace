namespace HuggingFace;

/// <summary>
/// 
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string AsHumanMessage(this string content)
    {
        return $"Human: {content}";
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string AsAssistantMessage(this string content)
    {
        return $"Assistant: {content}";
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string AsPrompt(this string content)
    {
        return $"\n\n${content.AsHumanMessage()}\n\nAssistant:";
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string AsPrompt(this string[] content)
    {
        return AsPrompt(string.Join("\n\n", content));
    }
}