// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("Hola me das tu año de nacimiento?");
Console.ReadLine(); 
// (Es para ingresar algo)
string loqueeltipopuso = Console.ReadLine();
int elañodeltipo = int.Parse(loqueeltipopuso);
int laedaddelflaco = 2023 - elañodeltipo;
// en vez de 2023 si quiero que se actualice solo debo poner
int elañodondeestoyahora = DateTime.Today.Year 
    int laedaddelflaco = elañodondeestoyahora - laedaddelflaco;
Console.WriteLine("deberia cumplir" + laedaddelflaco);
*/

/* 
Loqueingresemos = Console.WriteLine("hola,me das alguna cadena");
Loqueingresemos = Console.ReadLine();
if (Loqueingresemos.lenght > 15);

    console.writeline("mucho texto");
else
    Console.WriteLine("bien, tiene poco!!");
*/

/* calcullar las ventas del ultimo año.....
Console.WriteLine("Hola, te voy a peidr los valores de los 12 meses");
for (int mes = 1; mes <= 12; mes++)
    Console.WriteLine("poneme el valor del mes" + mes);
// me abro una variable para poder poner los montos del mes 
int suma = 0;

string valor = Console.ReadLine();
// como lo quiero sumar tengo que pedirle un numero
suma = suma + int.Parse(valor);

Console.WriteLine(suma);
*/

/*
//ejemplo de while pidiendo valores hasta poner un 0
Console.WriteLine("pone todas las ventas, y cuando no tengas mas, poneme un 0");
string valor = Console.ReadLine();
int valorpasadoaint = int.Parse(valor);
int sumita = 0;
while (valorpasadoaint > 0)
{
    sumita = sumita + valorpasadoaint;
    Console.WriteLine("ingresar valor");
    valor = Console.ReadLine();
    valorpasadoaint = int.Parse(valor);
}
Console.WriteLine("al final de todo vendiste" + sumita);
*/


//un alumno ingresa las notas de las 9 materias del año, mostrar el promedio de las mismas.

Console.WriteLine("Te voy a pedir las notas de tus 9 materias:");
int suma = 0;
int promedio = 0;

for (int nota = 1; nota <= 9; nota++)
{
    Console.WriteLine("poneme todas tus notas" + nota);
    string valor = Console.ReadLine();
    suma = suma + int.Parse(valor);
    promedio = suma / 9;
}

Console.WriteLine("tu promedio es" + promedio);





