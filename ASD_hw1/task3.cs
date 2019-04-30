using System;
class Task3{
static void Main(string[]args){
Console.WriteLine("Vuvedete N:");
var n=int.Parse(Console.ReadLine());
if((n>=2)&&(n<=12)){
Console.WriteLine("Vuzmojni kombinacii:");    
for(int i=1;i<n-i;i++){
int fst=i; int snd=n-i;    
Console.WriteLine(fst+","+snd+" ");    
}    
}
else Console.WriteLine("Greshka!");
}    
}
