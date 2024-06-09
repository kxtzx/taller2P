using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablero : MonoBehaviour
{
    public Juego juego;
    public Casilla[] casillas;

    public void Inicializar(Juego juego)
    {
        this.juego = juego;
    }
}
