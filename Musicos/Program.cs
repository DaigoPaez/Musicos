﻿//clases abstractas solo pueden generar subclases, pero no objetos directamente
abstract class Musico
{
    public string Nombre {get;set;}
    public Musico (string n){Nombre=n;}
    public virtual string GetSaludo() => "Hola, soy " + Nombre;
    public virtual void Saluda(){Console.WriteLine(GetSaludo());}
    public /*virtual*/ abstract void Toca(); //Metodos abstractos no tienen implementación, deben estar en clases abstractas para existir.
    /*{
        Console.WriteLine($"{Nombre} tocando su instrumento");
    }*/
}

class Bajista:Musico
{
    public string bajo {get;set;}
    public Bajista(string n, string b):base(n)
    {
        bajo=b;
    }
    public override /*new*/ void Toca()
    {
            Console.WriteLine($"{Nombre} tocando su {bajo}");
    }
}

class Baterista:Musico
{
    public string bateria {get;set;}
    public Baterista(string n, string b):base(n)
    {
        bateria=b;
    }
        public override /*new*/ void Toca()
    {
            Console.WriteLine($"{Nombre} tocando su {bateria}");
    }
        public override string GetSaludo() => base.GetSaludo() + " y soy baterista";
        public override /*virtual*/ void Saluda(){Console.WriteLine(GetSaludo());}
}
class Program
{
    static void Main(string[] args)
    {
    List<Musico> grupo=new List<Musico>();
    grupo.Add(new Baterista("Mario", "batería"));
    grupo.Add(new Bajista("Joe", "bajo"));

    foreach(var m in grupo)
        m.Saluda();
    foreach(var m in grupo)
        m.Toca();
    }
}
