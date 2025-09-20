namespace ToennVaot.Components.Core.Api.Exceptions
{
    /// <summary>
    /// Exception triggered when missing known type attribute on base type
    /// </summary>
    /// <param name="baseType">The base type over the attribute should be located</param>
    public class MissingKnownTypeAttributeException(string baseType) : Exception($"At least one KnownType attribute should be set up on the base type [{baseType}]. Please define at least one KnownTypeAttribute to determine the sub-type.");
}
