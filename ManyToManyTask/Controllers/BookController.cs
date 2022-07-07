using ManyToManyTask.Extentions;
using ManyToManyTask.DAL;
using ManyToManyTask.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.Controllers
{
    public class BookController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BookController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Book> books = _context.Books
               .Include(b => b.Images)
               .Include(b => b.BookGenres)
               .ThenInclude(g => g.Genre)
               .Include(b => b.BookAuthors)
               .ThenInclude(a => a.Author).ThenInclude(s => s.SocialAccount)
               .ToList();
            return View(books);
        }
        public IActionResult Create()
        {

            ViewBag.Authors = new SelectList(_context.Authors.ToList(), "Id", "Name");
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            ViewBag.Authors = new SelectList(_context.Authors.ToList(), "Id", "Name");
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "Id", "Name");

            List<Image> images = new List<Image>();

            foreach (var item in book.Photos)
            {
                if (item == null)
                {
                    ModelState.AddModelError("Photo", "bosh qoyma");
                    return View();
                }
                if (!item.IsImage())
                {
                    ModelState.AddModelError("Photo", "only shekil");
                    return View();
                }

                if (item.ValidSize(400000000))
                {
                    ModelState.AddModelError("Photo", "olcu oversize");
                    return View();
                }
                Image image = new Image();
                image.ImageUrl = item.SaveImage(_env, "img");
                for (int i = 0; i < images.Count; i++)
                {
                        images[0].IsMain = true;
                }
                images.Add(image);
            }


            if (!ModelState.IsValid) return View();

            Book newBook = new Book
            {
                Name = book.Name,
                Price = book.Price,
                Images = images
                //BookAuthors=
                //BookGenres=
            };

            List<BookAuthor> bookAuthors = new List<BookAuthor>();
            foreach (int item in book.AuthorIds)
            {
                BookAuthor bookAuthor = new BookAuthor();
                bookAuthor.AuthorId = item;
                bookAuthor.BookId = newBook.Id;
                bookAuthors.Add(bookAuthor);
            }
            newBook.BookAuthors = bookAuthors;

            List<BookGenre> bookGenres = new List<BookGenre>();
            foreach (int item in book.GenreIds)
            {
                BookGenre bookGenre = new BookGenre();
                bookGenre.GenreId = item;
                bookGenre.BookId = newBook.Id;
                bookGenres.Add(bookGenre);
            }
            newBook.BookGenres = bookGenres;

            _context.Books.Add(newBook);
            _context.SaveChanges();

            return RedirectToAction("index");
            //return RedirectToAction("action", "controller", new { area = "AdminPanel" });
        }

        public async Task<IActionResult> Detail(Book book)
        {
            //ViewBag.Authors = new SelectList(_context.Authors.ToList(), "Id", "Name");
            //ViewBag.Genres = new SelectList(_context.Genres.ToList(), "Id", "Name");
            Book thisBook = await _context.Books.FindAsync(book.Id);
            List<Book> books = _context.Books
            .Include(b => b.Images)
            .Include(b => b.BookGenres)
            .ThenInclude(g => g.Genre)
            .Include(b => b.BookAuthors)
            .ThenInclude(a => a.Author).ThenInclude(s => s.SocialAccount)
            .ToList();
            return View(thisBook);
        }
        public async Task<IActionResult> Delete(Book book)
        {
            //if (book.Id == null) return NotFound();
            Book dbBook = await _context.Books.FindAsync(book.Id);
            if (dbBook == null) return NotFound();
            //Image image = _context.Images.FirstOrDefault();
            //string path = Path.Combine(_env.WebRootPath, "img", image.ImageUrl);
           //ManyToManyTask.Helpers.Helper.DeleteImage(path);
            _context.Books.Remove(dbBook);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Update(Book book)
        {
            ViewBag.Authors = new SelectList(_context.Authors.ToList(), "Id", "Name");
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "Id", "Name");
            Book dbBook = _context.Books.Find(book.Id);
            List<Book> books = _context.Books
           .Include(b => b.Images)
           .Include(b => b.BookGenres)
           .ThenInclude(g => g.Genre)
           .Include(b => b.BookAuthors)
           .ThenInclude(a => a.Author).ThenInclude(s => s.SocialAccount)
           .ToList();
            return View(books);
        }
    }
}