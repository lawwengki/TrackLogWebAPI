using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBaseLib.Models
{
    public class SampleModel
    {
        public int? SeqNo { get; set; }
        public Guid SampleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
