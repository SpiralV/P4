using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelPass : MonoBehaviour
{
    private float delayTime = 4f;
    private float timePass;
    void Update ()
    {
        timePass += Time.deltaTime;
        if (timePass > delayTime)
        {
            SceneManager.LoadScene("FallBall-lv2-1");
        }
    }
}
