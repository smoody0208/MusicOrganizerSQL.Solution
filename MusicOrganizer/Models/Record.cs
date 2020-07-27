using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Record
  {
    public string Name { get; set; }
    public int Id { get; }

    public Record(string name)
    {
      Name = name;
    }

    public static List<Record> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Record Find(int searchId)
    {
       Item placeholderRecord = new Record("placeholder record");
       return placeholder;
    }
  }
}