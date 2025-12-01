# SolarSystem
## Enunciado
El objetivo es crear un sistema solar de tres cuerpos en Unity. Para esto se utilizará la plantilla universal 3D, añadiendo esferas para ajustar su tamaño, posición, órbita y velocidad.
  
Los requisitos son los siguientes:
- Cuerpos celestes a crear:

Nombre | Escala | Padre | Distancia del padre | Eje de rotación (del padre) | Velocidad de giro |
:---: | :---: | :---: | :---: | :---: | :---: |
Sol | (2,2,2) | - | 10m del punto (0,0,0) | Z | 30º/s |
Satélite1 | (1,1,1) | Sol | 5m | Y | 90º/s |
Satélite2 | (0.5,0.5,0.5) | Satélite1 | 2m | X | 45º/s |

- Los ejes Z siempre deben mirar hacia el padre, en caso del Sol hacia el punto (0,0,0).
- La cámara debe estar mirando al Sol.
- Solo se debe crear un script, "SolarSystem", que será un componente del Sol.
- Los componentes Transform de los elementos se referenciarán con variables públicas.
- Gizmos a crear:
	* Sol - Punto (0,0,0)
	* Sol - Satélite1
	* Sol - Satélite2
	* Satélite1 - Satélite2
- Los gizmos deben tener distinto color.
  
Opcional:  
- Si el ángulo entre el eje X del Satélite2 y el eje X global es menor que 90, el Satélite2 reducirá su tamaño, si no, lo aumentará.
- Se pueden añadir texturas a los cuerpos celestes, un skybox y utilizar el componente Trail Render para mejorar la estética.

