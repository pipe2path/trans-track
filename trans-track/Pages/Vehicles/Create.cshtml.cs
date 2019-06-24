using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using trans_track.Data;
using trans_track.Models;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Amazon.S3;
using Amazon;
using Amazon.S3.Transfer;
using Microsoft.Extensions.Configuration;

namespace trans_track.Pages.Vehicle
{
    public class CreateModel : PageModel
    {
        private readonly trans_track.Data.ApplicationDbContext _context;
        private readonly IConfiguration _config;
        
        public CreateModel(trans_track.Data.ApplicationDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public trans_track.Models.Vehicle Vehicle { get; set; }

        public async Task<IActionResult> OnPostAsync(IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string bucketName = _config.GetSection("AWS").GetValue<string>("bucketName");
            string awsAccessKeyId = _config.GetSection("AWS").GetValue<string>("accessKeyId");
            string awsSecretAccessKey = _config.GetSection("AWS").GetValue<string>("secretAccessKey");
            string keyName = Vehicle.License + ".jpg";

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
                        await fileTransferUtility.UploadAsync(uploadRequest);
                    }

                    Vehicle.ImagePath = _config.GetSection("AWS").GetValue<string>("imageBasePath") + "/" + keyName;
                }
            }
            
            _context.Vehicle.Add(Vehicle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}