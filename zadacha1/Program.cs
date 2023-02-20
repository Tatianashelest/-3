Console.Write ("Введите пятизначное число: "); 
int number = Convert.ToInt32(Console.ReadLine());  
 
void check (int limitdigit) 
{ 
   if (limitdigit>=10000 && limitdigit <=99999) 
  Console.WriteLine ("Ура число верное, один момент"); 
  else 
  Console.WriteLine ("Число не 5-ти значное, давайте другой вариант"); 
   
} 
 
check (number); 
 
 
int first = number/10000; 
int fifth = number%10; 
int second = (number/1000)%10; 
int fourth = (number%100)/10; 
 
if (first==fifth && second == fourth) 
Console.WriteLine ("Данное выражение полиндром"); 
else 
Console.WriteLine ("Данное выражение не полиндром 5-ти значного числа");