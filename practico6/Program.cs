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
// ===================================================================================================
/*
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

    //Escribe en consola el numero invertido en tipo string.
    // devolverString = new string(temp);
    //  Console.WriteLine($"El numero invertido es: {devolverString}");
    

    Console.WriteLine($"El numero invertido es: {numeroInvertido}"); //$ indica una variable (interpolación)

}
*/
// ===================================================================================================
// Punto 3
// ===================================================================================================

string? input, siNoStr;
bool parseoBool;
int siNo;
float a, b,division;


do{
    Console.WriteLine("Ingrese la operacion: ");
    Console.WriteLine("1 - SUMAR");
    Console.WriteLine("2 - RESTAR");
    Console.WriteLine("3 - MULTIPLICAR");
    Console.WriteLine("4 - DIVIDIR");
    Console.WriteLine("5 - VALOR ABSOLUTO");
    Console.WriteLine("6 - CUADRADO");
    Console.WriteLine("7 - RAIZ CUADRADA");
    Console.WriteLine("8 - SENO");
    Console.WriteLine("9 - COSENO");
    Console.WriteLine("10 - ENTERO DE UN FLOAT");
    input = Console.ReadLine();
    parseoBool = int.TryParse(input, out int operacion);
    if(operacion>=1 && operacion<6){
    Console.WriteLine("Ingrese dos numeros: ");
    parseoBool = float.TryParse(Console.ReadLine(), out  a);
    parseoBool = float.TryParse(Console.ReadLine(), out  b);

    switch(operacion){
        case 1:
            Console.WriteLine($"La suma del numero {a} y {b} es: {a + b}");
            break;
        case 2:
            Console.WriteLine($"La resta del numero {a} y {b} es: {a - b}");
            break;
        case 3:
            Console.WriteLine($"La multiplicación del numero {a} y {b} es: {a * b}");
            break;
        case 4:
            division =  a / b;
            Console.WriteLine($"La división del numero {a} y {b} es: {division.ToString("N2")}");
            break;
        default:
            Console.WriteLine("El numero ingresado no corresponde a ninguna operación");
            break;
    }

    } else {
        if(11>operacion && operacion>=6){
         Console.WriteLine("Ingrese un numero: ");
         parseoBool = float.TryParse(Console.ReadLine(), out  a);

        switch(operacion){
            case 5:
                 Console.WriteLine($"El valor absoluto de {a} es: {Math.Abs(a)}");
                 break;
            case 6:
                 Console.WriteLine($"El cuadrado de {a} es: {Math.Pow(a, 2)}");
                 break;
            case 7:
                if(a < 0) {
                  Console.WriteLine("No se puede calcular");
                  break;
            }

                 Console.WriteLine($"La raiz cuadrada de {a} es: {Math.Sqrt(a)}");
                 break;
            case 8:
                decimal seno = (decimal) Math.Sin(a);
                Console.WriteLine($"El seno de {a} es: {seno}");
                break;
            case 9:
                decimal coseno = (decimal) Math.Cos(a);
                Console.WriteLine($"El coseno de {a} es: {coseno}");
                break;
            case 10:
                Console.WriteLine($"El entero de {a} es: {(int) a}");
                break;
            default:
                Console.WriteLine("El numero ingresado no corresponde a ninguna operación");
                break;
    }

   }
}


    Console.WriteLine("Quiere seguir operando: SI[1] - NO[0]");
    siNoStr = Console.ReadLine();
    parseoBool = int.TryParse(siNoStr, out siNo);
    Console.Clear();
    
}while(siNo == 1);


Console.WriteLine("Ingrese dos numeros: ");
parseoBool = float.TryParse(Console.ReadLine(), out  float x);
parseoBool = float.TryParse(Console.ReadLine(), out  float y);

if(x == y) Console.WriteLine("Los numeros son iguales");

if(x > y){
    Console.WriteLine($"El valor máximo es: {x}");
    Console.WriteLine($"El valor mínimo es: {y}");
}else{
    Console.WriteLine($"El valor máximo es: {y}");
    Console.WriteLine($"El valor mínimo es: {x}");
}












