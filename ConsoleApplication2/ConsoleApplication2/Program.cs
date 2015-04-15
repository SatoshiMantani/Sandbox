using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //uint a;
            //string input = "";
            //while(uint.TryParse(input, out a)==false)
            //{ Console.WriteLine("整数を入力してください");
            //input = Console.ReadLine();
            //}
            //switch(a)
            //{
            //    case(1):
            //        Console.Write("one");
            //        break;
            //   case(2):
            //        Console.Write("two");
            //        break;
            //   case(3):
            //        Console.Write("three");
            //        break;
            //   case(4):
            //        Console.Write("four");
            //        break;
            //   case(5):
            //        Console.Write("five");
            //        break;

            //uint a;
            //string nyu = "";
            //while (uint.TryParse(nyu, out a) == false) 
            //{
            //    Console.Write("整数を入力してください : ");
            //    nyu = Console.ReadLine();
            //}
            //switch (a)
            //{
            //    case (1):
            //        Console.Write("one");
            //        break;
            //    case (2):
            //        Console.Write("two");
            //        break;
            //    case (3):
            //        Console.Write("three");
            //        break;
            //    case (4):
            //        Console.Write("four");
            //        break;
            //    case (5):
            //        Console.Write("five");
            //        break;
            //    default:
            //        Console.WriteLine("1～5の数字を入力してください");
            //        break;




            //}
            //var dic = new Dictionary<int, string>();
            //dic[0] = "果物屋";
            //dic[1] = "八百屋";
            //Console.WriteLine(dic[0]);
            //Console.WriteLine(dic[1]);

            //foreach (var shop in dic)
            //{
            //    Console.WriteLine(shop.Value);
            //}
            //var dic = new Dictionary<string, string>();
            //dic["北海道"] = "札幌市";
            //dic["青森"] = "青森市";
            //dic["秋田"] = "秋田市";
            //dic["岩手"] = "盛岡市";
            //dic["山形"] = "山形市";
            //dic["宮城"] = "仙台市";
            //dic["福島"] = "福島市";

            //Console.WriteLine(dic["北海道"]);
            //Console.WriteLine(dic["青森"]);

            //foreach (var shop in dic)
            //{
            //    Console.WriteLine(dic);
            //}

            //int[,] fibo = new int[3,4]{


            //    { 1,0,0,1},
            //    { 1,0,0,1},
            //    { 1,0,0,1}
            //};
            //int[][] jag = new int[3][]{
            //    new int[]{1.0.0.0},
            //    new int[]{1.0.0.0},
            //    new int[]{1.0.0.0}
            //};

            /*
            fibo[0, 0] = 1;
            fibo[0, 1] = 0;
            fibo[0, 2] = 0;
            fibo[0, 3] = 1;
           int[].tmp=new int[]{0,1,0,1} 
            */








            //            C#練習問題②【switch・連想配列・多次元配列】
            //Visual C# を使って、次のようなコンソールアプリケーションを作成してください。
            //(30) 商品の在庫をあらわす連想配列を定義し、次のように画面に表示してください。
            //やくそう 50 個
            //どくけしそう 20 個
            //せかいじゅのは 1 個
            //せいすい 3 個



            var dic = new Dictionary<string, int>();
            dic["やくそう"] = 50;
            dic["どくけしそう"] = 20;
            dic["せかいじゅのは"] = 1;
            dic["せいすい"] = 3;
            foreach (var a in dic)
            {
                Console.WriteLine("{0}\t{1,2}個", a.Key, a.Value);

            }


            //            (31) 商品番号・在庫・販売価格・仕入価格を整数で表す多次元配列を定義し、次のよう
            //に画面に表示してください。
            //商品番号 在庫 販売価格 仕入価格
            //----------------------------------
            //1 99 100 50
            //2 200 5000 3000
            //3 50 90 33

            

            //Console.WriteLine("商品番号" + "    在庫" + "    販売価格" + "     仕入れ価格");
            //Console.WriteLine("-------------------------------------------");
            //int[,] array = new int[3, 4]{
            // { 1,99,100,50},
            // { 2,200,5000,3000},
            //{ 3,50,99,33}};


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int ii = 0; ii <4 ; ii++)
            //    {
            //        Console.Write("{0,5}      ", array[i, ii]);
            //    }
            //    Console.WriteLine();
            //}

            //            (32) 以下のデータを格納する連想配列を作成し、同様に画面表示してください。
            //氏名：矢吹 点数： 2
            //氏名：丹下 点数： 74
            //氏名：力石 点数： 80
            //氏名：白木 点数：100
            //氏名：西 点数： 10

            



            //var dic1 = new Dictionary<string, string>();
            //dic1["氏名：矢吹"] ="  点数：  2";
            //dic1["氏名：丹下"] ="  点数： 74";
            //dic1["氏名：力石"] ="  点数： 80";
            //dic1["氏名：白木"] ="  点数：100";
            //dic1["氏名：西"] ="    点数： 10";

            //foreach (KeyValuePair<string, string> kvp in dic1)
            //{

            //    Console.WriteLine("{0}{1,2}", kvp.Key, kvp.Value);
            //}

            //            (33) (32) で作成した配列を利用して、それぞれの点数と合計点、平均点（小数以下は
            //切り捨て）を出力してください。
            //氏名：矢吹 点数： 2
            //氏名：丹下 点数： 74
            //氏名：力石 点数： 80
            //氏名：白木 点数：100
            //氏名：西 点数： 10
            //受験者 5 名
            //合計点 266 点
            //平均点 53 点

            //var dic = new Dictionary<string, int>();
            //dic["氏名：矢吹"] = 2;
            //dic["氏名：丹下"] = 74;
            //dic["氏名：力石"] = 80;
            //dic["氏名：白木"] = 100;
            //dic["氏名：西  "] = 10;
            //int zyuken = 0;
            //int goukei = 0;
            //foreach (var a in dic)
            //{
            //    Console.WriteLine("{0}　点数：{1,3}", a.Key, a.Value);
            //    zyuken++;
            //    goukei = goukei + a.Value;
            //}
            //Console.WriteLine("受験者　{0,3}名", zyuken);
            //Console.WriteLine("合計点　{0,3}点", goukei);
            //Console.WriteLine("平均点　{0,3}点", goukei/zyuken);



            //            (34) (32) の配列を利用して、次の基準で判定し、判定結果を出力してください。ただ
            //し、switch 文を使うこと。
            //８０点以上 →優
            //７０点～７９点→良
            //６０点～６９点→可
            //６０点未満 →不可
            //氏名：矢吹 点数： 2 評価：不可
            //氏名：丹下 点数： 74 評価：良
            //氏名：力石 点数： 80 評価：優
            //氏名：白木 点数：100 評価：優
            //氏名：西 点数： 10 評価：不可


            //var dic = new Dictionary<string, int>();
            //dic["氏名：矢吹"] = 2;
            //dic["氏名：丹下"] = 74;
            //dic["氏名：力石"] = 80;
            //dic["氏名：白木"] = 100;
            //dic["氏名：西  "] = 10;
          
            //foreach (var a in dic)

            //{
            //    if (80<=a.Value)
            //    {
            //        Console.WriteLine("{0}　点数：{1,3} 評価：　優", a.Key, a.Value);
                    
            //    }
            //    else if (80 > a.Value&&70<=a.Value)
            //    {
            //        Console.WriteLine("{0}　点数：{1,3} 評価：　良", a.Key, a.Value);

            //    }
            //    else if (70 > a.Value && 60 <= a.Value)
            //    {
            //        Console.WriteLine("{0}　点数：{1,3} 評価：　可", a.Key, a.Value);

            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}　点数：{1,3} 評価：不可", a.Key, a.Value);

            //    }
            //}
          


            //foreach (KeyValuePair<string, int> kvp in dic1)
            //{

            //    Console.Write("{0}  　{1,3}点", kvp.Key, kvp.Value);
            //    if (kvp.Value >= 80)
            //    { Console.WriteLine("　評価：優"); 
            //    }
            //    else if (kvp.Value < 80&&kvp.Value>=70)
            //    {
            //        Console.WriteLine("　評価：良");
            //    }
            //    else if (kvp.Value < 70&&kvp.Value>=60)
            //    {
            //        Console.WriteLine("　評価：可");
            //    }
            //    else
            //    {
            //        Console.WriteLine("　評価：不可");
            //    }
            //}

            //            (35) まず、
            //0～6 の数字を入力してください。対応した曜日を表示します。
            //と画面に表示し、キーボードから0～6 の数字を入力すると、その数字に応じて次のよ
            //うに対応する曜日を表示して終了するプログラムを作ってください。対応する曜日を求
            //める際は switch 文を使うこと。
            //0 日曜日、1 月曜日、…、6 土曜日
            //なお、0～6 以外の数字の入力があった場合には
            //0～6 の範囲で入力してください
            //と表示して最初に戻り、数字以外の入力があった場合には
            //数字を入力してください
            //と表示して最初に戻るようにして下さい。

            //Console.WriteLine("0～6の数字を入力してください、対応した曜日を表示します");
            //string input = "";
            //int a;
            //input=Console.ReadLine();
            //while (int.TryParse(input, out a) == false||(a>6||a<0))
            //{
            //    if (a > 6 || a < 0)
            //    {
            //        Console.WriteLine("0～6の範囲で入力してください");
            //    }
            //    else
            //    {
            //        Console.WriteLine("数字を入力してください");
            //    }
            //        input = Console.ReadLine();
            //}

            //switch(a)
            //{
            //    case(0):
            //        Console.WriteLine("日曜日");
            //        break;

            //    case (1):
            //        Console.WriteLine("月曜日");
            //        break;
            //    case (2):
            //        Console.WriteLine("火曜日");
            //        break;
            //    case (3):
            //        Console.WriteLine("水曜日");
            //        break;
            //    case (4):
            //        Console.WriteLine("木曜日");
            //        break;
            //    case (5):
            //        Console.WriteLine("金曜日");
            //        break;
                    
            //    case(6):
            //        Console.WriteLine("土曜日");
            //        break;
            //}


            //int a;
            //string input = "";
            //Console.WriteLine("0～6 の数字を入力してください。対応した曜日を表示します。");
            //input = Console.ReadLine();

            //while (int.TryParse(input, out a) == false||(a < 0 | a > 6))
            //{
            //    if (a < 0 | a > 6)
            //    {
            //        Console.WriteLine("0～6 の範囲で入力してください");
            //    }
            //    else
            //    {
            //        Console.WriteLine("数字を入力してください");
            //    }
            //    input = Console.ReadLine();
            //}

            //switch (a)
            //{
            //    case (0):
            //        Console.Write("日曜日");
            //        break;
            //    case (1):
            //        Console.Write("月曜日");
            //        break;
            //    case (2):
            //        Console.Write("火曜日");
            //        break;
            //    case (3):
            //        Console.Write("水曜日");
            //        break;
            //    case (4):
            //        Console.Write("木曜日");
            //        break;
            //    case (5):
            //        Console.Write("金曜日");
            //        break;
            //    case (6):
            //        Console.Write("土曜日");
            //        break;

            //}
            Console.ReadLine();

        }
    }
}
