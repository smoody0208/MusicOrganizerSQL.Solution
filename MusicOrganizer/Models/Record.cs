using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MusicOrganizer.Models
{
  public class Record
  {
    public string Name { get; set; }
    public int Id { get; }

    public Record(string name, int id)
    {
      Name = name;
      Id = id;
    }

    public static List<Record> GetAll()
    { 
      List<Record> allRecords = new List<Record> { };
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM items;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while (rdr.Read())
      {
        int recordId = rdr.GetInt32(0);
        string recordName = rdr.GetString(1);
        Record newRecord = new Record(recordName, recordId);
        allRecords.Add(newRecord);
      }
      conn.Close();
      if (conn != null)
      {
      conn.Dispose();
      }
      return allRecords;
    }

    public static void ClearAll()
    {
    }
    
    public static Record Find(int searchId)
    {
      Record placeholderRecord = new Record("placeholder record");
      return placeholderRecord;
    }
  }
}