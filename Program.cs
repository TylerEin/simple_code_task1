Console.WriteLine("Введите числа для заполнения массива через запятую");
//заполнение массива с клавиатуры
	string nums = Console.ReadLine();
string[] arrayNums = new string[nums.Length];
arrayNums = nums.Split(',');
int[] ints = new int[arrayNums.Length];
for (int i = 0; i < arrayNums.Length; i++)
{
	ints[i] = _parcer(arrayNums[i]);
}

int _parcer(string s)//Метод парсинга строки
{
	int.TryParse(s, out int num);
	if (num == 0 & s != "0") { Console.WriteLine("Ошибка ввода"); return 0; }
	else return num;	
}
//заполнение массива с клавиатуры{end}
//====================================
//Вывод массива в обратном порядке
Console.WriteLine("\nВывод массива в обратном порядке");
for (int i = ints.Length - 1; i >= 0; i--) Console.WriteLine(ints[i]);
//Вывод массива в обратном порядке{end}
//====================================
//Найти сумму четных элементов массива
int sum = 0;
for (int i = 0; i < ints.Length; i++)
{
	if (ints[i] % 2 == 0) sum += ints[i];
}
Console.WriteLine("Сумма четных элементов массива равна " + sum);
//Найти сумму четных элементов массива{end}
//====================================
//Найти наименьшее число массива
Console.WriteLine("\nHаименьший элемент массива равен " + ints.Min());
Console.ReadLine();
//Найти наименьшее число массива{end}
//====================================