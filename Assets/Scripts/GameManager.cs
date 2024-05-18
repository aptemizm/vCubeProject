using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject MenuPause;
    private PlayerController playerController;
    private FlashLight flashLight;

    private bool GamePaesed;

    void Start()
    {
        MenuPause.SetActive(false);
        playerController = FindObjectOfType<PlayerController>();
        flashLight = FindObjectOfType<FlashLight>();
        GamePaesed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaesed) 
            {
                PauseOff();
                GamePaesed = false;
            }
            else
            {
                PauseOn();
                GamePaesed = true;
            }
        }
    }

    public void PauseOn()
    {
        MenuPause.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        playerController.enabled = false;
        flashLight.enabled = false;
    }

    public void PauseOff()
    {
        MenuPause.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerController.enabled = true;
        flashLight.enabled = true;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("locationV2");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Buntar");
        Time.timeScale = 1;
    }  
}
