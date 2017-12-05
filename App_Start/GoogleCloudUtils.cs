using Google.Apis.Auth.OAuth2;
using Google.Apis.Storage.v1.Data;
using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GoogleCloudSamples.App_Start
{
    public class GoogleCloudUtils
    {
        public Bucket AuthExplicit(string projectId, string jsonPath, string bucketName)
        {
            // Explicitly use service account credentials by specifying the private key
            // file.
            GoogleCredential credential = null;
            using (var jsonStream = new FileStream(jsonPath, FileMode.Open,
                FileAccess.Read, FileShare.Read))
            {
                credential = GoogleCredential.FromStream(jsonStream);
            }
            var storage = StorageClient.Create(credential);
            return storage.GetBucket(bucketName);
        }
    }

}