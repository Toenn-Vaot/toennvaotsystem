namespace ToennVaot.Components.Core.Api.Exceptions
{
    /// <summary>
    /// Exception triggered when the discriminator value used in class doesn't exist in the list of declared subtypes in API definition
    /// </summary>
    /// <param name="derivedTypeName"></param>
    public class DiscriminatorOutOfRangeException(string derivedTypeName) : Exception($"Discriminator '{derivedTypeName}' doesn't match any of the defined sub-types via KnownTypeAttributes")
    {
    }
}
