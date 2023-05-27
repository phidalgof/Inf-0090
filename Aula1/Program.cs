// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// tipos de dados inteiros com sinal: sbyte, short, int, long
sbyte s = 20;
short t = -32;
int i = -1;
long l = -3000;

// tipos de dados inteiros sem sinal: byte, ushort, uint, ulong
byte b = 255;
ushort us = 2;
uint ui = 5;
ulong ul = 5000;

// tipos de dados reais: float (4 bytes), double (8 bytes), decimal (16 bytes)
float f = 3.14F;
double d = 1.23;
decimal g = 2.32M;

// Sufixos podem ser usados para especificar o tipo de dado. 
// Sendo eles: F = float, D = double, M = decimal, U = uint, L = long, UL = ulong.
long i = 5;            // Nenhum sufixo é necessário: Conversão implícita de int para long
double x = 4.0;        // O sufixo D é redundante
float f = 4.5F;        // Não irá compilar sem o sufixo F
decimal d = -1.23M;    // Não irá compilar sem o sufixo M

// Tipos numéricos inteiros podem usar notação decimal ou hexadecimal;
// hexadecimal é denotado com o prefixo 0x:
int x = 127;
long y = 0x7F;

// C# também permite especificar números binários com o prefixo 0b:
int b = 0b1010_1011_1100_1101_1110_1111;

// Podemos inserir um underscore para deixar a leitura mais fácil:
int million = 1_000_000;
double doubleMillion = 1E06; // Notação exponencial é permitida com o sufixo E