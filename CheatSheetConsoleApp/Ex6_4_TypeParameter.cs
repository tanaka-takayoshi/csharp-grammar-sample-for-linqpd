using System;

namespace CheatSheetConsoleApp
{
  class Ex6_4_TypeParameter
  {
    internal static void Run()
    {
      var c1 = new MyClass<string>();
      c1.Value = "a";
      c1.Value.Dump();
      c1.DefaultValue().Dump();

      var c2 = new MyClass<DateTime>();
      c2.Value = DateTime.Now;
      c2.Value.Dump();
      c2.DefaultValue().Dump();

      var c3 = new MyClass2<object>();
      c3.DefaultValue().Dump();
      
      var c4 = new MyClass3<Printable>();
      c4.Execute();      
    }
  }

  public class MyClass<T>
  {
    public T Value { get; set; }

    public T DefaultValue()
    {
      return default(T);
    }
  }

  public class MyClass2<T> where T : new ()
  {
    public T DefaultValue()
    {
      //new () 制約があるため、Tのデフォルトコンストラクタ呼び出しによるインスタンス化が可能
      return new T();
    }
  }

  public class MyClass3<T> where T : IPrintable, new()
  {
    public void Execute()
    {
      //TはIPrintableを実装している
      new T().Print();
    }
  }

  public interface IPrintable
  {
    void Print();
  }

  public class Printable : IPrintable
  {
    public void Print()
    {
      Console.WriteLine("Printable Prints");
    }
  }

  //複数の型パラメーターがある場合は、それぞれに制約を指定することが可能
  public class MyClass4<K, V> where K: class where V: struct
  {
    
  }
}
