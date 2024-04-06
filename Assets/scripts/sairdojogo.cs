using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    void Start()
    {
        
        Button button = GetComponent<Button>();
        button.onClick.AddListener(QuitGame);
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
