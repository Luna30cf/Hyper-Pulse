using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Le bouton Play a été cliqué !");
        SceneManager.LoadScene("GameScene");
    }

    public void Home()
    {
        Debug.Log("Le bouton Home a été cliqué !");
        SceneManager.LoadScene("Menu");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
