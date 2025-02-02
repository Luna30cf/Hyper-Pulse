using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Le bouton Play a été cliqué !");
        SceneManager.LoadScene("GameScene");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
