SCUT
====

Sistema de control de unidades de transportes - TEC

Estudiantes
====

Salas Aguilar Jean Carlos

Pacheco Corella Isaac

Barrantes Rodríguez Pedro

Jiménez Segura Ronald


Introducción
====


Este es un proyecto del curso de Bases de Datos I, en donde se nos propone realizar una base de datos para alguna empresa escogida por el grupo de trabajo, que en esta ocasión está formada por 4 miembros, Jean Carlos, Pedro, Isaac y Ronald.

Para saber un poco de que es una base de datos, según (Date C, 2001, p.2) “Un sistema de bases de datos es básicamente un sistema computarizado para llevar registros. Es posible considerar a la propia base de datos como una especie de armario electrónico para archivar; es decir, es un depósito o contenedor de una colección de archivos de datos computarizados. ”

Se escoge El Departamento de Transporte del Instituto Tecnológico de Costa Rica(TEC) sede Santa Clara, ya que este departamento no contaba con una Base de datos propia para el manejo de su información, en su lugar manejan la información, con un sistema de hojas de Excel. Por esta razón se propuso la creación de una base de datos la cual facilita el manejo de la información que se desea almacenar para llevar un mejor orden de los datos.

Este proyecto se debe realizar en el lenguaje de alto nivel llamado SQL (Structured Query Language) que a su vez es un lenguaje de manipulación de datos (LMD) y también lenguaje de definición de datos (LDD), este se conectara con un entorno de desarrollo integrado (IDE) con el nombre de Microsoft Visual Studio 2012 el cual consta de diversos lenguajes de alto nivel para desarrollar el entorno visual para el usuario final, en este  caso se utilizará C#.

El objetivo de este proyecto es el de familiarizarnos con el manejo y creación de las bases de datos, ya  que en la actualidad laboral se manipula la información o datos a través de estos sistemas computarizados.



Descripción del problema
====

Se procede en la recolección de la información o datos, que el Departamento de Transporte ocupa guardar o manipular, de esta manera se podrá estructurar la información y procesos  más relevantes para la distribución del modelo relacional. Esta fase es, sino la más importante de la creación de la BD(Base de Datos) ya que el usuario nos definirá la estructura que debe tener. En este proceso en ocasiones se puede presentar conflictos en la comprensión de la información que requiere la BD según el usuario, por el nivel de abstracción que se necesita para guardar o manipular datos que el encargado requiera, en pocas palabras algunas veces se puede interpretar de forma errónea lo requerido por el solicitante de la base de datos.

A continuación se explicara un poco sobre la BD en la que vamos a trabajar:

•  Primeramente se crea  una entidad llamada Usuario en la que se va registrar toda la información personal de los choferes y funcionarios que estén asociados al departamento de transporte.

•	Existe una tabla Teléfonos que almacena la información telefónica correspondiente a cada usuario. 

•	Tipo de licencia, aquí se guarda los distintos tipos de licencia ligados a cada chofer.

•	Viáticos, esta tabla posee el gasto y descripción de los viáticos de cada chofer asociados a una fecha.

•	La tabla de centro costo, almacena la información de los diferentes departamentos a los que se les cobrará los gastos correspondientes de las giras que ellos solicitan.

•	Horas extra, tiene los datos de las horas extra de cada chofer.

•	Garantía, corresponde a los datos de vencimiento de la garantía de cada vehículo.

•	Agencia, entidad que obtiene toda la información acerca de las agencias donde se compran los autos.

•	Gasto de combustible, está asociado a un vehículo y fecha determinada, estos gastos se realizan.
•	Solicitud de ficha de salida, se puede decir que es la entidad principal porque es la que está enlazada a más entidades, y esta es la que obtiene la información de cada gira o viaje que se realiza.

•	La tabla talleres posee la información de todos los talleres en donde se pueden llevar a cabo un mantenimiento o reparación de la flotilla vehicular.

•	Mantenimiento, tabla que almacena los datos de las reparaciones o mantenimientos de los vehículos, por ejemplo el precio del arreglo.


Especificación de componentes
	

Primeramente antes de empezar el proyecto, se tuvo que ir a consultar al jefe de transporte Erick Palacio, que es el que se encarga de manejar todos los datos que vamos a utilizar en la BD.

Seguidamente como parte del proyecto 1 del curso, se procedió a realizar el diagrama de Entidad-Relación, el cual en las primeras revisiones se tuvo unos cuantos problemas, esto sucede por mala interpretación de lo quería el encargado de transporte. Finalizado este proceso avanzamos al siguiente paso que es la creación del diagrama Relacional, en el cual se puede ver de mejor manera la relación entre las diferentes tablas, para así mostrarle a nuestro cliente, con mayor claridad la estructura de la base de datos hasta ese punto, así se pudo corregir algunos errores heredados del diagrama anterior (Entidad-Relación).

Proseguimos con la normalización del diagrama relacional lo cual nos dio como resultados la aparición de nuevas entidades, como fue el caso de teléfonos y Tipo de licencias las cuales se relacionan con la entidad de usuario. 
