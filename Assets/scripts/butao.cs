using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class BackToSampleSceneButton : MonoBehaviour
{
    void Start()
    {
        
        Button button = GetComponent<Button>();
        button.onClick.AddListener(BackToSampleScene);
    }

    void BackToSampleScene()
    {
        
        SceneManager.LoadScene("SampleScene");
    }
}
