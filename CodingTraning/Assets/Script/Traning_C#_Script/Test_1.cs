using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Test_1 : MonoBehaviour
{
    private string[] messages = { "������" , "�͂���" , "��������" };

    private void Update() => RandomSendMessage();

    /// <summary>
    /// �}�E�X���N���b�N���ꂽ�烍�O�𓊂���B
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
