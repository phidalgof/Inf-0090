namespace ProjetoFinal_1;

public class Map
{
    // mapa
    int[,] map = new int[10, 10];

    public static ConsoleColor BackgroundColor { get; set; }
    public static ConsoleColor ForegroundColor { get; set; }

    // metodos adição e remoção de joias e obstaculos
    // metodo imprimir mapa na tela
    void PrintMap() {
        for (int i = 0; i < map.GetLength(0); i++) {
            for (int j = 0; j < map.GetLength(1); j++) {
                Console.Write(map[i, j]);
            }
            Console.Write("\n");
        }
    }
}
