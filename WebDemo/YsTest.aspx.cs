using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class YsTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Cat cat = new Cat();
        Mouse mouse1 = new Mouse("mouse1", cat);
        Mouse mouse2 = new Mouse("mouse2", cat);
        Master master = new Master(cat);
        cat.Cry();
    }
}

public interface Observer
{
    void Response();    //观察者的响应，如是老鼠见到猫的反映
}
public interface Subject
{
    void AimAt(Observer obs);  //针对哪些观察者，这里指猫的要扑捉的对象---老鼠
}
public class Mouse : Observer
{
    private string name;
    public Mouse(string name, Subject subj)
    {
        this.name = name;
        subj.AimAt(this);
    }

    public void Response()
    {
        Console.WriteLine(name + " attempt to escape!");
    }
}
public class Master : Observer
{
    public Master(Subject subj)
    {
        subj.AimAt(this);
    }

    public void Response()
    {
        Console.WriteLine("Host waken!");
    }
}

public class Cat : Subject
{
    private ArrayList observers;
    public Cat()
    {
        this.observers = new ArrayList();
    }
    public void AimAt(Observer obs)
    {
        this.observers.Add(obs);
    }
    public void Cry()
    {
        Console.WriteLine("Cat cryed!");
        foreach (Observer obs in this.observers)
        {
            obs.Response();
        }
    }
}
class MainClass
{
    static void Main(string[] args)
    {
        Cat cat = new Cat();
        Mouse mouse1 = new Mouse("mouse1", cat);
        Mouse mouse2 = new Mouse("mouse2", cat);
        Master master = new Master(cat);
        cat.Cry();
    }
}
