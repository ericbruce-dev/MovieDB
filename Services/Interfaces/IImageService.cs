﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MovieDB.Services.Interfaces
{
    public interface IImageService
    {
        Task<byte[]> EncodeImageAsync(IFormFile poster);
        Task<byte[]> EncodeImageURLAsync(string imageURL);
        string DecodeImage(byte[] poster, string contentType);
    }
}
