using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Dominio;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace Repositorio
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
        Task CopyToAsync(Stream target, CancellationToken
       cancellationToken = null);
    }

}
