// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

 int RazmerMassiva (string text) //Метод позволяет переводить вводимые пользователем строки переводить в числа
 {
     Console.WriteLine(text);
     int result = Convert.ToInt32(Console.ReadLine());
     return result;
 }

 int[] VvodMassiva(int lenght)
 {
     int[] array = new int[lenght];
     for (int i = 0; i < array.Length; i++)
     {
         array[i] = RazmerMassiva($"Введите {i + 1}-й элемент");
     }
     return array;
 }

 void PrintArray(int[] array)
 {
     int index = 0;
     while (index < array.Length)
     {
         Console.Write(array[index] + " ");
         index++;
     }
 }

 int KolichtsvoPolozitelnihChisel(int[] array)
 {
     int count = 0; 
     for (int i = 0; i < array.Length; i++)
     {
     if (array[i] > 0)
     {
         count++;
     }
     }
     return count;
 }

 int lenght = RazmerMassiva("Введите количество элементов массива : ");//Пользователь задал длину массива
 int[] array; // Создали массив
 array = VvodMassiva(lenght); // Пользователь вводит элементы массива
 PrintArray(array); // Вывод массива в консоль
 Console.WriteLine(); // переход на следующую строку 
 Console.WriteLine($"Число положительных чисел = {KolichtsvoPolozitelnihChisel(array)}"); // выводит количество положительных чисел




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Формулы нахождения координат x и y точки пересечения:
// x = (b2-b1)/(k1-k2);
// y = k1*x+b1;
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//const int COEFFICIENT = 0;
//const int CONCSTANT = 1;
//const int X_COORD = 0;
//const int Y_COORD = 1;
//const int LINE1 = 1;
//const int LINE2 = 2;

//double[] lineData1 = InputLineData(LINE1);
//double[] lineData2 = InputLineData(LINE2);

//if (ValidateLines(lineData1, lineData2))
//{
//    double[] coord = FindCoords(lineData1, lineData2);
//    Console.Write($"Точка пересечения уравнений ");
//    Console.Write($"у={lineData1[COEFFICIENT]}*х+{lineData1[CONCSTANT]} и ");
//    Console.Write($"у={lineData2[COEFFICIENT]}*х+{lineData2[CONCSTANT]} ");
//    Console.Write($"Имеет координаты ({coord[X_COORD]}),({coord[Y_COORD]})");
//}

//double Promt(string text)
//{
//    Console.WriteLine(text);
//    double result = Convert.ToDouble(Console.ReadLine());
//    return result;
//}

//double[] InputLineData(int numberOfLine)
//{
//    double[] lineData = new double[2];
   
//    lineData[COEFFICIENT] = Promt($"Введите коэфициент для {numberOfLine} прямой: ");
//    lineData[CONCSTANT] = Promt($"Введите константу для {numberOfLine} прямой: ");

//    return lineData;
//}

//double[] FindCoords(double[] lineData1, double[] lineData2)
//{
//    double[] coord = new double[2];
//    coord[X_COORD] = (lineData1[CONCSTANT] - lineData2[CONCSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
//    coord[Y_COORD] = lineData1[CONCSTANT] * coord[X_COORD] + lineData1[CONCSTANT];
//    return coord;
//}

//bool ValidateLines(double[] lineData1, double[] lineData2)
//{
//    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
//    {
//        if (lineData1[CONCSTANT] == lineData2[CONCSTANT])
//        {
//           Console.WriteLine("Прямые совпадают");
//           return false;
//        }
//        else
//        {
//            Console.WriteLine("Прямые паралельны");
//            return false;
//        }
//    }
//    return true;
// }
