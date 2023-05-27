var stack = new Stack<int>();      // Criação da pilha que armazenará inteiros

stack.Push(5);
stack.Push(10);
stack.Push(15);

int x = stack.Pop();        
int y = stack.Pop();
int z = stack.Pop();

Console.WriteLine(y);              // 10
Console.WriteLine(z);              // 5
public class Stack<T>              // Na criação da classe, determinamos que haverá um tipo genérico T
{
  int position;
  T[] data = new T[100];              // O tipo T é utilizado posteriormente como parte do código
  public void Push(T obj) => data[position++] = obj;
  public T Pop() => data[--position];
}
