using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;
    [SerializeField] TextMeshProUGUI _levelText;
    [SerializeField] GameObject _finishWindow;

    private void Start()
    {
        _levelText.text = SceneManager.GetActiveScene().name;
    }
    public void Play()
    {
        _startMenu.SetActive(false);

        FindObjectOfType<PlayerBehaviour>().Play();
    }
    public void ShowFinishWindiw()
    {
        _finishWindow.SetActive(true);
    }
    public void NextLevel()
    {
        int next = SceneManager.GetActiveScene().buildIndex + 1;

        if (next < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(next);
        }        
    }
}
