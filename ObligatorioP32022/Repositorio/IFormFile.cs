using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Dominio;
using System.Threading.Tasks;
using System.Threading;

namespace Microsoft.AspNetCore.Http
{
    public interface IFormFile
    {
        string ContentType { get; }
        string ContentDisposition { get; }
        IHeaderDictionary Headers { get; }
        long Length { get; }
        string Name { get; }
        string FileName { get; }
        Stream OpenReadStream();
        void CopyTo(Stream target);
    }

}
