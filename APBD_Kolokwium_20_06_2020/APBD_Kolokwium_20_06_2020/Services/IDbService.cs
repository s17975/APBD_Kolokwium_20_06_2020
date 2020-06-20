using APBD_Kolokwium_20_06_2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_20_06_2020.Services
{
    public interface IDbService
    {
        IEnumerable<Response_GetTeams> GetTeams(string IdMistrzostwa);
    }
}
