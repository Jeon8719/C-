using System.Text;

string a = Convert.ToString(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
LinkedList<char> list = new LinkedList<char>(a);
list.AddFirst('\0');
LinkedListNode<char> Cursor = list.Last;


for (int i = 0; i < c; i++)
{
    char[] d = Array.ConvertAll(Console.ReadLine().Split(), char.Parse);
    switch (d[0])
    {
        case 'L':
            if (Cursor.Previous != null) Cursor = Cursor.Previous;
            //Cursor = Cursor.Previous ?? Cursor;
            break;
        case 'D':
            //if (Cursor.Next != null) Cursor = Cursor.Next;
            Cursor = Cursor.Next ?? Cursor;
            break;
        case 'B':
            if (Cursor.Previous != null)
            {
                Cursor = Cursor.Previous;
                list.Remove(Cursor.Next);
            }
            break;
        case 'P':
            Cursor = list.AddAfter(Cursor, d[1]);
            break;
    }

}
list.RemoveFirst();
StringBuilder stringBuilder = new StringBuilder();
foreach (char ch in list)
{
    stringBuilder.Append(ch);
}
Console.WriteLine(stringBuilder.ToString());