int[] array = { 14, 62, 23, 48, 5234, 46, 3257, 85, 229 };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n )
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index++;

}
