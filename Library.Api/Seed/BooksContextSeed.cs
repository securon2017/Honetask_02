using Library.Api.Resources;
using Library.Core.Models;
using Library.Data;
using Microsoft.EntityFrameworkCore;

namespace Library.Api.Seed
{
    public class BooksContextSeed
    {
        public static void SeedAsync(IServiceProvider serviceProvider)
        {
            using var context = new MyLibraryDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyLibraryDbContext>>());
            if (context.Books.Any())
            {
                return;
            }
            var books = new List<Book>
                {
                    new Book
                    {
                        Id = 1,
                        Author ="Octavia E Butler",
                        Genre ="Science Fiction",
                        Title = "Parable of the Sower",
                        Content = "This acclaimed post-apocalyptic novel of hope and " +
                        "terror from an award-winning author pairs well with 1984 or " +
                        "The Handmaid's Tale and includes a foreword by N. K. Jemisin " +
                        "(John Green, New York Times).",
                        Cover = "cover",
                    },
                    new Book
                    {
                        Id = 2,
                        Author ="Stephanie Johnson",
                        Genre ="Nonfiction",
                        Title = "Tanqueray",
                        Content = "In 2019, Humans of New York featured a photo of a woman " +
                        "in an outrageous fur coat and hat she made herself. She instantly " +
                        "captured the attention of millions.",
                        Cover = "cover",
                    },
                    new Book
                    {
                        Id = 3,
                        Author ="Laura Dave",
                        Genre ="Mystery & Thriller",
                        Title = "The Last Thing He Told Me",
                        Content = "Before Owen Michaels disappears, he manages to smuggle a " +
                        "note to his beloved wife of one year: Protect her.",
                        Cover = "cover",
                    },
                    new Book
                    {
                        Id = 4,
                        Author ="Taylor Jenkins Reid",
                        Genre ="Historical Fiction",
                        Title = "Malibu Rising",
                        Content = "Malibu: August 1983. It’s the day of Nina Riva’s annual " +
                        "end-of-summer party, and anticipation is at a fever pitch. ",
                        Cover = "cover",
                    },
                    new Book
                    {
                        Id = 5,
                        Author ="Stephen King",
                        Genre ="Mystery & Thriller",
                        Title = "Billy Summers",
                        Content = "Billy Summers is a man in a room with a gun. He’s a killer " +
                        "for hire and the best in the business. But he’ll do the job only if " +
                        "the target is a truly bad guy. ",
                        Cover = "cover",
                    },
                    new Book
                    {
                        Id = 6,
                        Author ="Ashley Audrain",
                        Genre ="Mystery & Thriller",
                        Title = "The Push",
                        Content = "Blythe Connor is determined that she will be the warm, " +
                        "comforting mother to her new baby Violet that she herself never had.",
                        Cover = "cover",
                    },
                    new Book
                    {
                        Id = 7,
                        Author ="Jenny Lawson",
                        Genre ="Humor",
                        Title = "Broken",
                        Content = "This acclaimed post-apocalyptic novel of hope and " +
                        "terror from an award-winning author pairs well with 1984 or " +
                        "The Handmaid's Tale and includes a foreword by N. K. Jemisin " +
                        "(John Green, New York Times).",
                        Cover = "cover",
                    },
                    new Book
                    {
                        Id = 8,
                        Author ="David Sedaris",
                        Genre ="Humor",
                        Title = "A Carnival of Snackery: Diaries 2003-2020",
                        Content = "There’s no right way to keep a diary, but if there’s an " +
                        "entertaining way, David Sedaris seems to have mas­tered it.",
                        Cover = "cover",
                    },
                    new Book
                    {
                        Id = 9,
                        Author ="Amber Share",
                        Genre ="Humor",
                        Title = "Subpar Parks",
                        Content = "Based on the wildly popular Instagram account, Subpar Parks " +
                        "features both the greatest hits and brand-new content",
                        Cover = "cover",
                    },
                    new Book
                    {
                        Id = 10,
                        Author ="Quinta Brunson",
                        Genre ="Humor",
                        Title = "She Memes Well",
                        Content = "From comedian Quinta Brunson comes a deeply personal and funny " +
                        "collection of essays featuring anecdotes about trying to make it when " +
                        "you’re broke, overcoming self-doubt and depression, and how she’s " +
                        "used humor to navigate her career in unusual directions.",
                        Cover = "cover",
                    }
                };

            context.Books.AddRange(books);
            context.SaveChangesAsync();
        }
    }
}
