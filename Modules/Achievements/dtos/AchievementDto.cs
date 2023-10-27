using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGamesApi.Modules.Achievements.dtos
{
    public class AchievementDto
    {
        public int AchievementId { get; set; }
        public string Description { get; set; }
        public string HowToUnlock { get; set; }
        public string RepresentationalImage { get; set; }
    }
}