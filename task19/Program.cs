Console.Clear();
Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
int delimetr1=10000;
bool status=true;
for(int i=0;i<2;i++){
    if (num/delimetr1 != num%10){
        Console.WriteLine("нет");
        status=false;
        break;
    }
    num=(num%delimetr1)/10;
    delimetr1=delimetr1/100;
    
}
if (status) Console.WriteLine("да");