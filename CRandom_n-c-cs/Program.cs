Console.WriteLine("CRandom(.NET 8.0/C#)へようこそ!");

// 宣言
var comand = "";
Random rand = new();
int d6;
string kind = "";
string answ = "";

Console.WriteLine("------------- ----------------");
Console.WriteLine("|           | |Maker: LEC    |");
Console.WriteLine("|           | |              |");
Console.WriteLine("|  CRandom  | |Base: .NET 8.0|");
Console.WriteLine("|           | |              |");
Console.WriteLine("|           | |Lang: Japanese|");
Console.WriteLine("------------- ----------------");

while (true)
{
    Console.WriteLine("コマンドを入力してください。");
    comand = Console.ReadLine(); // 入力受付
    Console.WriteLine("コマンド: {0}", comand);

    // コマンドの判別
    switch (comand)
    {
        // "性格"を入力することでキャラクターにランダムな性格を割り当て
        case "性格":
        case "c":
        case "character":
            // 1D6を計算
            d6 = rand.Next(1, 7);
            kind = "性格";
            answ = d6 switch
            {
                1 => "元気",
                2 => "おとなしい",
                3 => "恥ずかしがりや",
                4 => "高飛車",
                5 => "あほの子",
                6 => "積極的",
                _ => throw new NotImplementedException(),
            };
            break;
            
        // "年齢"を入力することでキャラクターにランダムな年齢を割り当て
        case "年齢":
        case "a":
        case "age":
            kind = "年齢";
            d6 = rand.Next(0, 100);
            answ = $"{d6}";
            break;

        // "ヒント"で使い方を表示
        case "ヒント":
        case "ヘルプ":
        case "h":
        case "help":
        case "hint":
            kind = "ヒント";
            answ = "\n" + 
                   "c - make random character\n" + 
                   "age - show random age\n" + 
                   "help - show help for this app\n" + 
                   "exit - exit this app\n";
            break;

        // "終了"/exitの入力で終了
        case "終了":
        case "exit":
            kind = "特殊コマンド";
            answ = "終了";
            break;
    }

    // 結果を出力
    Console.WriteLine("");
    Console.WriteLine($"{kind}: {answ}");
    Console.WriteLine("");
    kind = "";
    answ = "";

    // 終了
    if (comand == "exit" || comand == "終了")
        break;
}
