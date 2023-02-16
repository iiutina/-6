/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int [] FillArray ()
{
Console.Write ("Input count of elements of araay: ");
   int elements= Convert.ToInt32 (Console.ReadLine());
int [] array= new int[elements];

for (int i=0; i< elements; i++)
{
   Console.Write ("Input element of araay: ");
   array[i]= Convert.ToInt32 (Console.ReadLine());
}

 return array;
}

void PrintArray (int [] array01)
{
    for (int i=0; i < array01.Length; i++)
         Console.Write (array01[i] + " ");
}

int DigitArray(int [] array01)
{
    int count = 0;
    for (int i=0; i < array01.Length; i++)
    {
      if (array01[i] >0)
      {
          count= count+ 1;
      }
    }
    return count;
}    

int [] array02 = FillArray ( );
PrintArray (array02);
int array03 = DigitArray (array02);
Console.WriteLine ($" even number {array03} ");



/*Задача 43: Напишите программу, 
которая найдёт точку пересечения 
двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/* void  InterPoinX ( double b1, double k1,double b2,double k2)
 
{
    double x=0;
    double y=0;
    if (k1==k2 && b1==b2)
    {
    
    Console.WriteLine(" straight lines match "); 
   
    }
        else if (k1==k2)
        {
        Console.WriteLine(" straight lines are parallel "); 
   
        }
            else
            {
            x = (b2-b1)/(k1-k2);
            y = (k1*(b2-b1))/(k1-k2)+b1;
    
            Console.WriteLine($" point of intersection of two lines ({x};{y})"); 
  
            } 
 }
 

Console.WriteLine("Input   value of b1:"); 
int b1coord = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Input  value of k1:"); 
int k1coord = Convert.ToInt32 (Console.ReadLine());


Console.WriteLine("Input  value of b2:"); 
int b2coord = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Input  valueof k2:"); 
int k2coord = Convert.ToInt32 (Console.ReadLine());

 InterPoinX  (b1coord,k1coord,b2coord,k2coord);
//Console.WriteLine ($"точка пересечения is {InterPoinX}");
*/
