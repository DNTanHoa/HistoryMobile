using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryMobile.Models
{
    public class HistoryEvent
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public string ReferenceSource { get; set; }
        public string Detail { get; set; }
    }
}
