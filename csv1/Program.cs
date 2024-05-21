using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        //日本語の文字コードを使えるようにするプロバイダーの設定
        EncodingProvider provider = System.Text.CodePagesEncodingProvider.Instance;
        var encoding = provider.GetEncoding(932);

        //ファイルの中身を保存するための変数     //改行コード
        var body = "名前,年齢,性別,学部,役職" + Environment.NewLine + "新井,19,女,文学部,なし\n八木,22,男,経営学部,童貞";

        //ファイルを保存する処理(第一引数にパス、第二引数にテキストの中身、第三引数が文字コードの設定)
        System.IO.File.WriteAllText("D:\\Programing\\C#\\FormAppTurtorial\\csv1\\ext.csv", body, encoding);
        Console.WriteLine("保存しました");

    }
}