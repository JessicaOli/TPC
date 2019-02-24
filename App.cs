using System;
abstract class App{
	static void Foo(int nr){
		Console.Write(nr);
		Console.Write(", ");
		if(nr==1){
			Console.WriteLine();
			return;
		}
		if(nr%2==0){
			Foo(nr/2);
		}
		else{
		int aux=nr*3;
		aux+=1;
		Foo(aux);
		}
	}
	static void Main(){
		Foo(12);
		Foo(19);
	}
}