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
        private readonly LiteDatabase _context;

        public LDbContext(IOptions<LDbConfig> options)
        {
            try
            {
                var db = new LiteDatabase(options.Value.ConnectionString);
                _context = db;
            }
            catch (Exception ex)
            {
                throw new Exception("Can find or create LiteDb database.", ex);
            }
        }
    }
}