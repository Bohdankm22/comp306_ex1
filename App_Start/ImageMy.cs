using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GoogleCloudSamples
{
     public class ImageMy
    {
        private readonly string _bucketName;
        private readonly StorageClient _storageClient;
        
        public ImageMy(string bucketName)
        {
            _bucketName = bucketName;
            _storageClient = StorageClient.Create();
        }

        // [START uploadimage]
        public async Task<string> UploadImage(HttpPostedFileBase image, string id)
        {
            var imageAcl = PredefinedObjectAcl.PublicRead;

            var imageObject = await _storageClient.UploadObjectAsync(
                bucket: _bucketName,
                objectName: id,
                contentType: image.ContentType,
                source: image.InputStream,
                options: new UploadObjectOptions { PredefinedAcl = imageAcl }
            );

            return imageObject.MediaLink;
        }

        internal static object getInstance()
        {
            throw new NotImplementedException();
        }
        // [END uploadimage]

    }
}