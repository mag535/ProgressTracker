using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : Singleton<SceneChanger>
{
    public void ChangeScene(string name)
    {
        try
        {
            SceneManager.LoadScene(name);
        }
        catch
        {
            // FIXME: display message on create error window
            Debug.Log("ERROR -- Scene either doesn't exist or has not been added to Build Settings");
        }
        return;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
