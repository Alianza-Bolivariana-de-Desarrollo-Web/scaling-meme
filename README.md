# scaling-meme

scaling-meme es un proyecto en C# para calcular la diferencia entre 2 fechas.

## Instalación

Solo es necesario instalar una librería en Visual Studio Community e importarla para hacer uso de `DateDiff`.
```csharp
using Itenso.TimePeriod;
```

## Uso

```csharp
//Valida el formato de entrada tipo string.
bool esValida = SCFunciones.ValidarFecha("01/01/1990", "es"); //Devuelve true.

//Calcula la diferencia entre una fecha A.C. y una fecha D.C.
DateTime fechaAC = new DateTime(1000, 01, 01);
DateTime fechaDC = new DateTime(1000, 01, 01);
int[] diferencia = SCFunciones.DiferenciaFechaAC(fechaAC, fechaDC); //Años = pos. 0, Días = pos. 1.

//Calcula la diferencia entre dos fechas.
DateTime primeraFecha = new DateTime(1000, 01, 01);
DateTime segundaFecha = new DateTime(1000, 01, 01);
int[] diferencia = MMFunciones.CalcularDiferencia(primeraFecha, segundaFecha); //Años = pos. 0, Días = pos. 1.

```

## Licencia
[MIT](https://choosealicense.com/licenses/mit/)
