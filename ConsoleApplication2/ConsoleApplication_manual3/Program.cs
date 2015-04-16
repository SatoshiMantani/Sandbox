using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_manual3
{
  class Program
  {
    static string MessageValue;
    static string Message
    {
      get
      {
        Console.WriteLine("Messageがgetされました");
        return MessageValue;
      }
      set
      {
        MessageValue = value;
        Console.WriteLine(
          "Messageがsetされました"+
          "値は「"+value+"」です");
      }
    }

    static void Main(string[] args)
    {
      Message = "こんにちは！";
      Console.WriteLine(Message);
    }
  }
}
