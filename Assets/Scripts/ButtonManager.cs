using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    bool isStart = false;

    public bool GetIsStart()
    {
        return isStart;
    }

    public void SetIsStart(bool end)
    {
        this.isStart = end;
    }

    public void GameStart()
    {
        isStart = true;
    }
}
