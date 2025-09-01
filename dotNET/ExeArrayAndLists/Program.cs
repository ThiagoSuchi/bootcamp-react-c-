// Arrays
int[] arrayInt = [40, 30, 20, 10, 5];

int[] arrayDobrado = new int[arrayInt.Length];
Array.Copy(arrayInt, arrayDobrado, arrayInt.Length);

foreach (int valor in arrayDobrado)
{
    Console.WriteLine(valor);
}

for (int c = 0; c < arrayInt.Length; c++)
{
    Console.WriteLine($"Posição N {c} - " + arrayInt[c]);
}

foreach (int valor in arrayInt)
{
    Console.WriteLine(valor);
}

// Listas
List<string> listString = ["Opa", "Bão", "Jóia"];

for (int c = 0; c < listString.Count; c++)
{
    Console.WriteLine($"Posição N {c} - " + listString[c]);
}

foreach (string item in listString)
{
    Console.WriteLine(item);
}