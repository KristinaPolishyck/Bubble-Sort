/*
 * Created by SharpDevelop.
 * User: Khrystyna Polishchuk
 * Date: 28.08.2017
 * Time: 15:41

 */
using System;
using System.ComponentModel;

namespace UingBubbleSort
{
	class Program
	{
		static int[] Bubblesort(int[] mas)
		{
			int temp;
			for (int i=0; i<mas.Length; i++)
			{
				for (int j=i+1; j<mas.Length; j++)
				{
				if(mas[i]>mas[j])
				{
					temp= mas[i];
					mas[i]=mas[j];
					mas[j]=temp;
				}
			}
			} return mas;
		}
		public static void Main(string[] args)
		{
			Console.WriteLine("сколько чисел необходимо отсортировать?");
			int numbers= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Пожалуйста, ввседите ччисла для ортировки:");
			int[] masOfNumbers = new int[numbers];
			for(int i=0; i<masOfNumbers.Length; i++){
				masOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
			}
			Bubblesort(masOfNumbers);
			Console.WriteLine("Отсортированный массив чисел:");
			foreach(int number in masOfNumbers){
				Console.WriteLine(number);
			}
			Console.ReadLine();			
		}
	}
}