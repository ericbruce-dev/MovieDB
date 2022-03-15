﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MovieDB.Data;
using MovieDB.Models.Database;
using MovieDB.Models.Settings;
using MovieDB.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDB.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppSettings _appSettings;
        private readonly ApplicationDbContext _context;
        private readonly IImageService _imageService;
        private readonly IRemoteMovieService _tmdbMovieService;
        private readonly IDataMappingService _tmdbMappingService;

        public MoviesController(IOptions<AppSettings> appSettings, ApplicationDbContext context, IImageService imageService, IRemoteMovieService tmdbMovieService, IDataMappingService tmdbMappingService)
        {
            _appSettings = appSettings.Value;
            _context = context;
            _imageService = imageService;
            _tmdbMovieService = tmdbMovieService;
            _tmdbMappingService = tmdbMappingService;
        }

        public async Task<IActionResult> Import()
        {
            var movies = await _context.Movie.ToListAsync();
            return View(movies);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Import(int id)
        {
            //if movie exists, warn the user instead of importing a duplicate
            if (_context.Movie.Any(m => m.MovieId == id))
            {
                var localMovie = await _context.Movie.FirstOrDefaultAsync(m => m.MovieId == id);
                return RedirectToAction("Details", "Movies", new { id = localMovie.Id, local = true });
            }

           //Get the raw data from the API
           var movieDetail = await _tmdbMovieService.MovieDetailAsync(id);

           //Run the data through a mapping procedure
           var movie = await _tmdbMappingService.MapMovieDetailAsync(movieDetail);

           //Add the new movie
           _context.Add(movie);
           await _context.SaveChangesAsync();

            //Assign to the default All Collection
            await AddToMovieCollection(movie.Id, _appSettings.MovieDbSettings.DefaultCollection.Name);

            return RedirectToAction("Import");
        }

        private async Task AddToMovieCollection(int movieId, string collectionName)
        {
            var collection = await _context.Collection.FirstOrDefaultAsync(c => c.Name == collectionName);
            _context.Add(
                    new MovieCollection()
                    {
                        CollectionId = collection.Id,
                        MovieId = movieId
                    }
            );

            await _context.SaveChangesAsync();
        }

        private async Task AddToMovieCollection(int movieId, int collectionId)
        {
            _context.Add(
                    new MovieCollection()
                    {
                        CollectionId = collectionId,
                        MovieId = movieId
                    }
                );

            await _context.SaveChangesAsync();
        }
    }
}