# REST API Net Core GeometricFigures
Este repositorio contiene la API necesaria para hallar el area de un rectangulo y el area de un circulo.

# Arquitectura
Se crea arquitectura en capas con el fin de separar las responsabilidad de cada una de las capas de la aplicacion, con el fin de cambiar tecnologia de acceso a datos o de servicios web, sin afectar las reglas de negocio.

# URL Rectangulo y Circulo 
 * https://localhost:44376/api/Rectangle
 
 REQUEST
 
 {
    "basis":2,
    "height":"3"
 }
 
 * https://localhost:44376/api/Circle
 
 REQUEST
 
 {
    "radio": "2"
 }
