using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class ArtistController : Controller
  {
    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artist> allItems = Artist.GetAll();
      return View(allItems);
    }

    [HttpGet("/artists/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/artists")]
    public ActionResult Create(string artistName)
    {
      Artist myArtist = new Artist(artistName);
      return RedirectToAction("Index");
    }

    [HttpGet("/artists/{artistId}/record/{recordId}")]
    public ActionResult Show(int artistId, int recordId)
    {
      Record record = Record.Find(recordId);
      Artist artist = Artist.Find(artistId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("record", record);
      model.Add("artist", artist);
      return View(model);
    }
  }
}  