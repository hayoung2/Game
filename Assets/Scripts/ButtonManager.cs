using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    bool isStart = false;

    public bool GetIsStart()
    {
        return isStart;
    }

    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }


}
