using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Misuc;
    [SerializeField] private GameObject MenuPause;
    private PlayerController playerController;
    private FlashLight flashLight;
    private AudioSource[] AudioSouses;
    private bool GamePaesed;


    void Start()
    {
        MenuPause.SetActive(false);
        playerController = FindObjectOfType<PlayerController>();
        flashLight = FindObjectOfType<FlashLight>();
        GamePaesed = false;

        AudioSouses = Misuc.GetComponents<AudioSource>();
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

    private void SetActuveAudioSourses(bool value)
    {
        for (int i = 0; i < AudioSouses.Length; i++)
        {
            if (value)
            {
                AudioSouses[i].Play();
            }
            else
            {
                AudioSouses[i].Pause();
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
        SetActuveAudioSourses(false);
    }

    public void PauseOff()
    {
        MenuPause.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerController.enabled = true;
        flashLight.enabled = true;
        SetActuveAudioSourses(true);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Buntar");
        Time.timeScale = 1;
    }  
}
