class Musico
{
    public string Nombre {get;set;}
    public Musico (string n){Nombre=n;}
    public void Saluda(){Console.WriteLine($"Hola soy {Nombre}");}
    public virtual void Toca()
    {
        Console.WriteLine($"{Nombre} tocando su instrumento");
    }
}

class Bajista:Musico
{
    public string bajo {get;set;}
    public Bajista(string n, string b):base(n)
    {
        bajo=b;
    }
    public new void Toca()
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
        public new void Toca()
    {
            Console.WriteLine($"{Nombre} tocando su {bateria}");
    }
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
