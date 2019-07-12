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
        MyResume Get(long id);

        long Post(MyResume vm);

        bool Delete(long id);
    }
}