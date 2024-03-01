using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(string trocaCena)
    {
        SceneManager.LoadScene(trocaCena);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
