// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

//CRandom(キャラクター設定自動設定ソフトウェア)へようこそ!!
Console.WriteLine("CRandom(.NET 7.0/C#)へようこそ!");

//宣言
//コマンド
var comand = "";
//ランダムな数値
Random rand = new Random();
//1D6
int d6;
//ジャンル
string kind = "";
//コマンド出力内容
string answ = "";

Console.WriteLine("------------- ---------------");
Console.WriteLine("|           | |Maker:LEC    |");
Console.WriteLine("|           | |             |");
Console.WriteLine("|  CRandom  | |Base:.NET 7.0|");
Console.WriteLine("|           | |             |");
Console.WriteLine("|           | |Lang:jp      |");
Console.WriteLine("------------- ---------------");

//メイン処理
while (true)
{
    //コマンドを入力してください
    Console.WriteLine("コマンドを入力してください。");
    //入力画面受付
    comand = Console.ReadLine();
    //コマンドを認識
    Console.WriteLine("コマンド:{0}", comand);

    //コマンドの判別
    switch (comand)
    {
        //"性格"を入力することでキャラクターにランダムな性格を割り当て
        case "性格":
        case "c":
        case "character":
            //1D6を計算
            d6 = rand.Next(1, 7);
            kind = "性格";
            switch (d6)
            {
                case 1:
                    answ = "元気";
                    break;

                case 2:
                    answ = "おとなしい";
                    break;

                case 3:
                    answ = "恥ずかしがりや";
                    break;
                    
                case 4:
                    answ = "高飛車";
                    break;
                    
                case 5:
                    answ = "あほ";
                    break;
                    
                case 6:
                    answ = "積極的";
                    break;
            }
            break;
            
        //"年齢"を入力することでキャラクターにランダムな年齢を割り当て
        case "年齢":
        case "a":
        case "age":
            kind = "年齢";
            d6 = rand.Next(0, 100);
            answ = $"{d6}";
            break;

        //"終了"/exitの入力で終了
        case "終了":
        case "exit":
            kind = "特殊コマンド";
            answ = "終了";
            break;
    }

    //結果を出力
    Console.WriteLine("");
    Console.WriteLine($"{kind}:{answ}");
    Console.WriteLine("");
    kind = "";
    answ = "";

    //終了
    if (comand == "exit" || comand == "終了")
        break;
}
