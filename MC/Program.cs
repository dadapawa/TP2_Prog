using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
  class Program
  {
    static void Main( string[] args )
    {
      Application app = new Application( "Catch Me If You Can!", Game.GAME_WIDTH, Game.GAME_HEIGHT);
      app.Run( );
    }
  }
}
