using System;

namespace ConsoleApp8
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ввод строк с клавиатуры
      // и образование нового массива
// 1. Объявление переменных
      string[] AS; // ссылка на массив строк
      int count; // текущее количество строк в массиве
      string s;
      string[] AS2; // дополнительная переменная-ссылка - сохраняет старый массив строк

      // 2. Цикл ввода строк
      Console.WriteLine("Enter strings:");

      count = 0; // обнулить количество строк
      AS = new string[count]; // выделить память для 0 строк

      do
      {
        // Ввести строку
        s = Console.ReadLine();