using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VideoGamesApi.Modules.Games.entities;

namespace VideoGamesApi.Modules.Comments_Reviews.entities
{
    public class CommentReview
{
    [Key]
    public int CommentReviewId { get; set; }

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
    public Game Game { get; set; }
}
}