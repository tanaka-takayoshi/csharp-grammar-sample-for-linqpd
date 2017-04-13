using System;

namespace CheatSheetConsoleApp
{
  class Ex17_1_Exception
  {
    internal static void Run()
    {
      try
      {	        
        ThrowException();
      }
      catch (Ex17_1_Exception_MyException ex) when (ex.Value >= 1)
      {
        Console.WriteLine("Catch MyException");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Catch Exception: " + ex.Message);
        throw;   // 再スロー
      }
    }

    static void ThrowException()
    {
      throw new Ex17_1_Exception_MyException() {Value = 1};
    }
  }

  public class Ex17_1_Exception_MyException : Exception
  {
    public int Value { get; set; }
  }

  //C# 7.0より例外を式としてスローできるようになった箇所
  public class Ex17_1_Exception_MyClass
  {
    public string Name { get; }
    //ラムダ式や式形式メンバの=>の後
    public Ex17_1_Exception_MyClass() => throw new Exception();
    //null合算演算子の第2オペランド
    public Ex17_1_Exception_MyClass(string name) => Name = name ?? throw new Exception();
    //三項演算子の第2,第3オペランド
    public Ex17_1_Exception_MyClass(int i) => Name = i > 0 ? GetNameById(i) : throw new Exception();
    private string GetNameById(int i) => $"name-{i}";
  }
}
