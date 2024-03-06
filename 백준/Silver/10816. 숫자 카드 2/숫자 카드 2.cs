using System;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();

        int a = int.Parse(sr.ReadLine());
        int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        Array.Sort(b);
        // 가진 카드

        int c = int.Parse(sr.ReadLine());
        int[] d = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        // 찾을 카드
  

        for (int i = 0; i < c; i++)
        {
            int firstOccurrence = BinarySearchFirstOccurrence(b, d[i]);
            //중앙에서 왼쪽으로 이진탐색
            int lastOccurrence = BinarySearchLastOccurrence(b, d[i]);
            //중앙에서 오른쪽으로 이진탐색
            if (firstOccurrence != -1 && lastOccurrence != -1)
            {
                int count = lastOccurrence - firstOccurrence + 1;
                sb.Append(count + " ");
            }
            else
            {
                sb.Append("0 ");
            }
        }

        sw.Write(sb.ToString());
        sw.Close();
        sr.Close();
    }

    static int BinarySearchFirstOccurrence(int[] array, int target)
    {
        int low = 0;//시작 값
        int high = array.Length - 1;// 끝값
        int result = -1;// 못찾았을 경우

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            //중간값
            if (array[mid] == target)
            {
                result = mid;
                high = mid - 1; // Continue searching to the left
            }
            else if (array[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return result;
    }

    static int BinarySearchLastOccurrence(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] == target)
            {
                result = mid;
                low = mid + 1; // 오른쪽으로 계속 탐색
            }
            else if (array[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return result;
    }
}
