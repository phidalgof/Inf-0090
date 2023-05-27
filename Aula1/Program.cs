// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// tipos de dados inteiros com sinal: sbyte, short, int, long
sbyte s = 20;
short t = -32;
//int i = -1;
long l = -3000;

// tipos de dados inteiros sem sinal: byte, ushort, uint, ulong
byte bb = 255;
ushort us = 2;
uint ui = 5;
ulong ul = 5000;

// tipos de dados reais: float (4 bytes), double (8 bytes), decimal (16 bytes)
float f = 3.14F;
double d = 1.23;
decimal g = 2.32M;

// Sufixos podem ser usados para especificar o tipo de dado. 
// Sendo eles: F = float, D = double, M = decimal, U = uint, L = long, UL = ulong.
long li = 5;            // Nenhum sufixo é necessário: Conversão implícita de int para long
double dx = 4.0;        // O sufixo D é redundante
float ff = 4.5F;        // Não irá compilar sem o sufixo F
decimal fd = -1.23M;    // Não irá compilar sem o sufixo M

// Tipos numéricos inteiros podem usar notação decimal ou hexadecimal;
// hexadecimal é denotado com o prefixo 0x:
int x = 127;
long y = 0x7F;

// C# também permite especificar números binários com o prefixo 0b:
int b = 0b1010_1011_1100_1101_1110_1111;

// Podemos inserir um underscore para deixar a leitura mais fácil:
int million = 1_000_000;
double doubleMillion = 1E06; // Notação exponencial é permitida com o sufixo E


// Tipos de dados matriciais (arrays)

char[] vowels = new char[5];    // Um vetor de tamanho 5 do tipo char

vowels[0] = 'a';
vowels[1] = 'e';
vowels[2] = 'i';
vowels[3] = 'o';
vowels[4] = 'u';
Console.WriteLine(vowels[1]);      // e

char[] easy = {'a','e','i','o','u'};

int[] a = new int[1000];
Console.Write(a[123]);    // 0

int[,] matrix = new int[3, 3];    // Vetor de inteiros com duas dimensões

for (int i = 0; i < matrix.GetLength(0); i++) // O metodo GetLength retorna o tamanho de um vetor
  for (int j = 0; j < matrix.GetLength(1); j++)
    matrix[i, j] = i * 3 + j;