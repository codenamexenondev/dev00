using System;
using System.IO;
using System.Text.RegularExpressions;

class CodenameXenon {

  static internal int csgrep(string str_filename, string str_regex) {
    int linenum = 1;
    int count = 0;
    StreamReader reader = null;

    try {
      Regex regex = new Regex( str_regex, RegexOptions.IgnoreCase );
      reader = new StreamReader( str_filename );

      for( string line = reader.ReadLine();
           line != null; line = reader.ReadLine(), linenum++ ) {
        if( regex.IsMatch( line ) ) {
          // {0:D5} or {0}
          Console.WriteLine( "{0}: {1}", linenum, line );
          count++;
        }
      }
    }
    catch( Exception e ) {
      Console.WriteLine( e.Message );
    }
    finally {
      if( reader != null )
        reader.Close();
    }
    return count;
  }

  static void Main( string[] args ) {
    // Check arg
    if( args.Length != 2 ) {
      Console.WriteLine( "Syntax: csgrep filename expression" );
      return;
    }
    Console.WriteLine( "{0} Matched!!", csgrep( args[0], args[1] ) );
  }
}

