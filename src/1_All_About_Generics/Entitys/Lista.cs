using System;
using _1_All_About_Generics.Contratos;

namespace _1_All_About_Generics.Entitys
{
  public class Lista<TItem> : ILista<TItem>
  {
    #region Método Não genérico
    /// <summary>
    /// Esse é um método não genérico, type parameter tem escopo de classe.
    /// </summary>
    public int Find(TItem[] list, TItem itemToFind)
    {
      Int32 position = (list != null ? list.Length : 0);

      while ((--position >= 0) && (!itemToFind.Equals(list[position]))) ;

      return position;
    }
    #endregion

    #region Método Genérico
    public int Find<TItemMetodo>(TItemMetodo[] list, TItemMetodo itemToFind)
    {
      int position = (list != null ? list.Length : 0);

      while ((--position >= 0) && (!itemToFind.Equals(list[position]))) ;

      return position;
    }
    #endregion

  }
}
