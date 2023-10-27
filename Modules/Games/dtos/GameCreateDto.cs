using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGamesApi.Modules.Games.dtos
{
    public class GameCreateDto
    {
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

        public string SpecialEditions { get; set; }
        public string AvailableVersions { get; set; }
    }

}