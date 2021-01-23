using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryMobile.Backend.Module.DTO
{
    public class FamousPeopleDTO
    {
        public string Code { get; set; }

        public string Image { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Detail { get; set; }

        public List<string> CategoryOids { get; set; }
    }
}
