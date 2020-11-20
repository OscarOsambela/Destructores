using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

/*
Importante
Los destructores solo se usan en clase, no en enum ni structs
Los destructores solo pueden ser unicos en una clase
Los destrcutores no se heredan ni se sobrecargan
Los destructores no se llaman, son invocados automaticamente
Los destructores no tienen modificadores de acceso ni parametros 
*/
public class Program
{
  public static void Main()
  {
    ManejoArchivos arc = new ManejoArchivos();
		arc.mensaje();	
  }
	//1.creamos clase
  class ManejoArchivos{
		//2. instanciamos var tipo StreamReader
    StreamReader archivo = null;
    int contador = 0;
    string linea;

    //3. creamos constructor
    public ManejoArchivos(){
			//lee el archivo y colocar la ruta donde se encuentre
      archivo = new StreamReader(@"texto.txt");
      while((linea = archivo.ReadLine()) !=null){
        Console.WriteLine(linea);
        contador++;
      }
    } 
		//4. metodo para contar lineas del texto del archivo para el ejemplo
    public void mensaje(){
      Console.WriteLine("hay {0} líneas", contador);
    }
		//creamos del destructor
		~ManejoArchivos(){
			archivo.Close();
		}
  }
}
