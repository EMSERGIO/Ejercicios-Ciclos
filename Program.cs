using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar
            //  ningún pedido de datos.
           
            // for (int num = 1; num <= 10; num++)
            // {
                // Console.WriteLine(num);
            // }

            //............................................................................

            // 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor
            //  de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
               
            // int num1, max = 0;

            
            // for(int x = 0; x < 10; x++)
            // {   
                // Console.WriteLine("Ingrese un numero");
                // num1 = int.Parse(Console.ReadLine());

                // if (x == 0){
                    // max = num1;
                // }else if(num1 > max){
                    // max = num1;
                // }  

            // }
            
            // Console.WriteLine("El num mayor es:" + max);

            
            //............................................................................

            // 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de
            // aquellas personas mayores a 18 años.

            // int edad = 0, promedio, acumu = 0, contador = 0;

            // for (int x = 0; x < 20; x++)
            // {
                // Console.WriteLine("Ingrese la edad:");
                // edad = int.Parse(Console.ReadLine());

                // if (edad >= 18){
                    // acumu += edad;
                    // contador++;
                // }
                    
            // }
            // promedio = acumu / contador;
            // Console.WriteLine("El promedio de las personas con 18 años es:" + promedio);
      
      
            //............................................................................

            
            // 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel
            //  aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

            // int n, con = 0;

            // Console.WriteLine("Ingrese un numero:");
            // n = int.Parse(Console.ReadLine());

            // for (int x = 1; x <= n; x++)
            // {             
                // if(n % x == 0){
                    // con++;
                // }     
            // }
            // if(con == 2){
                // Console.WriteLine("El numero es primo.");              
            // }else{
                // Console.WriteLine("El numero NO es primo.");       
            // }

            
      
      
            

            // .........................................................
            // SULUCION PARA ENCONTRAR UN NUMERO PRIMO SACADA DE ChatGPT
            // .........................................................
            // Console.Write("Ingrese un número entero: ");
            // int numero = Convert.ToInt32(Console.ReadLine());
        
            // if (numero > 1)
            // {
                //  bool esPrimo = true;
                // for (int i = 2; i < numero; i++)
                // {
                        // if (numero % i == 0)
                        // {
                            // esPrimo = false;
                            // break;
                        // }
                // }
                // if (esPrimo)
                // {
                    // Console.WriteLine("El número {0} es primo.", numero);
                // }
                //  else
                // {
                    // Console.WriteLine("El número {0} no es primo.", numero);
                // }
            // }
            // else
            // {
                //  Console.WriteLine("El número debe ser mayor que 1.");
            // }
            // ................................................................
            // ................................................................
            
            
            // .........................................................................................................

            // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo
            //  de los números pares y el mínimo de los números impares.

            
            // int n, max = 0, min = 0;
            // int conPar = 0, conImpar = 0;

            // for (int x = 0; x < 6; x++)
            // {
                // Console.WriteLine("Ingrese un numero");
                // n = int.Parse(Console.ReadLine());
                // if (n % 2 == 0){
                    // //trabajamos con los pares.
                    // conPar++;
                    // if (conPar == 1){
                        // max = n;
                    // }else if(n > max){
                        // max = n;
                    // }
                // }else{
                    // //trabajamos con los impares
                    // conImpar++;
                    // if (conImpar == 1){
                        // min = n;
                    // }else if(n < min){
                        // min = n;
                    // }
                // }
            
            // }
            // Console.WriteLine("El maximo de pares es:" + max);
            // Console.WriteLine("El minimo de impares es:" + min);
        }

    }
}
