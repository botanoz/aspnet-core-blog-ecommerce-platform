using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.SystemServices
{
    public static class UploadImage
    {
        public static async Task<string> UploadThumbnailAsync(IFormFile thumbnail,string uploadsFolder,string root)
        {
            if (thumbnail == null)
            {
                return null;
            }

            Directory.CreateDirectory(uploadsFolder);
            var fileName = Path.GetFileNameWithoutExtension(thumbnail.FileName);
            var extension = Path.GetExtension(thumbnail.FileName);
            var newFileName = $"{fileName}_{DateTime.Now:yyyyMMddHHmmss}{extension}";
            var filePath = Path.Combine(uploadsFolder, newFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await thumbnail.CopyToAsync(stream);
            }

            return $"/{root}/{newFileName}";
        }
    }
}
