using System;
class Task2{ 
static int fake(int [] numbers){
int n=0;	
if(n<numbers.Length){
n++;
return numbers[n];	
	}	
	}	  
static void Main(string[]args){
int [] numbers={1,2,4,5,6,7};
fake(numbers);

}    
}
