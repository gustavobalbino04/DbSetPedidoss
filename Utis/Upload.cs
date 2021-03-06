using System;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace  DbSetPedidos.Utis
{
    public static class Upload
    {
        public static string Local(IFormFile file){
            var nomeArquivo = Guid.NewGuid().ToString().Replace("-","") + Path.GetExtension(file.FileName);
                    var caminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(),@"wwwRoot\upload\imagens", nomeArquivo);
                    using var streamImagem = new FileStream(caminhoArquivo, FileMode.Create);
                    file.CopyTo(streamImagem);

                  return  "http://localhost:50001/upload/imagens/" + nomeArquivo;
        }
    }
}