using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Test_1 : MonoBehaviour
{
    private string[] messages = { "当たり" , "はずれ" , "超当たり" };

    private void Update() => RandomSendMessage();

    /// <summary>
    /// マウスがクリックされたらログを投げる。
    /// </summary>
    protected void RandomSendMessage()
    {
        var targetNumber = Random.Range(0, messages.Length);

        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(messages[targetNumber]);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log(messages[targetNumber]);
        }
    }
}
