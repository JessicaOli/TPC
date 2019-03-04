interface I1{}
interface I2{}
interface I3{}
class A{}
class B extends A implements I1{}
class C extends B implements I2,I3{
    public String toString(){
        return "C";
    }
}

class S{
    public String toString(){
        return "C";
    }
}

public class tpc2J{

    private static void printBase(Class klass){
        if(klass==Object.class){
            System.out.println();
            return;
        }
        Class sup=klass.getSuperclass();
        System.out.print(" ----|> "+sup.getSimpleName());
        printInterfaces(sup);
        printBase(sup);
    }

    private static void printHierarchy(Object obj){
        Class klass=obj.getClass();
        System.out.print(obj+" has type "+klass.getSimpleName()+" ");
        printInterfaces(klass);
        printBase(klass);
    }

    private static void printInterfaces(Class klass){
        Class[] itfs=klass.getInterfaces();
        if(itfs==null|| itfs.length==0) return;
        String res="";
        for(Class c: itfs)
            res+=c.getSimpleName()+" ";
        System.out.print(res);
    }

    public static void main(String[] args){
        String s="isel";
        Object o=s;
        Object o2=o;
        int n1=7;
        Integer n2=7;
        Integer n3=n1;
        Object n4=n1;

        printHierarchy(new Object());
        printHierarchy(s);
        printHierarchy(o);
        printHierarchy(n1);

        C c=new C();
        S st=new S();
        printHierarchy(c);
        printHierarchy(st);
    }
}