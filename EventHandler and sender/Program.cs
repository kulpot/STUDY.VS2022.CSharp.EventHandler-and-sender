using System;

//ref link:https://www.youtube.com/watch?v=WyrW-i73VGo&list=PLAE7FECFFFCBE1A54&index=17
// EventHandler delegate type with the sender argument.

class Cow
{
    public string Name { get; set; }
    public event EventHandler Moo;
    public void BeTippedOver()
    { 
        if (Moo != null)
            Moo(this, EventArgs.Empty);
    }
}

class MainClass
{
    static void Main()
    {
        Cow c1 = new Cow { Name = "Betsy" };
        c1.Moo += giggle;
        Cow c2 = new Cow { Name = "Georgy" };
        c2.Moo += giggle;
        Cow victim = new Random().Next() % 2 == 0 ? c1 : c2; // make random boolean (Random().Next() & 2 == 0, if its true ref c1 otherwise ref c2
        victim.BeTippedOver();
    }
    static void giggle(object sender, EventArgs e)
    {
        Cow c = sender as Cow;
        Console.WriteLine("Giggle giggle... We made " + 
            c.Name + " moo!");
    }
}