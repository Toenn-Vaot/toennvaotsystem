using Newtonsoft.Json;

namespace ToennVaot.Components.Core.Api.Models;

/// <summary>
/// This class describes the model of an Error
/// </summary>
public class ErrorModel
{
    /// <summary>
    /// The error key
    /// </summary>
    [JsonProperty("key")]
    public string Key { get; set; }

    /// <summary>
    /// The error code (format: 'ComponentId'-'ErrorId')
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// The error message
    /// </summary>
    [JsonProperty("message")]
    public string Message { get; set; }
}