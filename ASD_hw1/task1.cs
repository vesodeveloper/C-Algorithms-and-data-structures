using System;
class Task1{
static void PrEl(int[] B){
for(int y=0; y<arr.Length();y++){
    
Console.WriteLine(arr[y]);    
}    
}    
static void Main(string[]args){
Console.WriteLine("Vuvedete broi redove i koloni na masiva:");
var N=int.Parse(Console.ReadLine());
int sum=0; int br=0; int srar;
if((N>=2)&&(N<=6)){
int [,] A=new int[N,N]; int [] B=new int[N]; 
Console.WriteLine("Vuvedete elementi na masiva:");
for(int i=0; i<A.GetLength(0);i++){
for(int x=0; x<A.GetLength(1);x++){
A[i,x]=int.Parse(Console.ReadLine());
//Средно аритметично
 if((A[i]>0)&&(A[x]>0)){
 br++; sum=sum+A[i,x]; srar=sum/br;    
}
// масив В
if(A[i]!=1){
for(int t=0;t<A.GetLength;t++){ B[t]=A[i];  }    
}
}   
}
Console.WriteLine("Srednoto aritmetichno e:"+srar);
// Елементи на масив В
PrEl(B);
}
else{ Console.WriteLine("Greshka!");
    return;
}
}
    
}
