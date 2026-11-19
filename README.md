# Examen práctico: Sistema de alquiler de vehículos «RentaCar Express»

**Estudiante:** Johan Alexander  
**Matrícula:** ____________________  
**Asignatura:** Programación Básica  
**Nombre del proyecto:** Examen_RentaCar_JohanAlexander

## 1. Descripción del programa

RentaCar Express es una aplicación de escritorio desarrollada en C# con Windows Forms. Su finalidad es registrar los alquileres de vehículos de los clientes y calcular el importe que deben pagar, tomando en cuenta los días de alquiler, el tipo de seguro, el servicio de GPS, el descuento para clientes corporativos, la entrega a domicilio y el impuesto correspondiente.

## 2. Datos de entrada

Para utilizar el programa se deben introducir o seleccionar los siguientes datos:

- Nombre del cliente.
- Fecha de salida del vehículo.
- Indicación de si el cliente es corporativo.
- Nombre del vehículo.
- Tarifa de alquiler por día.
- Cantidad de días de alquiler, desde 1 hasta 30.
- Tipo de seguro: básico o completo.
- Indicación de si el vehículo incluirá GPS.
- Modalidad de entrega: en la sucursal o a domicilio.

## 3. Proceso realizado por el programa

1. Se comprueba que el nombre del cliente y el nombre del vehículo no estén vacíos.
2. Se verifica que la tarifa diaria sea un número válido y mayor que cero.
3. Si el cliente selecciona el seguro completo, se agregan RD$300 a la tarifa diaria.
4. Si selecciona el servicio de GPS, se agregan RD$100 a la tarifa diaria.
5. La tarifa diaria ajustada se multiplica por la cantidad de días para obtener el importe de cada vehículo.
6. Los importes de los vehículos se suman para calcular el subtotal del alquiler.
7. Si el cliente es corporativo, se aplica un descuento del 15 % sobre el subtotal.
8. Si se selecciona la entrega a domicilio, se agregan RD$500 una sola vez por alquiler.
9. Se calcula el ITBIS del 18 % sobre la base imponible.
10. Finalmente, se suma la base imponible y el ITBIS para obtener el total a pagar.

## 4. Datos de salida

Al utilizar la aplicación se muestran los siguientes resultados:

- Listado de vehículos agregados, con sus días de alquiler, descripción, tarifa diaria y total de cada línea.
- Subtotal.
- Descuento aplicado.
- Cargo por entrega a domicilio.
- ITBIS del 18 %.
- Total general que debe pagar el cliente.

## 5. Caso de prueba indicado en el examen

**Cliente:** Carlos Méndez  
**Condición:** Cliente corporativo  
**Entrega:** A domicilio

| Vehículo | Operación | Importe |
|---|---:|---:|
| Sedán, seguro completo | (RD$2,200 + RD$300) × 3 días | RD$7,500.00 |
| Jeepeta, con GPS | (RD$3,500 + RD$100) × 2 días | RD$7,200.00 |
| **Subtotal** | | **RD$14,700.00** |
| Descuento corporativo (15 %) | RD$14,700 × 0.15 | RD$2,205.00 |
| Entrega a domicilio | Cargo único | RD$500.00 |
| Base imponible | RD$14,700 - RD$2,205 + RD$500 | RD$12,995.00 |
| ITBIS (18 %) | RD$12,995 × 0.18 | RD$2,339.10 |
| **TOTAL A PAGAR** | | **RD$15,334.10** |

## 6. Capturas de pantalla del programa

Después de ejecutar la aplicación, inserte las capturas que demuestren su funcionamiento:

1. **Pantalla principal:** formulario con los datos del cliente y las opciones del alquiler.
2. **Vehículos registrados:** listado con los dos vehículos del caso de prueba.
3. **Cálculo final:** subtotal, descuento, cargo por domicilio, ITBIS y total a pagar.

## 7. Instrucciones para abrir y ejecutar el proyecto

1. Extraiga el contenido del archivo comprimido.
2. Abra el archivo `Examen_RentaCar_JohanAlexander.sln` en Visual Studio 2022.
3. Compruebe que esté instalada la carga de trabajo **Desarrollo de escritorio de .NET** y que el equipo tenga el SDK de .NET 8.
4. Espere a que Visual Studio cargue el proyecto.
5. Presione **F5** para iniciar la aplicación.

## 8. Enlace del repositorio

Cuando el proyecto esté publicado en GitHub, escriba aquí el enlace correspondiente:

**Enlace del repositorio:** ______________________________________________
