using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    // Start is called before the first frame update
    void Rep()
    {
        SceneManager.LoadScene("Assets/Scenes/Menu.unity");
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
}
