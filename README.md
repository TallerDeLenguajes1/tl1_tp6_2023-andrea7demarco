# tl1_tp6_2023-andrea7demarco
(**¿String es una tipo por valor o un tipo por referencia?**)

Puede conseguir este objetivo utilizando el tipo de referencia incorporado String del espacio de nombres System, que también está disponible mediante la palabra clave la palabra clave string. El tipo string es una secuencia de caracteres Unicode.

(**¿Qué secuencias de escape tiene el tipo string?**)

Si un string contiene comillas dobles, debes usar el carácter de barra invertida \ para escapar de ellas. Por ejemplo: string message = "\"C# is awesome\".
Las secuencias de escape sencillas (como "\\", que es una barra diagonal inversa), las secuencias de escape hexadecimales (como "\x0041", que es una A mayúscula) y las secuencias de escape Unicode (como "\u0041" que es una A mayúscula) se interpretan literalmente. Solo las secuencias de escape de comillas ("") no se interpretan literalmente, sino que generan comillas dobles. De igual modo, en el caso de una cadena interpolada literal, las secuencias de escape de llave ({{ y }}) no se interpretan literalmente, sino que generan caracteres de llave simple. En el siguiente ejemplo se definen dos rutas de archivo idénticas, una mediante un literal de cadena normal y otra mediante el uso de un literal de cadena textual. Este es uno de los usos más comunes de los literales de cadena textual.

(**¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?**)

- @ Para indicar que un literal de cadena se debe interpretar literalmente. El carácter @ de esta instancia define un literal de cadena textual.
- $ se utiliza para indicar una cadena de texto formateada, también conocida como plantilla de cadena. Esto permite incrustar expresiones o variables dentro de una cadena de texto de manera más sencilla y legible utilizando la sintaxis "${expresion}".
