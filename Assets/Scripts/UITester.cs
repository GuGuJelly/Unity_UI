using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UITester : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] Button button;
    [SerializeField] TextMeshProUGUI text;
   private void Start()
   {
       // ��Ŭ�� �̺�Ʈ�� AddListener�� ���� ������ �� �ִ�
       // button.onClick.AddListener(Test);

        text.color = Color.white;
        text.fontSize = 15;
        //text.text = "ȯ���մϴ�";
   }
    public void Test()
    {
        //Debug.Log("�׽�Ʈ!");
        
    }
}
