// рекурсия факториал

//int Factorial(int n)  //некоторый метод возвращ инт и вс качесвте аргумента принимает другое целое число
//{
   //if(n == 1) return 1;   //если мы долши до 1 то должны вернуть единицу по определению факториала  0!=1 1! =1
   //else return n * Factorial(n-1);              // в противном случае взять тек.значение и умножить на факториал пред.числа
//}                                //возвращаем пред число и умножаем
//Console.WriteLine(Factorial(3));         // для больших чисел не подходит


//int Factorial(int n)  // до 17 считает верно потом фигня данные переполнены
//{
   //if(n == 1) return 1;   
   //else return n * Factorial(n-1);            
//}   
//for (int i = 1; i < 40; i++)
//{
    // Console.WriteLine($"{i}! = {Factorial(i)}"); 
//}     

double Factorial(int n)  // заменим на дабл для возвращ результата
{
   if(n == 1) return 1;   
   else return n * Factorial(n-1);            
}   
for (int i = 1; i < 40; i++)
{
     Console.WriteLine($"{i}! = {Factorial(i)}"); 
}     