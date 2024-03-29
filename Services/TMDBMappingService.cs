﻿using Microsoft.Extensions.Options;
using MovieDB.Enums;
using MovieDB.Models.Database;
using MovieDB.Models.Settings;
using MovieDB.Models.TMDB;
using MovieDB.Services.Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDB.Services
{
    public class TMDBMappingService : IDataMappingService
    {
        private AppSettings _appSettings;
        private readonly IImageService _imageService;

        public TMDBMappingService(IOptions<AppSettings> appSettings, IImageService imageService)
        {
            _appSettings = appSettings.Value;
            _imageService = imageService;
        }

        public ActorDetail MapActorDetail(ActorDetail actor)
        {
            //Image
            actor.profile_path = BuildCastImage(actor.profile_path);

            //Bio
            if (string.IsNullOrEmpty(actor.biography))
                actor.biography = "Not Available";

            //Place Of Birth
            if (string.IsNullOrEmpty(actor.place_of_birth))
                actor.place_of_birth = "Not Available";

            //Birthday
            if (string.IsNullOrEmpty(actor.birthday))
                actor.birthday = "Not Available";
            else
                actor.birthday = DateTime.Parse(actor.birthday).ToString("MMM dd, yyyy");

            return actor;
        }

        public async Task<Movie> MapMovieDetailAsync(MovieDetail movie)
        {
            Movie newMovie = null;

            try
            {
                newMovie = new Movie()
                {
                    MovieId = movie.id,
                    Title = movie.title,
                    TagLine = movie.tagline,
                    Overview = movie.overview,
                    RunTime = movie.runtime,
                    VoteAverage = movie.vote_average,
                    ReleaseDate = DateTime.Parse(movie.release_date).ToString("MMM dd, yyyy"),
                    TrailerUrl = BuildTrailerPath(movie.videos),
                    Backdrop = await EncodeBackdropImageAsync(movie.backdrop_path),
                    BackdropType = BuildImageType(movie.backdrop_path),
                    Poster = await EncodePosterImageAsync(movie.poster_path),
                    Rating = GetRating(movie.release_dates)
                };

                var castMembers = movie.credits.cast.OrderByDescending(c => c.popularity)
                                                    .GroupBy(c => c.cast_id)
                                                    .Select(g => g.FirstOrDefault())
                                                    .Take(20)
                                                    .ToList();

                castMembers.ForEach(member =>
                {
                    newMovie.Cast.Add(new MovieCast()
                    {
                        CastID = member.id,
                        Department = member.known_for_department,
                        Name = member.name,
                        Character = member.character,
                        ImageUrl = BuildCastImage(member.profile_path)
                    });
                });

                var crewMembers = movie.credits.crew.OrderByDescending(c => c.popularity)
                                                    .GroupBy(c => c.id)
                                                    .Select(g => g.First())
                                                    .Take(20)
                                                    .ToList();

                crewMembers.ForEach(member =>
                {
                    newMovie.Crew.Add(new MovieCrew()
                    {
                        CrewID = member.id,
                        Department = member.department,
                        Name = member.name,
                        Job = member.job,
                        ImageUrl = BuildCastImage(member.profile_path)
                    });
                });
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Exception in MapMovieDetailAsync: {ex.Message}");
            }

            return newMovie;
        }

        private string BuildCastImage(string profilePath)
        {
            if (string.IsNullOrEmpty(profilePath))
                return _appSettings.MovieDbSettings.DefaultCastImage;

            return $"{_appSettings.TMDBSettings.BaseImagePath}/{_appSettings.MovieDbSettings.DefaultPosterSize}/{profilePath}";
        }

        private MovieRating GetRating(Release_Dates dates)
        {
            var movieRating = MovieRating.NR;
            var certification = dates.results.FirstOrDefault(r => r.iso_3166_1 == "US");
            if (certification != null)
            {
                var apiRating = certification.release_dates.FirstOrDefault(c => c.certification != "")?.certification.Replace("-", "");
                if (!string.IsNullOrEmpty(apiRating))
                {
                    movieRating = (MovieRating)Enum.Parse(typeof(MovieRating), apiRating, true);
                }
            }

            return movieRating;
        }

        private async Task<byte[]> EncodePosterImageAsync(string path)
        {
            var posterPath = $"{_appSettings.TMDBSettings.BaseImagePath}/{_appSettings.MovieDbSettings.DefaultPosterSize}/{path}";
            return await _imageService.EncodeImageURLAsync(posterPath);
        }

        private string BuildImageType(string path)
        {
            if (string.IsNullOrEmpty(path))
                return path;

            return $"image/{Path.GetExtension(path).TrimStart('.')}";
        }

        private async Task<byte[]> EncodeBackdropImageAsync(string path)
        {
            var backdropPath = $"{_appSettings.TMDBSettings.BaseImagePath}/{_appSettings.MovieDbSettings.DefaultBackdropSize}/{path}";
            return await _imageService.EncodeImageURLAsync(backdropPath);
        }

        private string BuildTrailerPath(Videos videos)
        {
            if (videos != null)
            {
                var videoKey = videos.results.FirstOrDefault(r => r.type == "Trailer" && r.key != "")?.key;
                return string.IsNullOrEmpty(videoKey) ? videoKey : $"{_appSettings.TMDBSettings.BaseYouTubePath}{videoKey}";
            }

            else
            {
                return $"{_appSettings.TMDBSettings.BaseYouTubePath}PTe-8dX3NtY";
            }
        }
    }
}
