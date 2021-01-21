using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryMobile.Backend.Module.DTO
{
    public class CategoryVideoDTO
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public Guid Oid { get; set; }

        public string Image { get; set; }
    }
}
