﻿namespace DevCard_MVC.Models
{
    public class Article
    {
        public Article(int id, string title, string description, string image)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Article(long id, string title, string image, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
        }
    }
     
}
