using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> { };
    public string ArtistName { get; set; }
    public List<Record> Records { get; set; }

    public Artist(string artistName)
    {
      ArtistName = artistName;
      _instances.Add(this);
      Records = new List<Record> { };
    }

    public static List<Artist> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void AddRecord(Record record)
    {
      Records.Add(record);
    }
  }
}