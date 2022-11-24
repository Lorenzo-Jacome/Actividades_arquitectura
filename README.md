# Actividades Finales para Diseño y Arquitectura de Software
## Creado por: Lorenzo Jácome
### Entregable 1 - Adaptador de JSON a XML
Dentro del folder "Entregable_1" podrá encontrar la primer activiad que nos fue asignada. Esta consiste en una API que cuenta con un endpoint POST que recibe la información basica de un estudiante en formato JSON y la transforma en XML. Para corroborar que el funcionamiento es el correcto, la API regresa la misma información pero ahora en formato XML
* Dentro del proyecto encontrará el folder "Adapters" que cuenta con nuestro adaptador que convierte de JSON a XML.
* Models cuenta con el modelo de una persona. Este se utiliza para recibir la información del POST y guardarla en un objeto.
* Controllers guarda el controlador de nuestro end point. 
### Comportamiento de los diferentes patrones
* Singleton
  * El singleton, como su nombre le hace alusión, es asegurarse de que solo exista una instancia de una clase u objeto. Esto tiene diferentes objetivos como lo son:
  * Controlar el acceso de un recurso commpartido por varias instancias del programa.
  * Este punto va de la mando con el anterior y es ofrecer un punto de acceso globar para un recurso. Similar a cualquier variable golbal, este objeto puede ser accesado desde cualquier parte del programa.
* Factory
  * En su definición estricta, el patrón de Factory ofrece una interfaz para crear objetos desde una superclase PERO le permite a subclases alterar el tipo de objetos que se va a crear. En palabras mucho más simples, se tiene un "template" para la generación de un objeto general del cual se pueden crear distintas instancias que tengas sus caracteristicas especificas. 
* Builder
  * En esencia, este tipo de patrón nos permite generar distintas instancias de un objeto pero con distintas representaciones y tipos PERO con la ventaja de que se utiliza el mismo código "constructor". 
  * Aunque en primera instancia no se pueda ver una aplicación para este patrón, su objetivo es facilitar la creación de objetos complejos que, de lo contrario, usualmente contienen constructores con un sin fin de parametros y un sin fin de objetos anidados al mismo. 
* Prototype
  * La función de este tipo de patrón es muy simple de entender, contrario al par de ejemplos anteriores.
  * Ese patrón busca que dentro de tu programa se puedan generar copias de objetos existentes sin la necesidad de hacer estos mismos dependientes de sus clases.
  * Esto sirve para crear una copia exacta de un objeto previamente instanciado pero con la ventaja de que puedes hacer los cambios requeridos de la copia sin alterar la clase de la que proviene. 
  * En primera instancia no se le encuentra mucho uso a ese patrón hasta que empiezas a meter a la ecuasión clases privadas o seguras. 
* Adapter
  * Como su nombre lo indica, el objetivo de ese patrón es permitir el intercambio de datos e información entre dos o más instancias que no contengan interfaces compatibles.
  * De cierta manera se puede considerar una especia de modulo traductor, que al llamarlo, adapata dos interfaces para que puedan compartir información entre ellas. 
