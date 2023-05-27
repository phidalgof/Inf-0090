// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var o = new Octopus();    // Criação de um objeto do tipo Octopus
Console.WriteLine(o.Age); // 10

var ob = new Octopus2("Jack");
Console.WriteLine(ob.Name);  // Jack  
//ob.Legs = 20;                // Erro de compilação


// métodos
Console.WriteLine(Foo1(10) == Foo2(10));    // True


int Foo1(int x) { return x * 2; }
int Foo2(int x) => x * 2;                   // Expression-embodied notation


var octo = new Octopus3();

octo.Foo(123);         // int
octo.Foo(123.0);       // double
octo.Foo(123, 123F);   // int, float
octo.Foo(123F, 123);   // float, int



class Octopus
{
    string name;            // Atributo do tipo string, sem valor
    public int Age = 20;    // Atributo do tipo int, com valor
}


class Octopus2
{
  public readonly string Name;
  public readonly int Legs = 8;
  
  public Octopus2(string name)
  {
    Name = name;
  }
}


class Octopus3
{
    public void Foo(int x)         { Console.WriteLine("int"); }
    public void Foo(double x)      { Console.WriteLine("double"); }
    public void Foo(int x, float y) { Console.WriteLine("int, float"); }
    public void Foo(float x, int y) { Console.WriteLine("float, int"); }
}

