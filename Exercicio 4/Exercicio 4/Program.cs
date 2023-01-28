//Crie um overload de métodos para comparar se string, int e double são iguais.

//Agora faça o mesmo que acima criando um método capaz de comparar qualquer objeto utilizando generics


var a = "palavra";
var b = "teste";
Console.WriteLine(CompararString(a, b));
var c = 2;
var d = 3;
Console.WriteLine(CompararGenericos(c, d));



bool CompararString(string a, string b)
{
    return a == b;
}
bool CompararInteiro(int a, int b)
{
    return a == b;
}
bool CompararDouble(double a, double b)
{
    return a == b;
}
bool CompararGenericEquitable<T>(T a, T b)
{
    return EqualityComparer<T>.Default.Equals(a, b);
}

bool CompararGenericos<T>(T a, T b) => a.Equals(b);

