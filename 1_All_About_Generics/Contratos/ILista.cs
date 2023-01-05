namespace _1_All_About_Generics.Contratos
{
  public interface ILista<TItem>
  {
    /// <summary>
    /// Não genérico.
    /// </summary>    
    public int Find(TItem[] list, TItem itemToFind);

    /// <summary>
    /// Método Genérico.
    /// </summary>    
    public int Find<TItemMetodo>(TItemMetodo[] list, TItemMetodo itemToFind);
  }
}
