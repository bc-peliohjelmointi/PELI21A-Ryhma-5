using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneLoad : MonoBehaviour
{
    private float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2.03f)
        {
            SceneManager.LoadScene(2);
        }
    }
}
