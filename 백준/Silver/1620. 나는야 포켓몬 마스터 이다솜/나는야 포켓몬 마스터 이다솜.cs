using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();

        string[] firstLine = sr.ReadLine().Split();
        int n = int.Parse(firstLine[0]); // Number of Pokémon
        int q = int.Parse(firstLine[1]); // Number of queries

        Dictionary<string, int> pokemonIndex = new Dictionary<string, int>(n);
        string[] pokemons = new string[n];

        for (int i = 0; i < n; i++)
        {
            string pokemon = sr.ReadLine();
            pokemonIndex[pokemon] = i;
            pokemons[i] = pokemon;
        }

        for (int i = 0; i < q; i++)
        {
            string query = sr.ReadLine();

            if (int.TryParse(query, out int intValue))
            {
                // Query is an integer, find the Pokémon at the specified index
                if (intValue >= 1 && intValue <= n)
                {
                    string result = pokemons[intValue - 1];
                    sb.AppendLine(result);
                }
            }
            else if (pokemonIndex.ContainsKey(query))
            {
                // Query is a Pokémon name, find its index
                int index = pokemonIndex[query] + 1;
                sb.AppendLine(index.ToString());
            }
        }

        sw.Write(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
