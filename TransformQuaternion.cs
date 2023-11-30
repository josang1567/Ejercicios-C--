using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class TransformQuaternion : MonoBehaviour
{
    [SerializeField]
    [Header("Activar ejercicios")]
    public bool e5, e6, e7, e8,e9;


    [Header("Activar Ejercicios")]

    public bool translate;
    public bool rotate;
    public bool LookRotation;
    public int ejercicio9Quarter;

    [Header("comun")]
    public Transform target1;
    public Transform target2;

    void Start()
    {
        if (e7 == true)
        {
            Ejercicio7();
        }

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

        La diferencia principal entre rotation y rotate es que rotation usa la rotación absoluta del objeto en el espacio tridimensional usando cuaterniones mientras que rotate hace uso de la rotación relativa del objeto haciendo giros en el eje local o global del objeto.

        Ejercicio 7. Di el funcionamiento de Transform.localScale y escala un sprite a 0.25, 0.5 y 0.75.

        Transform.localScale es la escala actual de un objeto frente a su objeto padre, esto permite modificar la anchura, altura y profundidad del objeto.


        Ejercicio 8. Explica la clase Quaternion y haz un ejemplo con Quaternion.LookRotation y Transform.LookAt.

        La clase quaternion es una clase empleada para poder representar rotaciones en un espacio tridimensional evitando los problemas de los ángulos Euler evitando el bloqueo cardán. 




        Ejercicio 10. Explica Quaternion.identity, rota con Quaternion.operator * y rota suave con Quaternion.Slerp.

        Quaternion.identity es una constante que representa un cuaternión que no tiene ninguna rotación.  

        Ejercicio 14. Define velocidad angular, interactúa aquí y explica las diferencias entre LERP y SLERP en rotación.

        La velocidad angular en física es la representación pseudovectorial de como la posición angular de un objeto cambia conforme pasa el tiempo alrededor de un eje y como de rapido cambia su direccion en el propio eje.


        */
        if (e5 == true)
        {
            Ejercicio5();
        }
        if (e6 == true)
        {
            Ejercicio6();
        }
        if (e8 == true)
        {
            Ejercicio8();
        }
        if (e9 == true)
        {
            Ejercicio9();
        }

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

    }

    void Ejercicio7()
    {
        transform.localScale = new Vector3(0.25f, 0.5f, 0.75f);
    }

    void Ejercicio8()
    {
        if (LookRotation == true)
        {
            Vector3 posicionrelativa = new Vector3(3f, 3, 3f);

            Quaternion rotation = Quaternion.LookRotation(posicionrelativa, Vector3.up);
            transform.rotation = rotation;
        }
        else
        {
            transform.LookAt(target2.position);
        }

    }
    void Ejercicio9()
    {

      //  Ejercicio 9.Usa Quaternion.Angle, Quaternion.Euler, Quaternion.FromToRotation y Quaternion.RotateTowards.


        switch (ejercicio9Quarter)
        {
            
            case 0:
                //Quaternion.Angle
                float angle = Quaternion.Angle(transform.rotation, target1.rotation);
                Debug.Log(angle);
                break;
            case 1:
                // Quaternion.Euler 

                Vector3 rotationVector = new Vector3(0, 30, 0);
                Quaternion rotation = Quaternion.Euler(rotationVector);
                Debug.Log(rotation);
                break;

            case 2:
                //Quaternion.FromToRotation 
                transform.rotation = Quaternion.FromToRotation(target1.position, transform.forward);
                break;

            case 3:
                // Quaternion.RotateTowards
                
                transform.rotation = Quaternion.RotateTowards(transform.rotation, target1.rotation, (10*Time.deltaTime));
                break;

        }

    }
}
