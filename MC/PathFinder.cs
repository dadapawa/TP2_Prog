using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML;
using SFML.Graphics;
using SFML.System;
using SFML.Window;


/////////////////////////////////////////////////////////////////////////
/// Vous devez compléter les méthodes de ce fichier
/////////////////////////////////////////////////////////////////////////
namespace MC
{
  public static class PathFinder
  {
    /// <summary>
    /// Détermine la direction dans laquelle un opposant doit aller pour 
    /// atteindre le héros en utilisant le chemin de coût minimal
    /// </summary>
    /// <param name="aMaze">Le labyrinthe de jeu</param>
    /// <param name="fromX">La position en X de l'opposant</param>
    /// <param name="fromY">La position en Y de l'opposant</param>
    /// <param name="toX">La position en X du héros</param>
    /// <param name="toY">La position en Y du héros</param>
    /// <returns>La direction dans laquelle l'opposant doit se déplacer ou Direction.None s'il est déjà
    /// rendu à destination ou Direction.Undefined s'il n'existe pas de chemin.</returns>
    //public static Direction FindShortestPath( Grid aMaze, int fromX, int fromY, int toX, int toY )
    //{
    //  Direction retval = Direction.Undefined;
    //  1) Allouer le tableau des distances

    //  2) Initialiser le tableau des distances

    //  3) Calculer les distances en lançant l'appel récursif

    //  4) Déterminer le premier déplacement

    //  return retval;
    //}

    /// <summary>
    /// Calcule le tableau des coûts
    /// </summary>
    /// <param name="aMaze">Le labyrinthe de jeu</param>
    /// <param name="fromX">La position en X de l'opposant</param>
    /// <param name="fromY">La position en Y de l'opposant</param>
    /// <param name="toX">La position en X du héros</param>
    /// <param name="toY">La position en Y du héros</param>
    /// <param name="costs">Le tableau des coûts à remplir</param>
    //private static void ComputeCosts( Grid aMaze, int fromX, int fromY, int toX, int toY, int[,] costs )
    //{
      
    //}

    /// <summary>
    /// Parcourt le tableau de coûts pour trouver le premier déplacement à faire.
    /// </summary>
    /// <param name="costs">La tableau de coûts</param>
    /// <param name="fromX">La position en X où se trouve le héros</param>
    /// <param name="fromY">La position en Y où se trouve le héros</param>
    /// <param name="toX">La position en X où se trouve l'opposant</param>
    /// <param name="toY">La position en Y où se trouve l'opposant</param>
    /// <returns>La direction dans laquelle l'opposant doit se déplacer ou Direction.None s'il est déjà
    /// rendu à destination ou Direction.Undefined s'il n'existe pas de chemin.</returns>
    //private static Direction RecurseFindDirection( int[,] costs, int fromX, int fromY, int toX, int toY )
    //{
    //  Direction retval = Direction.Undefined;

    //  return retval;
    //}
  }

}
