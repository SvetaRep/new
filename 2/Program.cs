Console.WriteLine("Введите поочередно три целых числа ");

int a = Convert.ToInt32(Console.ReadLine() );
int b = Convert.ToInt32(Console.ReadLine() );
int c = Convert.ToInt32(Console.ReadLine() );
int max = a;
if ( max < b ) 
{
    max = b ;
}
if ( max< c ) 
{
    max = c;
}
Console.Write( "Максимальное число " + max );