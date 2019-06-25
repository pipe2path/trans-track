using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using trans_track.Models;

namespace trans_track
{
    public interface ICommon
    {
        void UploadImage(Vehicle vehicle, IFormFile file);
    }

    public class Common : ICommon
    {
        private readonly IConfiguration _config;

        public Common(IConfiguration config)
        {
            _config = config;
        }

        public void UploadImage(Vehicle vehicle, IFormFile file)
        {
            string bucketName = _config.GetSection("AWS").GetValue<string>("bucketName");
            string awsAccessKeyId = _config.GetSection("AWS").GetValue<string>("accessKeyId");
            string awsSecretAccessKey = _config.GetSection("AWS").GetValue<string>("secretAccessKey");
            string keyName = vehicle.License + ".jpg";

            if (file != null && file.Length > 0)
            {
                using (var client = new AmazonS3Client(awsAccessKeyId, awsSecretAccessKey, RegionEndpoint.USWest2))
                {
                    using (var newMemoryStream = new MemoryStream())
                    {
                        file.CopyTo(newMemoryStream);
                        var uploadRequest = new TransferUtilityUploadRequest
                        {
                            InputStream = newMemoryStream,
                            Key = keyName,
                            BucketName = bucketName,
                            CannedACL = S3CannedACL.PublicRead
                        };

                        var fileTransferUtility = new TransferUtility(client);
                        fileTransferUtility.Upload(uploadRequest);
                    }

                    vehicle.ImagePath = _config.GetSection("AWS").GetValue<string>("imageBasePath") + "/" + keyName;
                }
            }
        }
    }

}
