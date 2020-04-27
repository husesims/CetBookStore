using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.ViewModel
{
    public class ImageUploadViewModel
    {
        public int BookId { get; set; }
        public  IFormFile ImageFile { get; set; }
    }
}
