using System;
using _1_All_About_Generics.Entitys;

namespace _1_All_About_Generics
{
  class Program
  {
    static void Main(string[] args)
    {
      //1 - Método genérico para uma class não generica
      var resultado = ListQualquer.Find<int>(12);

      //2 - Class e método genérico
      MyList<Int32> numbers = new MyList<Int32>();
      MyList<String> words = new MyList<String>();

      //3 - Método não genérico 
      Lista<Int32> numbers2 = new Lista<Int32>();

      Int32[] source = { 0, 2, 3, 5, 6, 7, 8, 10 };

      Int32 itemToFind = 10;

      // Chama o método non-generic
      Console.WriteLine("---- Método não genérico ----");
      Console.WriteLine("Position: {0}", numbers2.Find(source, itemToFind).ToString());
      Console.WriteLine();

      //4 - Método Genérico
      Lista<int> numbers3 = new Lista<int>();

      String[] items = { "0", "2", "3", "5", "6", "7", "8", "10" };

      String anotherItemToFind = "10";

      // O método generic utiliza um type argument diferente do type argument da classe.
      // Neste caso o método utiliza um objeto do tipo String: Find<String>.
      Console.WriteLine("---- Método Genérico ----");
      Console.WriteLine("Position: {0}", numbers3.Find<string>(items, anotherItemToFind).ToString());
      Console.WriteLine();

      Console.WriteLine("--------------  Fim  ---------------");
      Console.ReadKey();

    }
  }
}
