using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> list1 = new List<int>() { 2, 4, 5, 7,  9};
            List<int> list2 = new List<int>() { 2, 4, 5, 7,  9};

            //a)
            Console.WriteLine("Union (Giảm dần): ");

            //Sử dụng phuong thức Union để kết hợp hai danh sách và loại bỏ các phần tử trùng nhau
            var union = list1.Union(list2).OrderByDescending(x => x);
            foreach (var item in union)
            {
                Console.WriteLine(item + " ");
            }

            //b)
            Console.WriteLine("\n\n Intersect: ");
            //Sử dụng phương thức Intersect để lấy các phần tử chung của hai danh sách
            var intersect = list1.Intersect(list2);
            foreach (var item in intersect)
            {
                Console.WriteLine(item + " ");
            }

            //c)
            Console.WriteLine("\n\n Concat: (Tăng dần)");
            //Sử dụng phương thức Concat để kết hợp hai danh sách
            var concat = list1.Concat(list2).OrderBy(x => x);
            foreach (var item in concat)
            {
                Console.WriteLine(item + " ");
            }
            //d)
            Console.WriteLine("\n\nExcept: ");
            //Sử dụng phương thức Except để loại bỏ các phần tử có trong danh sách thứ hai khỏi danh sách đầu tiên 
            var except = list1.Except(list2);
            foreach (var item in except)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
