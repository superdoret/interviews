// Ejemplo de un array de números enteros
int[] numeros = { 20, 4, 1, 15 };


bool resultado = ExisteCombinacionQueSuma(numeros);
Console.WriteLine("¿Hay al menos una combinación que sume el mismo valor que el máximo? " + resultado);

static bool ExisteCombinacionQueSuma(int[] numeros)
{
    // Encontrar la suma total de todos los elementos del array
    int sumaTotal = 0;
    for (int i = 0; i < numeros.Length; i++)
    {
        sumaTotal += numeros[i];
    }

    // Encontrar todas las combinaciones que sumen el mismo valor que la suma total menos el valor máximo
    int maximo = numeros.Max();    
    
    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] == maximo)
        {
            continue;
        }
        int suma = numeros[i];
        for (int j = i + 1; j < numeros.Length; j++)
        {
            if (numeros[j] == maximo)
            {
                continue;
            }
            suma += numeros[j];
            if (suma == maximo)
            {
                return true;
            }
        }
    }

    return false;
}