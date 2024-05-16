using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _scoreText;

    int _score = 0;

    void Awake()
    {
        _score = PlayerPrefs.GetInt("Score", 0);
        UpdateScore();
    }

    public void PlusButton()
    {
        _score += 1;
        UpdateScore();
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }

    void UpdateScore()
    {
        PlayerPrefs.SetInt("Score", _score);
        _scoreText.text = _score.ToString();
    }
}