using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casilla : MonoBehaviour
{
    public enum TipoCasilla
    {
        Normal,
        Subir,
        Bajar,
        VolverAlInicio,
        OtroTurno
    }

    public TipoCasilla tipoCasilla;
    public int desplazamiento;

    public void AplicarEfecto(Jugador jugador)
    {
        switch (tipoCasilla)
        {
            case TipoCasilla.Subir:
                jugador.Mover(desplazamiento);
                break;
            case TipoCasilla.Bajar:
                jugador.Mover(-desplazamiento);
                break;
            case TipoCasilla.VolverAlInicio:
                jugador.Mover(-jugador.GetCasillaActual());
                break;
            case TipoCasilla.OtroTurno:
                jugador.tablero.juego.dado.LanzarDado(); // Permitir al jugador lanzar el dado nuevamente
                break;
            case TipoCasilla.Normal:
            default:
                break;
        }
    }
}
