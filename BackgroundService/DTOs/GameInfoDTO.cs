﻿using System.ComponentModel.DataAnnotations;

namespace BackgroundService.DTOs
{
    public class GameInfoDTO
    {
        // TODO: Include l'information à propos du nombre de victoire ET le coût d'un multiplier
       public int nbWins { get; set; }
        public int coutMultiplier { get; set; }
    }
}
