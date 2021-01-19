using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryMobile.Models
{
    public class Video
    {
        public Guid Oid { get; set; }

        public string Title { get; set; }

        public string Link { get; set; }

        public string CategoryOid { get; set; }
    }
}
