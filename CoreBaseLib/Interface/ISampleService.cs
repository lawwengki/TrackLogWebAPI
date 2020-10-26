using CoreBaseLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBaseLib.Sample
{
    public interface ISampleService
    {
        RVal AddData(SampleModel data);
        RVal EditData(SampleModel data);
        SampleModel GetData(Guid sampleId);
    }
}
