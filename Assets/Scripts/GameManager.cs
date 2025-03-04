using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;
    public TextMeshProUGUI TextoPuntos;  // Texto en pantalla
    private int puntos = 0;

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
    }

    private void Start()
    {
        ActualizarPuntuacion();
    }

    public void AumentarPuntos()
    {
        puntos++;
        ActualizarPuntuacion();
    }

    private void ActualizarPuntuacion()
    {
        if (TextoPuntos != null)
        {
            TextoPuntos.text = "Puntos: " + puntos;
        }
    }
}
