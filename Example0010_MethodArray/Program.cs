int[] array = { 14746, 322, 563, 3564, 785, 687, 563, 386 };

int n = array.Length;
int find = 563;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}