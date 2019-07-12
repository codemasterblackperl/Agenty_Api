using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codemasters_Agenty.Models;

namespace Codemasters_Agenty.DataRepo
{
    public class MyResumeRepo : IMyResumeRepo
    {
        public Task<MyResume> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<long> PostAsync(MyResume vm)
        {
            throw new NotImplementedException();
        }
    }
}