

Console.WriteLine("Lütfen bir derinlik giriniz");
int depth = Convert.ToInt32(Console.ReadLine());

int sum=Average.Calculate(depth);
Console.WriteLine($"Fibonacci serisinin dizisinin derinliği{depth} için toplam: {sum}");


Console.ReadKey();
