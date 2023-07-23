namespace HuggingFace;

/// <summary>
/// 
/// </summary>
public static class ApiHelpers
{
    /// <summary>
    /// Calculates the maximum number of tokens possible to generate for a model. <br/>
    /// According https://huggingface.co/docs/api-inference/detailed_parameters#text-generation-task <br/>
    /// </summary>
    /// <param name="modelId"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static int CalculateContextLength(string modelId)
    {
        return modelId switch
        {
            RecommendedModelIds.Gpt2 => 250,
            
            _ => throw new NotImplementedException(),
        };
    }
}