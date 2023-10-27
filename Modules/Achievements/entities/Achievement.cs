using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VideoGamesApi.Modules.Games.entities;

namespace VideoGamesApi.Modules.Achievements.entities
{
    public class Achievement
    {
        [Key]
        public int AchievementId { get; set; }

        [Required]
        public string Description { get; set; }

        public string? HowToUnlock { get; set; }
        public string? RepresentationalImage { get; set; }

        [Required]
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}