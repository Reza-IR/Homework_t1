Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("In this program, we considered a two-dimensional array by default, and we show this array using recursive functions.");
Console.WriteLine();
for (int i = 7; i > 0; i--)
{
    if (i % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    Console.WriteLine($"Please Wait for {i} Seconds");
    Thread.Sleep(1000);
}

Console.Clear();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Cyan;


string[,] myarray = { { "Laptop ======>", "Asus", "Mac", "Lenovo", "Acer" }, { "Mobile ======>", "iPhone", "Samsung", "Asus", "Google" }, { "Tablet ======>", "iPad", "Samsung", "Lenovo", "Surface" }, { "Handheld ====>", "Valve", "Asus", "Lenovo", "Nintendo" }, { "Television ==>", "LG", "Samsung", "Vizio", "Sony" } };
fun(myarray, 0, 0);


void fun(string[,] array, int row, int col)
{
    if (row >= 5 || col >= 5)
    {
        return;
    }

    Console.Write(array[row, col] + "\t");

    fun(array, row, col + 1);

    if (col == 4)
    {
        Console.WriteLine();
        fun(array, row + 1, 0);
    }
}