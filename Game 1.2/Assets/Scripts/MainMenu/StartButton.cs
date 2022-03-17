using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    private bool click = false;
    public string sceneToLoad = "1_Level";
    public void onClick()
    {
        click = true;
        Debug.Log("клик");
    }
    private void Update()
    {
        if (click == true){
            SceneManager.LoadScene(sceneToLoad);
        }

    }
}