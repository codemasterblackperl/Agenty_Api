using Codemasters_Agenty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codemasters_Agenty.DataRepo
{
    public interface IMyResumeRepo
    {
        Task<MyResume> GetAsync(long id);

        Task<long> PostAsync(MyResume vm);
    }
}