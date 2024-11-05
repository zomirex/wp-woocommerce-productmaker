//using System.Runtime.InteropServices;
//using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Concurrent;
using System.IO;
using System.Xml;
char a = Console.ReadKey(false).KeyChar;
string write = @"C:\\Users\\Pcmod\\source\\repos\\test 1\\text.txt";
StreamWriter sw = File.CreateText(write);

while (a != 'z')
{
sw.WriteLine(Console.ReadLine());
 a = Console.ReadKey(false).KeyChar;

}
sw.Close();
StreamReader sr = File.OpenText(write);
string read = sr.ReadToEnd();
Console.WriteLine(read);
sr.Close(); 
