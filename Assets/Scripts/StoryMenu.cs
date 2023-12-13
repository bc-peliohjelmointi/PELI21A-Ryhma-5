using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryMenu : MonoBehaviour
{
    public void ContinueGame()
    {
        SceneManager.LoadScene(1);
        Cursor.visible = false;
    }
}
