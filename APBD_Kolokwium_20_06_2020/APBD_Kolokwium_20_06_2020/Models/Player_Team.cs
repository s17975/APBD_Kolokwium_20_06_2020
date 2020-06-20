using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_20_06_2020.Models
{
    public class Player_Team
    {
        public int IdPlayer { get; set; }
        public int IdTeam { get; set; }
        public int NumOfShirt { get; set; }
        [MaxLength(300)]
        public string? Comment { get; set; }
    }
}
