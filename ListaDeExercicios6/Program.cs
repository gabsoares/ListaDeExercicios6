int[] numbers = new int[4];

Console.WriteLine("Digite quatro números inteiros e no final te informaremos qual o maior e o menor número digitado");
numbers[0] = Convert.ToInt32(Console.ReadLine());
numbers[1] = Convert.ToInt32(Console.ReadLine());
numbers[2] = Convert.ToInt32(Console.ReadLine());
numbers[3] = Convert.ToInt32(Console.ReadLine());

int smallerNumber, higherNumber;

Array.Sort(numbers);

smallerNumber = numbers[0];
higherNumber = numbers[numbers.Length - 1];

Console.WriteLine($"O maior número digitado foi o {higherNumber} e o menor foi o {smallerNumber}");