using System;
using System.IO;
using System.Text;

namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FileStream F = new FileStream("../../../test.txt",
            FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;

            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            F.Dispose();*/
            //Console.ReadKey();

            string file = "../../../qq.txt";
            string[] createText = { "w", "h", "a", "t", "2", "1" };
            // 按照UTF8编码输出
            File.AppendAllText(file, String.Join("*",createText), Encoding.UTF8);

            /*if (!File.Exists(file))
            {
                // 输出字符
                string[] createText = { "w", "h", "a", "t", "2", "1" };
                // 按照UTF8编码输出
                File.WriteAllLines(file, createText, Encoding.UTF8);
            }

            string appendText = "IT小奋斗" + Environment.NewLine;
            // 按照UTF8编码追加输出
            File.AppendAllText(file, appendText, Encoding.UTF8);*/
        }
    }
}