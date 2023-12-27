# ProcessText

1.	OBJETIVO DE LA PRUEBA

Evaluar el estilo de codificación, la calidad del código, el enfoque para la solución y la velocidad de codificación.

Lo que deseamos evaluar y encontrar en esta prueba de código es lo siguiente:

- La implementación debe compilar y funcionalmente debe cumplir con las especificaciones.
- Aplicación de los principios SOLID.
- Aplicación de uno o más patrones de diseño.
- Uso de inyección de dependencias.
- Escribir código legible.
- Escribir código testeable o probado.

2.	DESCRIPCIÓN 

Genera y envíanos en un archivo comprimido (ZIP) una o más soluciones de Visual Studio para procesar texto.

El resultado final debe ser una pantalla/formulario en la que el usuario introduzca un texto a ordenar y seleccione una opción de ordenación.

El texto de entrada puede ser cualquier texto (una frase, un párrafo de un libro, etc.) con palabras separadas por espacios. Por ejemplo: “Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam sed tincidunt nisi, non vulputate augue. Sed ornare sem id nisl consectetur sollicitudin. Nunc vehicula, augue a auctor varius, mauris metus fringilla dui, non egestas quam erat sed massa. Praesent pretium placerat elit, et venenatis ante interdum in. Nullam pretium libero magna, at viverra justo scelerisque non. Ut nec nunc non nisi posuere placerat vel sed velit. Sed eget rutrum lacus, sit amet maximus eros.”

3.	QUÉ DEBE ENTREGARSE
i.	Library/DLL

Se debe implementar una librería en C# utilizando el .NET Framework 4.8 que exponga 3 métodos:

Método 1: Obtener ORDER OPTIONS 
-	Sin parámetros de entrada.
-	Devuelve 3 opciones: AlphabeticAsc, AlphabeticDesc, LenghtAsc.

Método 2: Obtener ORDERED TEXT 
-	Con 2 parámetros de entrada: el texto y una opción de ordenamiento (TextToOrder and OrderOption).
-	Devuelve una lista de palabras ordenadas según la opción de ordenación recibida por parámetro. Los 3 tipos de ordenación deberán hacer lo siguiente: 
o	AlphabeticAsc: Ordenar por la primera letra de cada palabra con orden ascendente.
o	AlphabeticDesc: Ordenar por la primera letra de cada palabra con orden descendente.
o	LenghtAsc: Ordenar por longitud de cada palabra con orden ascendente.

Método 3: Obtener STATISTICS
-	Con 1 parámetro de entrada (TextToAnalyze).
-	Debe calcular 3 estadísticas del texto: cantidad de guiones, cantidad de palabras, cantidad de espacios en blanco. El resultado a devolver debe ser un objeto POCO complejo llamado TextStatistics, con los datos calculados.

ii.	WPF UI

Una ventana WPF con el patrón MVVM (sin utilizar librerías de terceros) que utilice los métodos definidos en el punto anterior mostrando los resultados en  .NET Framework 4.8.

Se valorará la usabilidad de la pantalla.

Recuerda que el código DEBE tener:

- Código legible y mantenible.
- Patrones de diseño.
- Principios SOLID.
- Utilización de un framework para la inyección de dependencias.
- Código testeable y probado.
- Debe compilar.
- Debe cumplir funcionalmente con las especificaciones.
- No utilizar librerías de terceros.
