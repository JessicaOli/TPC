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

public class Student
{
    readonly int nr;
    readonly string name;
    readonly int group;
    readonly string githubId;

    public Student(int nr, string name, int group, string githubId)
    {
        this.nr = nr;
        this.name = name;
        this.group = group;
        this.githubId = githubId;
    }

    public int Nr { get {return nr; } }
    public string Name { get {return name; } }
    public int Group { get {return group; } }
    public string GithubId { get {return githubId; } }
}

class Point{
    int x, y;
    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }
    public int X { get {return x;} set{ x = value;}}
    public int Y { get {return y;} set{ y = value;}}
    public double Module{
        get{
            return Math.Sqrt(x*x + y*y);
        }
    }
}

interface IAccount { long Balance{ get; set; }}

class Account : IAccount {
	public Account(long value){
		Balance=value;
	}
	public long Balance{ get; set; }
	}

class Test{
	
	static void Main(){
		Point p=new Point(7,9);
		Student st=new Student(154134,"Ze Manel",5243,"ze");
		Account ac=new Account(1024);
		Logger.Log(p);
		Logger.Log(st);
		Logger.Log(ac);
	}
}

