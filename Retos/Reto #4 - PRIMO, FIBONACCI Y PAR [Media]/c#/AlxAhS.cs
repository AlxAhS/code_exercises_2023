using System;

int x;
string valPar = "", valPrim = "", valFib = "";

Console.Write("Se evaluar� si el n�mero ingresado es: \n-Par \n-N�mero primo \n-Fibonacci");
Console.Write("\nIngrese un n�mero: ");
x = Convert.ToInt32(Console.ReadLine());

Par();
Primo();
Fibonacci();

Console.WriteLine("\n{0}: {1}, {2} y {3}\n", x, valPar, valPrim, valFib);


//Evaluar si el n�mero es par
string Par()
{
	if (x % 2 == 0)
	{ valPar = "par"; }
	else
	{ valPar = "impar"; }
	return valPar;
}

//Evaluar si el n�mero es primo
string Primo()
{
	int numDivisores = 0;
	for (int y = 1; y <= x; y++)
	{
		if (x % y == 0)
		{
			numDivisores += 1;
		}
		if (numDivisores <= 2)
		{
			valPrim = "primo";
		}
		else
		{
			valPrim = "no es primo";
		}
	}

	return valPrim;
}

//Evaluar si el n�mero es de la serie fibonacci
string Fibonacci()
{
	List<int> Fibonacci = new List<int>();
	Fibonacci.Add(0);
	bool buscarFibonacci;

	int a = 0, b = 1, c = 0;
	for (int i = c; i <= x; i = c)
	{
		c = a + b;
		a = b;
		b = c;
		Fibonacci.Add(c);
	}

	buscarFibonacci = Fibonacci.Contains(x);

	if (buscarFibonacci)
	{ valFib = "pertenece a la serie Fibonacci"; }
	else
	{ valFib = "no pertenece a la serie Fibonacci"; }
	return valFib;
}