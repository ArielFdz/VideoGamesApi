using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGamesApi.Modules.Comments_Reviews.dtos
{
    public class CommentReviewCreateDto
    {
        [Required]
        public string Content { get; set; }

        [Required]
        [MaxLength(255)]
        public string UserName { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Range(1, 5)]
        public int GameRating { get; set; }

        [Required]
        public int GameId { get; set; }
    }
}