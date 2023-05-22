// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a; 
int b;
a = 10;
b = a;

Console.WriteLine("Valor de a: "+a);
Console.WriteLine($"Valor de b: {b}");
*/

// Punto 1

int numero, numeroInvertido;
string? input, devolverString; //?: acepta un null
char[] cadena, temp;
bool parseoBool;
int n;
		
Console.WriteLine("Ingrese un numero: ");
input = Console.ReadLine();
Console.Clear();
		
parseoBool = int.TryParse(input, out numero);
		
if(numero > 0){
	cadena = numero.ToString().ToCharArray(); // Convierto numero ingresado (int) en string para convertirlo en un arreglo de tipo char[].

    // cadena = input.ToCharArray();

	n = cadena.Length;
	temp = new char[n];

	for(int i = 0; i < n; i++){
		temp[i] = cadena[n - 1 - i]; // revierto el array de char[]
    }

    parseoBool = int.TryParse(new string(temp), out numeroInvertido);

    // parseoBool = int.TryParse(string.Join("",temp), out numeroInvertido);

    /* Escribe en consola el numero invertido en tipo string.
    devolverString = new string(temp);
    Console.WriteLine($"El numero invertido es: {devolverString}");
    */

    Console.WriteLine($"El numero invertido es: {numeroInvertido}"); //$ indica una variable (interpolación)

}