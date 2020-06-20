using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_20_06_2020.Models
{
    public class Response_GetTeams
    {
        public float Score { get; set; }
        [MaxLength(30)]
        public string TeamName { get; set; }
        [MaxLength(100)]
        public string OfficialName { get; set; }
    }
}
