# InvertirOnline.com Coding Challenge

### Cambios
- Se separa las formas geometricas en clases.
- Estas clases heredan de FormaGeometrica.
- Se crea clase abstracta Cuadrilatero para que a partir de ella se herede todos los cuadrilateros (Cuadrado, Rectangulo, otros tipos de Trapecio).
- Se crea un Servicio de localizacion que modifica el Thread del actual CultureInfo para elegir el tipo de Idioma y los separadores de decimales ya que cada lenguaje es diferente. Si se quiere retener el separador de decimales como coma, entonces se puede cambiar el number format, separadores de decimales.
- Se crea un Servicio que provee informacion de las figuras geometricas.
- Se aplica una estrategia por cada informacion de las figuras geometricas (Plural, Singular) que devuelve el nombre de la figura en plural singular.
- Se crea tests adicionales de los servicios.

### A Mejorar
- Ya que se creo servicios, el componente que crea el reporte tiene dependencias con otros componentes, por cuestiones de tiempo y porque no esta dentro del scope, se utilizo las clases concretas, pero la idea es utilizar sus abstracciones (Interfaces) pero esto implica cumplir con Inyeccion De Dependencia por Inversion De Control y hay que instalar algun contenedor como Ninject y utilizar algun patron de diseño como ServiceLocator 


