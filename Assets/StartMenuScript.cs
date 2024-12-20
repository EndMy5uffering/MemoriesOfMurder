using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{

    public int GameScene = 0;
    public int CreditScene = 6;

    public void onStartButton()
    {
        AudioManager.Instance.PlayButtonClickSound();
        AudioManager.Instance.TransitionToGame();
        SceneManager.LoadScene(GameScene);

    }

    public void onExit()
    {
        AudioManager.Instance.PlayButtonClickSound();
        Application.Quit();
    }

    public void onCredits()
    {
        AudioManager.Instance.PlayButtonClickSound();
        SceneManager.LoadScene(CreditScene);
    }

}
