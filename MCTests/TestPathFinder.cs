using System;
using System.Drawing;
using MC;
using Microsoft.VisualStudio.TestTools.UnitTesting;



/////////////////////////////////////////////////////////
//  A DÉCOMMENTER LORSQUE POSSIBLE
//  A COMPLÉTER CAR IL MANQUE PAS MAL DE SITUATIONS
//
//  NE PAS OUBLIER DE DOCUMENTER LES TESTS QUE VOUS FEREZ
//
//  ET CEUX QUI SONT DÉJÀ PRÉSENTS
//  == ==== === ==== ==== ========
/////////////////////////////////////////////////////////
namespace MazeSolverTests
{
  [TestClass]
  public class TestPathFinder
  {
    // Test du constructeur
    [TestMethod]
    public void TestCtor01( )
    {
      //Grid aMaze = new Grid();
      //Assert.AreEqual( -1, aMaze.GetWidth( ) );
      //Assert.AreEqual( -1, aMaze.GetHeight( ) );
      //Assert.AreEqual( Element.None, aMaze.GetMazeElementAt( 0, 0 ) );
    }



    private static string mazeData01 = @"
                                        1,1,1,1,1,1;
                                        1,0,0,0,0,1;
                                        1,0,0,0,0,1;
                                        1,1,1,1,1,1";
    // Test de chargement du niveau
    [TestMethod]
    public void TestInitFrom01()
    {
      //Grid aMaze = new Grid();
      //aMaze.InitFrom(mazeData01);
      
      //Assert.AreEqual( 4, aMaze.GetHeight( ) );
      //Assert.AreEqual( 6, aMaze.GetWidth( ) );
      //for (int i = 0; i < aMaze.GetWidth(); i++)
      //{
        //Assert.AreEqual( Element.Wall, aMaze.GetMazeElementAt( 0, i));
        //Assert.AreEqual( Element.Wall, aMaze.GetMazeElementAt( 3, i ) );
      //}

      //for ( int i = 1; i < aMaze.GetWidth( )-1; i++ )
      //{
        //Assert.AreEqual( Element.None, aMaze.GetMazeElementAt( 1, i ) );
        //Assert.AreEqual( Element.None, aMaze.GetMazeElementAt( 2, i ) );
      //}
    }

    // Test de détermination du plus court chemin #1
    // Point de départ égal au point d'arrivée
    [TestMethod]
    public void TestFindShortestPath01()
    {
      //Grid aMaze = new Grid( );
      //aMaze.InitFrom( mazeData01 );
      //Direction direction = PathFinder.FindShortestPath( aMaze, 1, 1 , 1, 1  );
      //Assert.AreEqual(Direction.None, direction);
    }


    // Test de détermination du plus court chemin #2
    // Point de départ à côté du point d'arrivée
    [TestMethod]
    public void TestFindShortestPath02( )
    {
      //Grid aMaze = new Grid( );
      //aMaze.InitFrom( mazeData01 );
      //Direction direction = PathFinder.FindShortestPath( aMaze, 1, 1 ,2, 1 );
      //Assert.AreEqual( Direction.East, direction );
    }

    // Test de détermination du plus court chemin #2
    // A préciser...
    [TestMethod]
    public void TestFindShortestPath03( )
    {
      // A COMPLETER
    }



    
    
  }
}
  