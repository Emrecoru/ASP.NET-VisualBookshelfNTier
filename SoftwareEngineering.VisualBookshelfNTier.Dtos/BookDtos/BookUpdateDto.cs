using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class BookUpdateDto : IUpdateDto
    {
        public int Id { get; set; }

        public int BookApiId { get; set; }

        public string Title { get; set; }

        public bool isCopyright { get; set; }

        public string MediaType { get; set; }

        public int DownloadCount { get; set; }

        public string txtUrl { get; set; }

        public string imgUrl { get; set; }
    }
}
