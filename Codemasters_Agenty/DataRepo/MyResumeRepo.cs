using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codemasters_Agenty.Data;
using Codemasters_Agenty.Models;
using LiteDB;

namespace Codemasters_Agenty.DataRepo
{
    public class MyResumeRepo : IMyResumeRepo
    {
        private readonly LiteCollection<MyResume> Resumes;

        public MyResumeRepo(LDbContext context)
        {
            Resumes = context.LDb.GetCollection<MyResume>();
        }

        public bool Delete(long id)
        {
            return Resumes.Delete(id);
        }

        public MyResume Get(long id)
        {
            return Resumes.FindById(id);
        }

        public long Post(MyResume vm)
        {
            return Resumes.Insert(vm);
        }
    }
}