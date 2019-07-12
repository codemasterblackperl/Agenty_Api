using LiteDB;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codemasters_Agenty.Data
{
    public class LDbContext
    {
        public readonly LiteDatabase LDb;

        public LDbContext(IOptions<LDbConfig> options)
        {
            try
            {
                var db = new LiteDatabase(options.Value.ConnectionString);
                LDb = db;
            }
            catch (Exception ex)
            {
                throw new Exception("Can find or create LiteDb database.", ex);
            }
        }
    }
}