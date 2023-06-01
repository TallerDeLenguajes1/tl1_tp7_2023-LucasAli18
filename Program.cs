using EspacioCalculadora;
Console.WriteLine("Hello, World!");

Calculadora cal = new Calculadora();

double valor=0;
int opcion;

    Console.WriteLine("Menu Principal");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Limpiar");
    Console.WriteLine("6. Salir");
    Console.WriteLine("Ingrese la opcion: ");

    int.TryParse(Console.ReadLine(), out opcion);

while(opcion!=0){
        Console.WriteLine();
        Console.WriteLine("Ingrese el valor con el que desea trabajar: ");
        double.TryParse(Console.ReadLine(),out valor);
        switch(opcion){
            case 1: 
                cal.Suma(valor);
                Console.WriteLine(cal.Resultado);
                break;    
            case 2: 
                cal.Resta(valor);
                Console.WriteLine(cal.Resultado);
                break;
            case 3: 
                cal.Multiplicar(valor);
                Console.WriteLine(cal.Resultado);
                break;
            case 4: 
                cal.Dividir(valor);
                Console.WriteLine(cal.Resultado);
                break;    
            case 5: 
                cal.Limpiar();
                Console.WriteLine(cal.Resultado);
                break;    
            case 6: 
                break;    
        }
        Console.WriteLine("Menu Principal");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Limpiar");
        Console.WriteLine("6. Salir");
        Console.WriteLine("Ingrese la opcion: ");

        int.TryParse(Console.ReadLine(), out opcion);
}