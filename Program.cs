Queue<int> fila = new Queue<int>();

fila.Enqueue(8);
fila.Enqueue(5);
fila.Enqueue(72);
fila.Enqueue(88);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(1);

foreach(int item in fila)
{
    Console.WriteLine(item);
}
