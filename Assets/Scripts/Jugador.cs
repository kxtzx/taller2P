using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Jugador : MonoBehaviour
{
    public string nombre;
    public Sprite sprite;
    public Casilla posicionActual;
    public Tablero tablero;

    public void Mover(int casillas)
    {
        int nuevaPosicionIndex = System.Array.IndexOf(tablero.casillas, posicionActual) + casillas;
        if (nuevaPosicionIndex >= tablero.casillas.Length)
        {
            nuevaPosicionIndex = tablero.casillas.Length - 1;
        }
        else if (nuevaPosicionIndex < 0)
        {
            nuevaPosicionIndex = 0;
        }

        posicionActual = tablero.casillas[nuevaPosicionIndex];
        posicionActual.AplicarEfecto(this);
    }

    public int GetCasillaActual()
    {
        return System.Array.IndexOf(tablero.casillas, posicionActual);
    }
}
