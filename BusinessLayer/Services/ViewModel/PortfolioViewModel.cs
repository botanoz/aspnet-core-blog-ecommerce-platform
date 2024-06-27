using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.ViewModel
{
    public class PortfolioViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Client { get; set; }

        [Required]
        [StringLength(2083)]
        public string ProjectUrl { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(2000)]
        public string Description { get; set; }

        [Required]
        public string UserId { get; set; }

        public IFormFile Thumbnail { get; set; }
        public string ThumbnailPath { get; set; }
    }

}
