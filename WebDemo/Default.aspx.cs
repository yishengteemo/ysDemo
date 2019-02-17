using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       A b = new B();
        b.PrintFields();
    }


}

class A

     {

          public A(){

                PrintFields();

           }

          public virtual void PrintFields(){}

      }

class B : A
{

    int x = 1;

    int y;

    public B()
    {

        y = -1;

    }

    public override void PrintFields()
    {

        Console.WriteLine("x={0},y={1}", x, y);

    }
}