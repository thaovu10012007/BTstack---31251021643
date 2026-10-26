using System;
using System.Collections.Generic;
using System.Text;

namespace BTstack___31251021643.stack
{
    internal class stack
    {
        public static void Main(string[] args)
        {
            int[] temperature = { 73, 74, 75, 71, 69, 72, 76, 73 };
            int n = temperature.Length;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && temperature[i] > temperature[stack.Peek()])
                {
                    int prevIndex = stack.Pop(); // Lấy ra chỉ số ngày cũ
                    result[prevIndex] = i - prevIndex; // Tính khoảng cách số ngày phải chờ
                }

                // Đẩy chỉ số ngày hiện tại vào stack để tiếp tục chờ
                stack.Push(i);
            }
            Console.WriteLine("Kết quả: " + string.Join(" ", result));
        }
    }
}
