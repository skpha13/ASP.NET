using Lab4_23.Data;
using Lab4_23.Models;

namespace Lab4_23.Helpers.Seeders;

public class PostsSeeder
{
    private readonly Lab4Context _lab4Context;

    public PostsSeeder(Lab4Context lab4Context)
    {
        _lab4Context = lab4Context;
    }

    public void SeedInitialPosts()
    {
        var posts = new[] 
        {   new Post
            {
               Title = "Post2",
               Description = "Description2"
            },
            new Post
            {
                Title = "Post3",
                Description = "Description3"
            },
            new Post
            {
                Title = "Post4",
                Description = "Description4"
            }
        };

        foreach (var post in posts)
        {
            _lab4Context.Posts.Add(post);
        }

        _lab4Context.SaveChanges();
    }
}