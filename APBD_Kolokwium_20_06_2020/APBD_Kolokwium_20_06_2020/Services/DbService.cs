using APBD_Kolokwium_20_06_2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_20_06_2020.Services
{
    public class DbService : IDbService
    {
        
        public IEnumerable<Response_GetTeams> GetTeams(string IdMistrzostwa)
        {
            
            var myContext = new DBContext();
            ICollection<Response_GetTeams> response;

            response = myContext.Championship_Team
               .Where(c => c.IdChampionship == IdMistrzostwa)
               .ToList();



            return response;
            
        }
        
    }
}
