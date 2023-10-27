using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VideoGamesApi.Modules.Games.entities;

namespace VideoGamesApi.Modules.Guides.entities
{
    public class Guide
    {
        [Key]
        public int GuideId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public string? Description { get; set; }
        public string? Content { get; set; }

        [Required]
        [MaxLength(255)]
        public string Author { get; set; }

        [Required]
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}