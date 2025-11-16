using System;

//名前空間（プロジェクトと揃えるのが一般的）
namespace HelloCSharp
{
    class Program
    {
        //クラスやメソッド名はPascalCase（大文字始まり）
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, C# World!");
                //変数名はcamelCase(小文字始まり)
                string? name = Console.ReadLine();
                Console.WriteLine($"こんにちは、{name}さん");


                Console.WriteLine("数字を入力してください");
                string? inputY = Console.ReadLine();
                Console.WriteLine("もうひとつ数字を入力してください");
                string? inputX = Console.ReadLine();

                Console.WriteLine("演算子を入力してください。(+, -, *, /):");
                string? op = Console.ReadLine();

                //nullチェック
                if(string.IsNullOrEmpty(inputY) || string.IsNullOrEmpty(inputX))
                {
                    Console.WriteLine("入力が不足しています。");
                    return;
                }
                int y = int.Parse(inputY);
                int x = int.Parse(inputX);

                int result = 0;
                switch (op)
                {
                    case "+":
                        result = x + y; break;
                    case "-":
                        result = x - y; break;
                    case "*":
                        result = x * y; break;
                    case "/":
                        if(x == 0)
                        {
                            Console.Write("0で割ることはできません.");
                            return;
                        }
                        result = x / y; break;
                    default:
                        Console.WriteLine("不正な演算子です。+, -, *, / のいずれかを選択してください。");
                        return;
                }
                Console.WriteLine($"{y} {op} {x} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("数字として認識できませんでした。");
            }catch (Exception ex)
            {
                Console.WriteLine($"予期しないエラーが発生しました。：{ex.Message}");
            }

        }
    }
}