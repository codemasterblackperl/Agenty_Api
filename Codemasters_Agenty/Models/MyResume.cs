using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codemasters_Agenty.Models
{
    public class MyResume
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Skills { get; set; }
        public double Experiance { get; set; }

        //public List<Experiance> Experiances { get; set; }
    }

    //public class Experiance
    //{
    //    public string SkillName { get; set; }
    //    public string Experience { get; set; }
    //}
}