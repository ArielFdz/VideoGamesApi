using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGamesApi.Modules.Comments_Reviews.dtos
{
    public class CommentReviewDto
    {
        public int CommentReviewId { get; set; }
        public string Content { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public int GameRating { get; set; }
    }
}