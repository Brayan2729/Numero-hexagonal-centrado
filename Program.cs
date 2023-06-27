using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Program
{
    public static string HexLattice(int n)
    {
        // Comprobar si n es un número hexagonal centrado válido
        int k = 0;
        while (true)
        {
            int hexagonal = 3 * k * (k + 1) + 1;
            if (hexagonal == n)
            {
                break;
            }
            else if (hexagonal > n)
            {
                return "No válido";
            }
            k++;
        }
        
        // Construir la ilustración del número hexagonal centrado
        string result = "";
        for (int i = k; i > 0; i--)
        {
            result += new string(' ', i) + string.Join(" ", new string('o', k - i + 1).ToCharArray()) + "\n";
        }
        for (int i = 0; i <= k; i++)
        {
            result += new string(' ', i) + string.Join(" ", new string('o', k - i + 1).ToCharArray());
            if (i != k)
            {
                result += "\n";
            }
        }
        
        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(HexLattice(1));
        // Salida:
        //  o

        Console.WriteLine(HexLattice(7));
        // Salida:
        //  o o
        //  o o o
        //  o o

        Console.WriteLine(HexLattice(19));
        // Salida:
        //  o o o
        //  o o o o
        //  o o o o o
        //  o o o o
        //  o o o

        Console.WriteLine(HexLattice(21));
        // Salida:
        //  No válido
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
 