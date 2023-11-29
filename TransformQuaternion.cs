using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformQuaternion : MonoBehaviour
{
    public bool translate;
    public bool rotate;

    void Start()
    {

    }

    void Update()
    {
        /*

        Ejercicio 1. Crea en Unity un proyecto 2D, crea este sprite, asígnale este script y explica la clase Transform.

            La clase transform es una que todo objeto de unity tiene es usada para manipular la posición, rotación y escala de un objeto.


        Ejercicio 2. Explica qué es traslación, rotación y escalado y por qué es tan importante en los videojuegos.

            -Traslación: Es el movimiento de un objeto en el espacio cambiando las coordenadas X, Y, Z.

            -Rotación: Es el cambio de la orientación y/o dirección alrededor de un punto específico en el espacio.

            -Escalado: Consiste en el cambio del tamaño de un objeto en el espacio, cambiando su ancho, alto y profundidad en los ejes x, y, z.

            Estos elementos combinados en los videojuegos ofrecen una variedad de herramientas para manipular objetos en espacios 2d y 3d, permitiendo modificar objetos creados en el espacio del juego.

        Ejercicio 3. Describe ángulos de Euler y el problema del bloqueo del cardán cuando se usan ángulos de Euler.

        Los ángulos Euler  son 3 ángulos creados por Leonhard Euler y describen la orientación de un cuerpo rígido con respecto a unas coordenadas fijas.
        Los ángulos más comunes de Euler son
            -Ángulo de cabeceo o Pitch: Se encarga de la rotación en el eje X.
            -Ángulo de alabeo o Yaw: Se encarga de la rotación en el eje Y.
            -Ángulo de balanceo o Roll: Se encarga de la rotación en el eje Z.


        Ejercicio 4. Define cuaternión y di todas las ventajas de usar cuaterniones para rotar en vez de ángulos de Euler.

        Cuaternión es un sistema numérico que extiende los números complejos.
        Las principales ventajas que tiene el uso de cuaternión son:

            -Evitar el bloqueo del cardán
            -Rotaciones más suaves y consistentes
            -Es más eficiente a la hora de realizar interpolaciones
            -Menos problemas de singularidad
            -Rendimiento optimizado


        Ejercicio 5. Di las diferencias entre Transform.position y Transform.Translate y translada de ambas maneras.

        La diferencia entre Transform,position y Transform.translate es que t.position se utiliza para la posición absoluta de un objeto en el mundo mientras que t.translate se usa para mover un objeto en relación a su posición actual.

        Ejercicio 6. Di las diferencias entre Transform.rotation y Transform.Rotate y rota de ambas maneras.

        [...]

        */

        Ejercicio5();
        Ejercicio6();
    }

    void Ejercicio5()
    {
        if (translate == true)
        {
            transform.Translate(Vector3.up * Time.deltaTime);
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        else
        {
            transform.position = transform.position + new Vector3(0, -Time.deltaTime, 0);
            transform.position = transform.position + new Vector3(-Time.deltaTime, 0, 0);

        }
        // Mueve el objeto 1 unidad/segundo hacia arriba (eje y).
        // transform.Translate(Vector3.up * Time.deltaTime);


        // Mueve el objeto 1 unidad/segundo hacia abajo (eje y).
        // transform.Translate(Vector3.down * Time.deltaTime);

        // Mueve el objeto 1 unidad/segundo hacia la izquierda (eje x).
        // transform.Translate(Vector3.left * Time.deltaTime);

        // Mueve el objeto 1 unidad/segundo hacia la derecha (eje x).
        // transform.Translate(Vector3.right * Time.deltaTime);



        // Mueve el objeto 1 unidad/segundo hacia arriba (eje y).
        //transform.position = transform.position + new Vector3(0, Time.deltaTime, 0);

        // Mueve el objeto 1 unidad/segundo hacia abajo (eje y).
        // transform.position = transform.position + new Vector3(0, -Time.deltaTime, 0);

        // Mueve el objeto 1 unidad/segundo hacia la izquierda (eje x).
        // transform.position = transform.position + new Vector3(-Time.deltaTime, 0, 0);

        // Mueve el objeto 1 unidad/segundo hacia la derecha (eje x).
        //transform.position = transform.position + new Vector3(Time.deltaTime, 0, 0);



    }

    void Ejercicio6()
    {
        if (rotate == true)
        {
            Quaternion currentRotation = transform.rotation;

            
            Quaternion deltaRotation = Quaternion.Euler(0.0f, 0.0f, 30.0f * Time.deltaTime);

           
            Quaternion newRotation = currentRotation * deltaRotation;

            
            transform.rotation = newRotation;
        }
        else
        {
            transform.Rotate(Vector3.up, -30.0f * Time.deltaTime);
        }
        // transform.Rotate(0.0f, 0.0f, 1.0f);

        // transform.rotation = [...]
    }

}
