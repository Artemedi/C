﻿// Предварительно выдаем запрос приветствие
Console.WriteLine("Введите ваше имя ");
// ReadLine - при помощи неё происходит считывание данных
// Требуется указать переменную username для ввода данных и её тип. Это будет string - строка.
string username = Console.ReadLine();
// Далее выводим данные в консоль
Console.Write("Привет, ");
// с указанием данных введённых ранее в переменную
Console.Write(username);
// Если указывать Write то вывод и ввод будет на одной строке
// Если указывать WriteLine то вывод и ввод будет на разных строках