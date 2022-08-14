//Задача: написать программу, 
//которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.
string[] Z;
            Console.WriteLine("Введите массив строк через пробел");
            string stroka = Console.ReadLine();
            Z = stroka.Split(' ');
            var result = new string[Z .Length];
            var realSize = 0;
            foreach (var value in Z )
            {
                if (value.Length <= 3)
                {
                    result[realSize] = value;
                    realSize++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
            Console.ReadKey(true);
