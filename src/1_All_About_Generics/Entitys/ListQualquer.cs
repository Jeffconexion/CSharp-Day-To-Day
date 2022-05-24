using System;
using All_About_Generics.Contratos;

namespace _1_All_About_Generics.Entitys
{

  /// <summary>
  /// Coloco vários exemplos aqui.
  /// </summary>
  /// <typeparam name="TItem"></typeparam>
  public class MyList<TItem> : IMyList<TItem>
  {
    /// <summary>
    /// um campo do tipo type parameter generice
    /// </summary>
    private TItem item;

    /// <summary>
    /// um campo do tipo type parameter generice
    /// </summary>
    private TItem[] internalList;

    /// <summary>
    /// um campo do tipo não genérico e int
    /// </summary>
    private Int32 index;

    public MyList()
    {
      this.item = default(TItem);
      this.internalList = null;
    }

    /// <summary>
    /// Pesquisa pelo objeto itemToFind e verifica se este
    /// existe na coleção.
    /// </summary>
    /// <param name="itemToFind">Objeto que deve ser encontrado.</param>
    /// <returns></returns>
    public int Find(TItem itemToFind)
    {
      return 0;
    }
  }


  public class ListQualquer
  {
    /// <summary>
    /// Método genérico em uma class não generica
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <param name="valor"></param>
    /// <returns></returns>
    public static Boolean Find<TInput>(TInput valor)
    {
      if (valor is null)
        return false;
      return true;
    }

  }

  public class ListQualquer2<TItem>
  {
    /// <summary>
    /// Eu tenho um class genérica sem um método generico
    /// </summary>
    /// <param name="valor"></param>
    /// <returns></returns>
    public static Boolean Find(Object valor)
    {
      if (valor is null)
        return false;
      return true;
    }
  }
}
