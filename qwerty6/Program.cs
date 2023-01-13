//двухмерные массивы лекция
// [1-строки,2-столбцы] // индексы меняются от нуля если 5 то он 0 до 4

//string[,] table = new string[2, 5];
//table[1, 2] = "слово";   // указываем к какой строке и столбцу  обращаемся и работаем как с обычной переменной

//for (int rows = 0; rows < 2; rows++)     // 2-[х строк]
//{
  //for (int colums = 0; colums < 5; colums++)     // 2  цикл 
  //{
      // Console.WriteLine($"-{table [rows, colums]}-");    // распечатать можем 
  //}
//}



//int[,] matrix = new int[3, 4];

//for (int i = 0; i < 3; i++)       в самом массиве не меняютя, а в циклах надо смотреть как будем работать
//{
  ///for (int j = 0; j < 4; j++) 
  //{  
      // Console.Write($"{matrix [i, j]} ");    
  //}
//Console.WriteLine();
//}


//int[,] matrix = new int[3, 4];

//for (int i = 0; i < matrix.GetLength(0); i++)      //0 означает кол=во строк
//{
  //for (int j = 0; j < matrix.GetLength(1); j++)  // эта конструкция выдаст нам 4 столбика
 // {  
      // Console.Write($"{matrix [i, j]} ");    
 // }
//Console.WriteLine()
//}

// опишем метод, который будет печатать двухмерную матрицу и соответственно заполнит ее числами


void PritntArray(int[,] matr)              // метод чтоб распечатать
{
    for (int i = 0; i < matr.GetLength(0); i++)   
      {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {  
          Console.Write($"{matr[i,j]} ");    
         }
   Console.WriteLine();
       }
}
void FillArray(int[,] matr)        //метод, который заполняет матрицу случайными числами
 {
    for (int i = 0; i < matr.GetLength(0); i++) 
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
           matr[i,j] = new Random().Next(1,10);   //заполнение случайными числами от 1 до 10
      }
   }
 }                                           
int[,] matrix = new int[3,4];
PritntArray(matrix);
FillArray(matrix);
Console.WriteLine();
PritntArray(matrix);
