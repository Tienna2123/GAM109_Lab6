using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> list = new List<int>() { 2, 4, 5, 7,  9};
            List<string> listStr = new List<string>() { null,  "T1", "T2", "T3", null };
            List<string> listNull = new List<string>();

            // a) Tìm số chẵn đầu tiên và lớn hơn 5 trong listInt
            int firstEven = list.FirstOrDefault(x => x % 2 == 0 && x > 5);
            if (firstEven != 0)
            {
                Console.WriteLine($"Số chẵn đầu tiên và lớn hơn 5 là: {firstEven}");
            }
            else
            {
                Console.WriteLine("Không có số chẵn nào lớn hơn 5");
            }            
            Console.WriteLine("-----");

            //b) Tìm phần tử cuối cùng trong listInt có giá trị > 200
            int last = list.LastOrDefault(x => x > 200);
            if (last != 0)
            {
                Console.WriteLine($"phần tử cuối cùng trong listInt có giá trị > 200 là: {last}");
            }
            else
            {
                Console.WriteLine("Không có phần tử cuối cùng trong listInt có giá trị > 200");
            }
            Console.WriteLine("-----");

            //c) Tìm phần tử đầu tiên trong listStr có giá trị bắt đầu bằng ký tự “T”
            string firstStr = listStr.FirstOrDefault(x => x != null && x.StartsWith("T"));
            if (firstStr != null)
            {
                Console.WriteLine($"phần tử đầu tiên trong listStr có giá trị bắt đầu bằng ký tự “T” là: {firstStr}");
            }
            else
            {
                Console.WriteLine("Không có phần tử đầu tiên trong listStr có giá trị bắt đầu bằng ký tự “T”");
            }
            Console.WriteLine("-----");

            //d) Tính tổng các trị tại vị trí index lẻ và số đó chia hết cho 2 trong listInt
            int sum = list.Where((x, index) => index % 2 != 0 && x % 2 == 0).Sum();
            Console.WriteLine($"Tổng các trị tại vị trí index lẻ và số đó chia hết cho 2 trong listInt là: {sum}");
            Console.WriteLine("-----");
            
            
        }
    }
}
