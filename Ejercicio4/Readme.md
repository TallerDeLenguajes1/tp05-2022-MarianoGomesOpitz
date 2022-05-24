# Ejericio 4)

* ¿String es una tipo por valor o un tipo por referencia?

    String es un tipo por referencia, aunque posee similares características de los tipo por valor, 
    como el hecho de ser inmutable, es decir, si se le asigna un valor, éste no puede ser cambiado, 
    sino que el compilador debe crear un nuevo objeto string en la memoria y apuntar la variable 
    a la nueva ubicación de memoria.

* ¿Qué secuencias de escape tiene el tipo string?

    * \' -> Comillas simples
    * \" -> Comillas dobles
    * \\ -> Barra invertida
    * \0 -> Nulo
    * \a -> Alerta
    * \b -> Retroceso
    * \f -> Salto de página
    * \n -> Nueva linea
    * \r -> Salto de linea
    * \t -> Tabulador horizontal
    * \v -> Tabulador vertical
    * \u -> Secuencia de escape unicode (UTF-16)
    * \U -> Secuencia de escape unicode (UTF-32)
    * \x -> Secuencia de escape unicode similar a \u
    
* ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

    * @ impide el funcionamiento de las secuencias de escape, es decir, una secuencia de escape 
    ahora es tratada como texto. Por ejemplo:
    ````
    Console.WriteLine("Hola \n Mundo"); // Cadena sin @
    Console.WriteLine(@"Hola \n Mundo"); // Cadena con @
    ````

    * $ proporciona una mejor manera de insertar variables en una cadena de caracteres, utilizando {} 
    para agilizar la lectura y comprensión del código. Por ejemplo:
    ````
    >int var1 = 54, var2 = 30;
    >Console.WriteLine("var1: + var1 +, var2: + var2); // Las comillas y los signos de suma relentizan la lectura
    >Console.WriteLine("var1: {0}, var2: {1}", var1, var2); // Hay que saber cual es la variable que va en cada posición
    >Console.WriteLine($"var1: {var1}, var2: {var2}"); // Con$" se puede insertar las variables directamente en la cadena
    ````