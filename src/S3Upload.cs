﻿using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;

namespace ImageTextExtraction
{
    public class S3Upload
    {
        //Points S3 to the desired region.
        private static readonly RegionEndpoint regionEndpoint = RegionEndpoint.EUWest1;
        //Interface for accessing S3
        private static IAmazonS3 s3Client;

        public static async Task UploadFileAsync(Stream FileStream, string bucketName, string fileKey)
        {
            s3Client = new AmazonS3Client(regionEndpoint);
            var fileTransferUtility = new TransferUtility(s3Client);
            await fileTransferUtility.UploadAsync(FileStream, bucketName, fileKey);
        }
    }
}
