using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGamesApi.Modules.Achievements.dtos
{
    public class AchievementCreateDto
    {
        [Required]
        public string Description { get; set; }

        public string HowToUnlock { get; set; }
        public string RepresentationalImage { get; set; }

        [Required]
        public int GameId { get; set; }
    }
}