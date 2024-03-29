﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BusinessLayer.DTOs.Author;
using BusinessLayer.DTOs.Genre;
using BusinessLayer.DTOs.Publisher;
using BusinessLayer.DTOs.Review;

namespace BusinessLayer.DTOs.Book
{
    public class BookDTO
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public GenreDTO PrimaryGenre { get; set; }
        public List<AuthorWithoutBooksDTO> Authors { get; set; }
        public List<GenreDTO> Genres { get; set; }
        public PublisherDTO Publisher { get; set; }
        public List<ReviewBasicDTO> Reviews { get; set; }
    }

}
