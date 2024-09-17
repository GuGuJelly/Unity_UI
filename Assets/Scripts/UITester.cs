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
       // 온클릭 이벤트는 AddListener를 통해 적어줄 수 있다
       // button.onClick.AddListener(Test);

        text.color = Color.white;
        text.fontSize = 15;
        //text.text = "환영합니다";
   }
    public void Test()
    {
        //Debug.Log("테스트!");
        
    }
}
