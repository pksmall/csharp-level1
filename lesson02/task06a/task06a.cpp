/*
 * Павел Корженко
 */

 /*
  * 6. Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется
  *    число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя
  *    структуру DateTime.
  */

#include <iostream>
#include <ctime>
using namespace std;

long CalculateNumbers(long i)
{
	long count = 0;
	while (i > 0)
	{
		i = i / 10;
		count++;
	}
	return count;
}

void task06()
{
	long minNumber = 1;
	long maxNumber = 1000000000;
	long gns_amount = 0;
	long amountNumbers = 0;

	cout << "\nКоличество 'Хороших' чисел в интервале от 1 до 1 000 000 000";
	clock_t t1 = clock();
	for (long i = minNumber; i < maxNumber; i++)
	{
		amountNumbers = CalculateNumbers(i);
		if ((i % amountNumbers) == 0)
			gns_amount++;
	}
	clock_t t2 = clock();
	cout << "\nсоставило " << gns_amount << " штук";
	cout << "\nПотрачено " << (t2 - t1 + .0) / CLOCKS_PER_SEC << " sec" << endl;
}

int main()
{
	task06();
}
