using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Play_Button : MonoBehaviour
{
    [SerializeField] private Button Play_Button_Object;
    private void OnEnable()
    {
        Play_Button_Object.onClick.AddListener(OnPlayButtonClicked);
    }
    private void OnDisable()
    {
        Play_Button_Object.onClick.RemoveListener(OnPlayButtonClicked);
    }
    private void OnPlayButtonClicked()
    {
        Debug.Log("Play button clicked");
        SceneManager.LoadScene("Battle");
    }
}
