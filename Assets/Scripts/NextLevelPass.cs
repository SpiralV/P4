using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelPass : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("LevelPass");
    }
}
