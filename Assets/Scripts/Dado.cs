using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dado : MonoBehaviour
{

    public Sprite[] carasDado; // Arreglo de sprites para las caras del dado
    public Image image; // Componente Image donde se mostrará la imagen del dado
    public Juego juego; // Referencia al script Juego

    public void LanzarDado()
    {
        int resultado = Random.Range(0, carasDado.Length);
        image.sprite = carasDado[resultado];
        juego.MoverJugadorActual(resultado + 1);
    }

}
