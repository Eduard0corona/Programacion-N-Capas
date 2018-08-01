# Programacion-N-Capas
Estructura de un proyecto en N Capas.

La primer capa es llamada Core, en esta capa tenemos los modelos, las interfaces, los enumeradores, 
lo más básico de nuestros proyecto, únicamente clases que indican como se deben de comportar los componentes del negocio y la capa de datos, todo ello a traves de interfaces.

La capa de componentes es aquella donde nosotros declaramos todas las reglas del negocio, en este ejemplo tenemos un componente llamado
"Personas" el cual podrá agregar Personas con diferentes comportamientos pero que comparten las mismas propiedades, por ejemplo.

Puede ser un médico, informático, plomero, carpintero, todos ellos son Personas y comparten propiedades en común como el Nombre, Apellido, Sexo, pero sus Actividades o comportamientos son distintos. 

La capa de datos es la encargada únicamente de comunicarse con los almacenes de datos, para Guardar, Actualizar, Eliminar o Búscar información, los almacenes de datos pueden ser SQL Server, MySQL, PostgreSQL, entre otros. En este proyecto estamos utilizando el ORM llamado Entity Framework y la configuración de las relaciones la estamos haciendo mediante Fluent API.

La capa de servicios es el punto de entrada y de salida de la información de nuestra aplicación, las partes interesadas a traves de URL's tendrán acceso a todo aquello que nosotros expongamos en los controladores y siempre recibirán una respuesta del resultado de la operación, generalmente esta respuesta viene en un formato llamado JSON, los controladores a su vez tienen comunicación con la capa de negocio, la cual será implementada mediante Inyección de Dependencias utilizando un producto de terceros llamado "SimpleInjector". 


