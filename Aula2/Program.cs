// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var o = new Octopus();    // Criação de um objeto do tipo Octopus
Console.WriteLine(o.Age); // 10
class Octopus
{
  string name;            // Atributo do tipo string, sem valor
  public int Age = 10;    // Atributo do tipo int, com valor
}
