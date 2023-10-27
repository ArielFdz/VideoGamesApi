using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VideoGamesApi.Modules.Achievements.entities;
using VideoGamesApi.Modules.Characters.entities;
using VideoGamesApi.Modules.Comments_Reviews.entities;
using VideoGamesApi.Modules.Guides.entities;

namespace VideoGamesApi.Modules.Games.entities
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [MaxLength(255)]
        public string Developer { get; set; }

        [Required]
        [MaxLength(255)]
        public string Genre { get; set; }

        public string? SpecialEditions { get; set; }
        public string? AvailableVersions { get; set; }

        public ICollection<Character> Characters { get; set; }
        public ICollection<Achievement> Achievements { get; set; }
        public ICollection<Guide> Guides { get; set; }
        public ICollection<CommentReview> CommentsReviews { get; set; }
    }
}