using UnityEngine;
using System.Collections;


public class ExitButton : MonoBehaviour
{
    private bool click = false;
    public void onClick()
    {
        click = true;
        Debug.Log("����");
    }
    void Update()
    {
        if (click == true)
        {
            Application.Quit();
        }
    }
}