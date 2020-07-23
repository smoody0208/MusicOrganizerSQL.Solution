using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Record
  {
    public string Name { get; set; }
    private static List<Record> _instances = new List<Record> {};


    public Record(string name)
    {
      Name = name;
    }
  }
}