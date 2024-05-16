using UnityEngine;
using UnityEngine.SceneManagement;

public class Игровойменеджер : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Buntar2");
    }
}
