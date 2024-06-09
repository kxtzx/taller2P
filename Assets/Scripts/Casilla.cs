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
    public Transform destino; // Referencia al transform de destino para Subir y Bajar

    public void AplicarEfecto(Jugador jugador)
    {
        switch (tipoCasilla)
        {
            case TipoCasilla.Subir:
                if (destino != null)
                    jugador.transform.position = destino.position; // Mover el jugador al destino
                else
                    Debug.LogError("No se ha asignado un destino para la casilla de tipo Subir.");
                break;
            case TipoCasilla.Bajar:
                if (destino != null)
                    jugador.transform.position = destino.position; // Mover el jugador al destino
                else
                    Debug.LogError("No se ha asignado un destino para la casilla de tipo Bajar.");
                break;
            case TipoCasilla.VolverAlInicio:
                jugador.transform.position = Vector3.zero; // Mover el jugador al origen
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
