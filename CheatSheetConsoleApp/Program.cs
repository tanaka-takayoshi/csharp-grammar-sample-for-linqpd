using System;

namespace CheatSheetConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {            
      Console.WriteLine("Executing: Ex1_1_MainMethod");
      Ex1_1_MainMethod.Run();
      Console.WriteLine("Executing: Ex1_2_CommandArgs");
      Ex1_2_CommandArgs.Run(args);
      Console.WriteLine("Executing: Ex1_3_Stdin");
      //Ex1_3_Stdin.Run();
      Console.WriteLine("Executing: Ex2_1_Literal");
      Ex2_1_Literal.Run();
      Console.WriteLine("Executing: Ex2_2_String");
      Ex2_2_String.Run();
      Console.WriteLine("Executing: Ex2_3_StringInterpolation");
      Ex2_3_StringInterpolation.Run();
      Console.WriteLine("Executing: Ex2_4_Array");
      Ex2_4_Array.Run();
      Console.WriteLine("Executing: Ex3_1_ArithmeticOperator");
      Ex3_1_ArithmeticOperator.Run();
      Console.WriteLine("Executing: Ex3_2_ShiftOperator");
      Ex3_2_ShiftOperator.Run();
      Console.WriteLine("Executing: Ex3_3_RelationalOperator");
      Ex3_3_RelationalOperator.Run();
      Console.WriteLine("Executing: Ex3_4_EqualityOperator");
      Ex3_4_EqualityOperator.Run();
      Console.WriteLine("Executing: Ex3_5_CastOperator_is_as");
      Ex3_5_CastOperator_is_as.Run();
      Console.WriteLine("Executing: Ex3_6_ConditionalLogicalOperator");
      Ex3_6_ConditionalLogicalOperator.Run();
      Console.WriteLine("Executing: Ex3_7_ConditonalOperator_NullCoalescingOperator");
      Ex3_7_ConditonalOperator_NullCoalescingOperator.Run();
      Console.WriteLine("Executing: Ex3_8_NullConditionOperator");
      Ex3_8_NullConditionOperator.Run();
      Console.WriteLine("Executing: Ex3_9_NameOfOperator");
      Ex3_9_NameOfOperator.Run(args);
      Console.WriteLine("Executing: Ex4_1_If");
      Ex4_1_If.Run();
      Console.WriteLine("Executing: Ex4_2b_SwitchWithPattern");
      Ex4_2b_SwitchWithPattern.Run();
      Console.WriteLine("Executing: Ex4_2_Switch");
      Ex4_2_Switch.Run();
      Console.WriteLine("Executing: Ex4_3_While_Do");
      Ex4_3_While_Do.Run();
      Console.WriteLine("Executing: Ex4_4_For_ForEach");
      Ex4_4_For_ForEach.Run();
      Console.WriteLine("Executing: Ex4_5_Break_Continue");
      Ex4_5_Break_Continue.Run();
      Console.WriteLine("Executing: Ex5_1_NameSpace");
      Ex5_1_NameSpace.Run();
      Console.WriteLine("Executing: Ex5_2_Using");
      Ex5_2_Using.Run();
      Console.WriteLine("Executing: Ex6_1_Class");
      Ex6_1_Class.Run();
      Console.WriteLine("Executing: Ex6_2_StaticClass");
      Ex6_2_StaticClass.Run();
      Console.WriteLine("Executing: Ex6_3_Partial");
      Ex6_3_Partial.Run();
      Console.WriteLine("Executing: Ex6_4_TypeParameter");
      Ex6_4_TypeParameter.Run();
      Console.WriteLine("Executing: Ex6_5_NestedType");
      Ex6_5_NestedType.Run();
      Console.WriteLine("Executing: Ex7_1_Method");
      Ex7_1_Method.Run();
      Console.WriteLine("Executing: Ex7_2b_OurVar");
      Ex7_2b_OurVar.Run();
      Console.WriteLine("Executing: Ex7_2_Ref_Out");
      Ex7_2_Ref_Out.Run();
      Console.WriteLine("Executing: Ex7_3_ParameterArray");
      Ex7_3_ParameterArray.Run();
      Console.WriteLine("Executing: Ex7_4_DefaultArgument");
      Ex7_4_DefaultArgument.Run();
      Console.WriteLine("Executing: Ex7_5_ExtensionMethod");
      Ex7_5_ExtensionMethod.Run();
      Console.WriteLine("Executing: Ex7_6_RefLocal");
      Ex7_6_RefLocal.Run();
      Console.WriteLine("Executing: Ex8_1_Property");
      Ex8_1_Property.Run();
      Console.WriteLine("Executing: Ex8_2_AutoProperty");
      Ex8_2_AutoProperty.Run();
      Console.WriteLine("Executing: Ex9_1_Event");
      Ex9_1_Event.Run();
      Console.WriteLine("Executing: Ex10_1_Indexer");
      Ex10_1_Indexer.Run();
      Console.WriteLine("Executing: Ex11_1_UserDefinedOperator");
      Ex11_1_UserDefinedOperator.Run();
      Console.WriteLine("Executing: Ex12B_1_Tuple");
      Ex12B_1_Tuple.Run();
      Console.WriteLine("Executing: Ex12B_2_Destruction");
      Ex12B_2_Destruction.Run();
      Console.WriteLine("Executing: Ex12C_1_LocalFunction");
      Ex12C_1_LocalFunction.Run();
      Console.WriteLine("Executing: Ex12_1_InstanceConstructor");
      Ex12_1_InstanceConstructor.Run();
      Console.WriteLine("Executing: Ex12_2_StaticConstructor");
      Ex12_2_StaticConstructor.Run();
      Console.WriteLine("Executing: Ex12_3_Destructor");
      Ex12_3_Destructor.Run();
      Console.WriteLine("Executing: Ex13_1_Struct");
      Ex13_1_Struct.Run();
      Console.WriteLine("Executing: Ex14_1_Inheritance");
      Ex14_1_Inheritance.Run();
      Console.WriteLine("Executing: Ex14_2_Abstract");
      Ex14_2_Abstract.Run();
      Console.WriteLine("Executing: Ex14_3_Interface");
      Ex14_3_Interface.Run();
      Console.WriteLine("Executing: Ex15_1_Enum");
      Ex15_1_Enum.Run();
      Console.WriteLine("Executing: Ex15_2_Flags");
      Ex15_2_Flags.Run();
      Console.WriteLine("Executing: Ex16_1_Iterator");
      Ex16_1_Iterator.Run();
      Console.WriteLine("Executing: Ex16_2_IteratorNullCheck");
      Ex16_2_IteratorNullCheck.Run();
      Console.WriteLine("Executing: Ex17_1_Exception");
      Ex17_1_Exception.Run();
      Console.WriteLine("Executing: Ex18_1_Resource");
      Ex18_1_Resource.Run();
      Console.WriteLine("Executing: Ex19_1_Lambda");
      Ex19_1_Lambda.Run();
      Console.WriteLine("Executing: Ex20_1_Async");
      Ex20_1_Async.Run();
      Console.WriteLine("Executing: Ex20_2_CacheTaskResult");
      Ex20_2_CacheTaskResult.Run();
      Console.WriteLine("Executing: Ex20_2_ValueTask");
      Ex20_2_ValueTask.Run();
    }

    //リスト1-4のサンプル。デフォルトではMainメソッドを複数定義できないため、コメントアウトして使ってください。
    // static void Main(string[] args)
    // {
    //     Environment.Exit(1);
    // }

    // static int Main(string[] args)
    // {
    //     return 1;
    // }

  }

  //LINQPadのサンプルと同じコードになるよう、Dumpメソッドを定義
  static class MyExtension
  {
    internal static void Dump(this object obj)
    {
        Console.WriteLine(obj);
    }
  }
}

