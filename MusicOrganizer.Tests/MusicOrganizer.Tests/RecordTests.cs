using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer;
using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace MusicOrganizer.Tests
{

  [TestClass]
  public class RecordTest : IDisposable
  {

    public void Dispose()
    {
      Record.ClearAll();
    }

    // The method below is new code.
    public RecordTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=music_organizer_test;";
    }
  }
}    