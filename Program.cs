Console.WriteLine("Числа от 35 до 87");
for (int i=35; i<=85; i++)
{
    int k = i % 7;
    if (k == 1 || k == 2 || k == 5)
        Console.WriteLine($"Числа кратные 7 и имеющие остаток 1,2 или 5 = {i}");
}
Console.ReadKey();  
