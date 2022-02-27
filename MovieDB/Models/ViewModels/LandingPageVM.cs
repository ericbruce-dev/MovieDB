using MovieDB.Models.Database;
using MovieDB.Models.TMDB;
using System.Collections.Generic;

namespace MovieDB.Models.ViewModels
{
    public class LandingPageVM
    {
        public List<Collection> CustomCollections { get; set; }
        public MovieSearch NowPlaying { get; set; }
        public MovieSearch Popular { get; set; }
        public MovieSearch TopeRated { get; set; }
        public MovieSearch Upcoming { get; set; }
    }
}
