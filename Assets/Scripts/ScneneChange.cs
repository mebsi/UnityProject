using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScneneChange : MonoBehaviour
{
    public void OnGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnMainScene()
    {
        SceneManager.LoadScene("Main");
    }
}
