using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Juego : MonoBehaviour
{
    public List<Jugador> jugadores;
    public Tablero tablero;
    public Dado dado;
    private int jugadorActual = 0;
    public UnityEngine.UI.Text ganadorTexto;

    void Start()
    {
        IniciarJuego();
    }

    public void IniciarJuego()
    {
        tablero.Inicializar(this);
        foreach (var jugador in jugadores)
        {
            jugador.posicionActual = tablero.casillas[0];
            jugador.tablero = tablero;
        }
    }

    public void FinalizarJuego(Jugador ganador)
    {
        ganadorTexto.text = "El jugador " + ganador.nombre + " ha ganado el juego!";
        // Implementar lógica adicional para finalizar el juego, como desactivar botones
    }

    public void MoverJugadorActual(int pasos)
    {
        Jugador jugador = jugadores[jugadorActual];
        jugador.Mover(pasos);
        if (jugador.posicionActual.tipoCasilla == Casilla.TipoCasilla.VolverAlInicio)
        {
            FinalizarJuego(jugador);
        }
        else
        {
            jugadorActual = (jugadorActual + 1) % jugadores.Count;

        }
    }

}
