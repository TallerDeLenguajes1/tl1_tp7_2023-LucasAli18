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

while(opcion!=6){
        Console.WriteLine();
        switch(opcion){
            case 1:
                Console.WriteLine("Ingrese el valor que desea sumar: ");
                double.TryParse(Console.ReadLine(),out valor); 
                cal.Suma(valor);
                break;    
            case 2: 
                Console.WriteLine("Ingrese el valor que desea restar: ");
                double.TryParse(Console.ReadLine(),out valor); 
                cal.Resta(valor);
                break;
            case 3: 
                Console.WriteLine("Ingrese el valor que desea multiplicar: ");
                double.TryParse(Console.ReadLine(),out valor); 
                cal.Multiplicar(valor);
                break;
            case 4: 
                Console.WriteLine("Ingrese el valor que desea dividir: ");
                double.TryParse(Console.ReadLine(),out valor); 
                cal.Dividir(valor);
                break;    
            case 5: 
                cal.Limpiar();
                break;    
            case 6: 
                break;    
        }
        Console.WriteLine(cal.Resultado);
        Console.WriteLine();
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