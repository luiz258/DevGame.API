using System;
using System.Collections.Generic;

namespace DevGames.API.Entities
{
    public class Board
    {
        public Board(int id, string title, string description, string rules)
        {
            Id = id;
            GameTitle = title;
            Description = description;
            Rules = rules;

            CreatedAt = DateTime.Now;
            Posts = new List<Post>();
        }

        public int Id { get; private set; }
        public string GameTitle { get; private set; }
        public string Description { get; private set; }
        public string Rules { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<Post> Posts { get; private set; }

        public void Update(string description, string rules)
        {
            Description = description;
            Rules = rules;
        }

        public void AddPost(Post post)
        {
            Posts.Add(post);
        }
    }
}