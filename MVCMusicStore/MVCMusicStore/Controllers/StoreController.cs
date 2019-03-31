using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore.Models;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
		MusicStoreEntities storeDB = new MusicStoreEntities();

		// GET: Store
		public ActionResult Index()
		{
			//var genres = storeDB.Genres.ToList();
			//return View(genres);

			var albums = new List<Album>
			{
			new Album { Title = "Frank"},
			new Album { Title = "Axe Bahia 2001"}
			};
			return View(albums);
		}
		//
		// GET: /Store/Browse
		public ActionResult Browse() //Browse(string genre)
		{
			MVCMusicStoreDB db = new MVCMusicStoreDB();

			//var genreModel = storeDB.Genres.Include("Albums")
				//.Single(g => g.Name == genre);

			//return View(genreModel);

			var genres = new List<Genre>
			{
			new Genre { Name = "Classical"},
			new Genre { Name = "Jazz"},
			new Genre { Name = "Rock"},
			new Genre { Name = "Pop"},
			new Genre { Name = "Disco"},
			new Genre { Name = "Latin"},
			new Genre { Name = "Metal"},
			new Genre { Name = "Alternative"},
			new Genre { Name = "Reggae"},
			new Genre { Name = "Blues"}
			};
			return View(genres);
		}
		//
		// GET: /Store/Details
		public ActionResult Details() //Details(int id)
		{
			//var album = storeDB.Albums.Find(id);

			//return View(album);

			return View();
		}
	}
}