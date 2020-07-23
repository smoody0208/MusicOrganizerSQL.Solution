using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    public string ArtistName { get; set; }
    public List<Record> Records { get; set; }

    public Artist(string artistName)
    {
      ArtistName = artistName;
      _instances.Add(this);
      Records = new List<Record> {};
    }
  }
}