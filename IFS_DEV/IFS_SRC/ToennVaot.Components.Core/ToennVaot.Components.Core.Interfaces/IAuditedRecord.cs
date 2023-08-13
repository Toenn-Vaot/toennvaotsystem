using System.Net.Http.Json;
using System.Text.Json;

namespace ToennVaot.Components.Core.Interfaces;

/// <summary>
/// Interface defines an audited record
/// </summary>
public interface IAuditedRecord
{
    /// <summary>
    /// Flag indicating if the personal data can be audited or not
    /// </summary>
    /// <remarks>Default is false</remarks>
    bool GdprRestrictedAudit { get; set; }

    /// <summary>
    /// Generate the JSON content string to audit
    /// </summary>
    /// <param name="options">The serializer options to use</param>
    /// <returns>The JSON content</returns>
    Task<JsonContent> GenerateAuditRecordAsync(JsonSerializerOptions options);
}