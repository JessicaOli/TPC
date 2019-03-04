using System;
public class Logger{
	public static void Log(object obj){
		Console.Write("{0}: ",obj.GetType());
		foreach(var p in obj.GetType().GetProperties()){
		Console.Write("{0} = {1}, ", p.Name,p.GetValue(obj));
		}
		Console.WriteLine();
	}
}

class Point{
	
	int a;
	int b;
	
	public Point(int x,int y){
		a=x;
		b=y;
	}
	
	public int A{
		get{return a;}
		
	}

	public int B{
		get{return b;}
		
	}
	
}

class Student{
	int Nr;
	String Name;
	int Group;
	String GithubId;
	
	public Student(int nr,String n,int g,String gId){
		Nr=nr;
		Name=n;
		Group=g;
		GithubId=gId;
	}
	
	public int NR{
		get{return Nr;}
	}
	
	public String NAME{
		get{return Name;}
	}
	
	public int GROUP{
		get{return Group;}
	}
	
	public String GITHUBID{
		get{return GithubId;}
	}
	
}
class Test{
	
	static void Main(){
		Point p=new Point(7,9);
		Student st=new Student(154134,"Ze Manel",5243,"ze");
		Logger.Log(p);
		Logger.Log(st);
	}
}

