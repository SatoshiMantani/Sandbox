﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Random rand = new Random();

            ////1以上6未満の乱数を整数で返す

            //string input="";
            //int a;
            //while (int.TryParse(input, out a) == false)
            //{
            //    int dice = rand.Next(1, 7);
            //    Console.WriteLine(dice);
            //    input = Console.ReadLine();
            //}


            //Random rand = new Random();
            //string input = "";
            //var rireki = new List<int>();
            //while (input != "h")
            //{
            //    int dice = rand.Next(1, 7);
            //    Console.Write(dice+" ");
            //    input = Console.ReadLine();
            //    rireki.Add(dice);
            //}
            //Console.Write("history:");
            //foreach (var a in rireki)
            //{
            //    Console.Write(a+" ");
            //}



            /*お手本
            Random rand = new Random();
            string input="";
            var history=new List<int>();
            while(true)
            {
                int dice = rand.Next(1, 7);
                history.Add(dice);
                Console.Write(dice + " ");
                input = Console.ReadLine();
                if (input == "h")
                {
                    Console.WriteLine("HISTORY");
                    foreach (var h in history)
                    {
                        Console.Write(h + " ");
                    }
                    Console.WriteLine();
                }
            }*/




        //Random rand = new Random();
        //string input = "";
        //var rireki = new List<int>();
        //while (input != "h") {

        //  int dice = rand.Next(1, 7);

        //  Console.Write(dice + " ");
        //  input = Console.ReadLine();
        //  rireki.Add(dice);

        //}
        //Console.WriteLine("history");
        
          
        //double count = 0;
        //double one = 0;
        //double two = 0;
        //double three = 0;
        //double four = 0;
        //double five = 0;
        //double six = 0;

        //foreach (var a in rireki) {

        //  Console.Write(a + " ");
        //  if (a == 1) {
        //    one++;
        //  }
        //  else if (a == 2) {
        //    two++;
        //  }
        //  else if (a == 3) {
        //    three++;
        //  }
        //  else if (a == 4) {
        //    four++;
        //  }
        //  else if (a == 5) {
        //    five++;
        //  }
        //  else if (a == 6) {
        //    six++;
        //  }
        //  count++;
        //  double size = rireki.Count;
        //  if (count == size) {
        //    Console.WriteLine();
        //    Console.WriteLine("1の出現数 {0} 出現確率 {1,4}%", one, (one / count * 100).ToString("F1"));
        //    Console.WriteLine("2の出現数 {0} 出現確率 {1,4}%", two, (two / count * 100).ToString("F1"));
        //    Console.WriteLine("3の出現数 {0} 出現確率 {1,4}%", three, (three / count * 100).ToString("F1"));
        //    Console.WriteLine("4の出現数 {0} 出現確率 {1,4}%", four, (four / count * 100).ToString("F1"));
        //    Console.WriteLine("5の出現数 {0} 出現確率 {1,4}%", five, (five / count * 100).ToString("F1"));
        //    Console.WriteLine("6の出現数 {0} 出現確率 {1,4}%", six, (six / count * 100).ToString("F1"));
        //    Console.WriteLine("試行数 {0}回　平均値{1}", count, ((one * 1 + two * 2 + three * 3 + four * 4 + five * 5 + six * 6) / count).ToString("F1"));

          //}

        //}


          /*おてほん
        //for (int i = 1; i <= 6; i++) 
        //{
        //  int freq = rireki.Where(c => c.Equals(i)).Count();
        //  double ratio = freq / (double)rireki.Count * 100;
        //  Console.WriteLine("{0}:{1}回　確率{2,4}%", i, freq, ratio.ToString("F1"));
        //}
        //Console.WriteLine(" 試行数：" +rireki.Count);
        //Console.WriteLine("平均値："+rireki.Average());
          */






            //Random rand1 = new Random();

            //string input = "";
            //var rireki = new List<int>();
            //while (input != "h")
            //{
            //    int dice1 = rand1.Next(1, 7);
            //    int dice2 = rand1.Next(1, 7);
            //    int dice3 = rand1.Next(1, 7);

            //    Console.Write(dice1);
            //    Console.Write(dice2);
            //    Console.Write(dice3);
            //    input = Console.ReadLine();
            //    rireki.Add(dice1);
            //}






            //Random rand1 = new Random();

            //string input = "";
            //var rireki1 = new List<int>();
            //var rireki2 = new List<int>();
            //var rireki3 = new List<int>();

            //while (input != "h")
            //{
            //    int dice1 = rand1.Next(1, 7);
            //    int dice2 = rand1.Next(1, 7);
            //    int dice3 = rand1.Next(1, 7);

            //    Console.Write(dice1);
            //    Console.Write(dice2);
            //    Console.Write(dice3);
            //    input = Console.ReadLine();
            //    rireki1.Add(dice1);
            //    rireki2.Add(dice2);
            //    rireki3.Add(dice3);

            //}
            //int size1 = rireki1.Count;
            //Console.WriteLine("history");
            //for (int i = 0; i < size1; i++)
            //{
            //    Console.Write(rireki1[i]);
            //    Console.Write(rireki2[i]);
            //    Console.Write(rireki3[i]);
            //    Console.WriteLine();


            //}



            //Random rand1 = new Random();

            //string input = "";
            //var rireki1 = new List<int>();
            //var rireki2 = new List<int>();
            //var rireki3 = new List<int>();
            //int life = 1000;
            //while (input != "h")
            //{
            //    int dice1 = rand1.Next(1, 7);
            //    int dice2 = rand1.Next(1, 7);
            //    int dice3 = rand1.Next(1, 7);

            //    Console.Write(dice1);
            //    Console.Write(dice2);
            //    Console.WriteLine(dice3);


            //    rireki1.Add(dice1);
            //    rireki2.Add(dice2);
            //    rireki3.Add(dice3);



            //    if (life <= 0)
            //    {
            //        Console.WriteLine("所持ポイントが0以下になりました。ゲーム終了です");
            //        return;
            //    }

            //    else if ((dice1 == 4 && dice2 == 5 && dice3 == 6) ||
            //        (dice1 == 4 && dice2 == 6 && dice3 == 5) ||
            //    (dice1 == 5 && dice2 == 4 && dice3 == 6) ||
            //    (dice1 == 5 && dice2 == 6 && dice3 == 4) ||
            //    (dice1 == 6 && dice2 == 4 && dice3 == 5) ||
            //    (dice1 == 6 && dice2 == 5 && dice3 == 4))
            //    {
            //        life = life + 500;
            //        Console.Write("おおあたり！+500ポイント　現在は{0}ポイントです", life);

            //    }

            //    else if (dice1 == dice2 && dice2 == dice3)
            //    {
            //        life = life + 350;

            //        Console.Write("あたり！+300ポイント　現在は{0}ポイントです", life);

            //    }

            //    else if ((dice1 == 1 && dice2 == 2 && dice3 == 3) ||
            //        (dice1 == 1 && dice2 == 3 && dice3 == 2) ||
            //    (dice1 == 2 && dice2 == 1 && dice3 == 3) ||
            //    (dice1 == 2 && dice2 == 3 && dice3 == 1) ||
            //    (dice1 == 3 && dice2 == 1 && dice3 == 2) ||
            //    (dice1 == 3 && dice2 == 2 && dice3 == 1))
            //    {
            //        life = life - 100;
            //        Console.Write("おおはずれ！-100ポイント　現在は{0}ポイントです", life);
            //    }

            //    else
            //    {
            //        life = life - 30;
            //        Console.Write("はずれ！-30ポイント　現在は{0}ポイントです", life);

            //    }
            //    input = Console.ReadLine();

            //}

            


            Console.ReadLine();
        }

    }
}
