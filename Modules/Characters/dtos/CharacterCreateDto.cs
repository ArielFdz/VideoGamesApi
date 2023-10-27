using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGamesApi.Modules.Characters.dtos
{
    public class CharacterCreateDto
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public string Abilities { get; set; }
        public string Statistics { get; set; }
        public string BackgroundStory { get; set; }
        public string Relationships { get; set; }

        [Required]
        public int GameId { get; set; }
    }
}