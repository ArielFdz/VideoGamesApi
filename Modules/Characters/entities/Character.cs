using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VideoGamesApi.Modules.Games.entities;

namespace VideoGamesApi.Modules.Characters.entities
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public string? Abilities { get; set; }
        public string? Statistics { get; set; }
        public string? BackgroundStory { get; set; }
        public string? Relationships { get; set; }

        [Required]
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}