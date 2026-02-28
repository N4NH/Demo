using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameOver_Panel : MonoBehaviour
{
    [SerializeField] private Button BackToMenu_Button;
    void OnEnable()
    {
        BackToMenu_Button.onClick.AddListener(BackToMenu_Button_Click);
    }
    void OnDisable()
    {
        BackToMenu_Button.onClick.RemoveListener(BackToMenu_Button_Click);
    }
    private void BackToMenu_Button_Click()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
