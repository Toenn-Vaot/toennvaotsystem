using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToennVaot.Components.Core.Extensions
{
    /// <summary>
    /// This class extends byte arrays
    /// </summary>
    public static class BytesExtensions
    {
        /// <summary>
        /// Detects the content-type of a byte array based on its signature.
        /// </summary>
        /// <param name="bytes">The bytes</param>
        /// <returns>The detected content type</returns>
        public static string DetectContentType(this byte[] bytes)
        {
            var ansiString = Encoding.ASCII.GetString(bytes);
            if(ansiString.StartsWith("%PDF-"))
                return "application/pdf";
            if(ansiString.StartsWith("GIF8"))
                return "image/gif";
            if(ansiString.StartsWith("\u0089PNG")
               || ansiString.StartsWith("\u2030PNG\u240d\u240a\u241a\u240a")
            )
                return "image/png";
            if(ansiString.StartsWith("\xFF\xD8") 
               || ansiString.StartsWith("ÿØÿÛ") 
               || ansiString.StartsWith("ÿOÿQ")  
               || ansiString.StartsWith("ÿØÿà")
               || ansiString.StartsWith("ÿØÿá??Exif\u2400\u2400")
               || ansiString.StartsWith("\u2400\u2400\u2400\u240cjP\u2420\u2420\u240d\u240a‡\u240a")
            )
                return "image/jpeg";
            if(ansiString.StartsWith("PK"))
                return "application/zip";
            if(ansiString.StartsWith("BM"))
                return "image/bmp";
            if(ansiString.StartsWith("II*\\u2400") || ansiString.StartsWith("MM\\u2400*"))
                return "image/tiff";
            if(ansiString.StartsWith("GIF87a")
               || ansiString.StartsWith("GIF89a")
            )
                return "image/gif";
            // Default to binary stream
            return "application/octet-stream";
        }
    }
}
