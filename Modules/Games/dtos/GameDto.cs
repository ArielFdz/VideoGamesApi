using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGamesApi.Modules.Achievements.dtos;
using VideoGamesApi.Modules.Characters.dtos;
using VideoGamesApi.Modules.Comments_Reviews.dtos;
using VideoGamesApi.Modules.Guides.dtos;

namespace VideoGamesApi.Modules.Games.dtos
{
    public class GameDto
    {
        public int GameId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Developer { get; set; }
        public string Genre { get; set; }
        public string SpecialEditions { get; set; }
        public string AvailableVersions { get; set; }

        public ICollection<CharacterDto> Characters { get; set; }
        public ICollection<AchievementDto> Achievements { get; set; }
        public ICollection<GuideDto> Guides { get; set; }
        public ICollection<CommentReviewDto> CommentsReviews { get; set; }
    }
}