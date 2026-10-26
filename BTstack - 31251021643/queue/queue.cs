using System;
using System.Collections.Generic;
using System.Text;

namespace BTstack___31251021643.queue
{
    internal class queue
    {
        static void Main()
        {
            int n = 7; // Tổng số người
            int k = 3; // Đếm đến 3 thì loại

            Queue<int> queue = new Queue<int>();

            // Bước 1: Cho tất cả mọi người từ 1 đến n vào hàng đợi
            for (int i = 1; i <= n; i++)
            {
                queue.Enqueue(i);
            }

            List<int> eliminated = new List<int>(); // Danh sách ghi lại thứ tự bị loại

            // Bước 2: Lặp đến khi nào trong hàng chỉ còn lại 1 người
            while (queue.Count > 1)
            {
                // Chuyển k - 1 người đầu tiên từ đầu hàng vòng xuống cuối hàng
                for (int i = 0; i < k - 1; i++)
                {
                    int person = queue.Dequeue(); // Lấy người ở đầu
                    queue.Enqueue(person);        // Đẩy xuống cuối hàng
                }

                // Người thứ k chính là người ở đầu hàng lúc này -> Bị loại
                int outPerson = queue.Dequeue();
                eliminated.Add(outPerson);
            }

            // Bước 3: In kết quả
            Console.WriteLine("Thu tu bi loai: " + string.Join(" ", eliminated));
            Console.WriteLine("Nguoi con lai cuoi cung: " + queue.Peek());
        }
    }
}
