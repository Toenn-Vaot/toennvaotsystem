using Microsoft.AspNetCore.Mvc;

namespace ToennVaot.Components.Core.Api.Results
{
    /// <summary>
    /// Represents an <see cref="FileContentResult"/> that when executed will write a PDF file content as the response.
    /// </summary>
    public class PdfContentResult : FileContentResult
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fileContents">The binary content of the file</param>
        public PdfContentResult(byte[] fileContents) 
            : base(fileContents, "application/pdf")
        {
            FileDownloadName = "content.pdf";
        }
    }
}
