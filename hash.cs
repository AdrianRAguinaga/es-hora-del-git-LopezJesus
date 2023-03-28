using System.Collections;

// Crear una nueva tabla de hash
Hashtable miTabla = new Hashtable();

// Insertar elementos en la tabla de hash
miTabla.Add("clave1", "valor1");
miTabla.Add("clave2", "valor2");
miTabla.Add("clave3", "valor3");

// Obtener un valor de la tabla de hash
string valor = (string)miTabla["clave2"];
Console.WriteLine("El valor de clave2 es: " + valor);

// Recorrer todos los elementos de la tabla de hash
foreach (DictionaryEntry elemento in miTabla)
{
    Console.WriteLine("Clave: " + elemento.Key + " Valor: " + elemento.Value);
}
