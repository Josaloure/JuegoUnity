using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerMenu : MonoBehaviour
{
    public GameObject menuInicio;

    void Start()
    {
        Time.timeScale = 0f; // Pausar el juego al inicio
        menuInicio.SetActive(true);

    }

    public void IniciarJuego()
    {
        menuInicio.SetActive(false);
        Time.timeScale = 1f; // Reanudar el juego
    }


 public void SalirDelJuego()
{
    Debug.Log("Saliendo del juego...");
    #if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false; // Detener el juego en el Editor
    #else
    Application.Quit(); // Cerrar el juego en la versión compilada
    #endif
}
}
