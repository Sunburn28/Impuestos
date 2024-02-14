string art;
double resultado;
int valor;
string a;
double subt;

Console.WriteLine("¿Qué artículo vas a comprar?");
art = Console.ReadLine();
Console.WriteLine("¿Cuántas unidades llevarás?");
int produ = int.Parse(Console.ReadLine());
Console.WriteLine("¿Cuánto vale el producto?");
valor = int.Parse(Console.ReadLine());
Console.WriteLine("¿Es un medicamento? (si/no)");
a = Console.ReadLine();

if (a.ToLower() == "si")
{
    subt = valor * produ;
    resultado = subt;
    Console.WriteLine("El total de tus productos es de: " + resultado);
}
else
{
    subt = valor * produ;
    resultado = subt * 1.16;
    Console.WriteLine("El total de tus productos es de: " + resultado);
}