using System.Collections;

class Program {
    static void Main() {
        // Arreglo tradicional de nombres
        string[] nombres = {"Juan", "Pedro", "María", "Luis"};

        // Crear una tabla de hash vacía para almacenar los nombres
        Hashtable tablaNombres = new Hashtable();

        // Copiar los elementos del arreglo a la tabla de hash
        for (int i = 0; i < nombres.Length; i++) {
            tablaNombres.Add(nombres[i], i);
        }

        // Buscar un elemento en la tabla de hash
        if (tablaNombres.ContainsKey("María")) {
            int indice = (int) tablaNombres["María"];
            Console.WriteLine("El índice de María en el arreglo es: " + indice);
        }

        // Modificar un elemento en la tabla de hash
        if (tablaNombres.ContainsKey("Pedro")) {
            tablaNombres["Pedro"] = 3;
        }

        // Imprimir los elementos de la tabla de hash
        foreach (DictionaryEntry elemento in tablaNombres) {
            Console.WriteLine(elemento.Key + ": " + elemento.Value);
        }
    }
}
