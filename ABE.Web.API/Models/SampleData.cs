using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABE.Web.API.Models
{
    public class SampleData
    {
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }



        public static List<SampleData> GetSomeSamples()
        {
            List<SampleData> sampleDatas = new List<SampleData>();

            for (int i = 0; i < 10; i++)
            {
                sampleDatas.Add(new SampleData()
                {
                    CreatedOn = DateTime.Now,
                    CreatedBy = i.ToString()
                });
            }

            return sampleDatas;
        }
    }
}
