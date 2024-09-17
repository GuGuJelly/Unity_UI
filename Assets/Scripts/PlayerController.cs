using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// 중간에서 중개해줄 프리젠터, 즉 컨트롤러가 UI와 모델을 들고 있게.
// ui의 내용을 직접 설정해주지 않고, model의 내용을 직접 변경해주는 역할.
// 모델과 ui의 변경사항만 연결해주는 역할.
// 콘트롤러는 로직만 구현하면 된다
public class PlayerController : MonoBehaviour
{
    
    [SerializeField] Rigidbody rigid;
    //[SerializeField] TextMeshProUGUI Text;

    [Header("Property")]
    [SerializeField] float jumpPower;
    //[SerializeField] int score;

    [Header("Model")]
    [SerializeField] PlayerModel model;

    [Header("UI")]
    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] Slider hpSlider;
    [SerializeField] TextMeshProUGUI mpText;
    [SerializeField] Slider mpSlider;

    

    private void OnEnable()
    {
        // OnHPChanged가 있었을때 체력의 변경사항을 등록하도록.
        model.OnHPChanged += UpdateHP;
        model.OnMPChanged += UpdateMP;
    }

    private void OnDisable()
    {
        model.OnHPChanged -= UpdateHP;
        model.OnMPChanged -= UpdateMP;
    }
    #region UI
    private void UpdateHP(int hp)
    {
        hpText.text = $"{hp}";
        hpSlider.value = hp;
    }

    private void UpdateMP(int mp)
    {
        mpText.text = $"{mp}";
        mpSlider.value = mp;
    }
    #endregion 
    private void Start()
    {
        UpdateHP(model.HP);
        UpdateMP(model.MP);
        hpSlider.maxValue = model.MaxHP;
        mpSlider.maxValue = model.MaxMP;
    }

    private void Update()
    {
        // 모델의 내용을 수정해주는게 컨트롤러의 내용 
        // 스페이스바를 누르면 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Jump();
            model.HP += 10;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            model.MP += 10;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            model.MP -= 10;
        }
    }

    //private void Jump()
    //{
    //    rigid.AddForce(Vector3.up* jumpPower,ForceMode.Impulse);
    //    //score++;
    //    scoreText.text = $"현재 점수: {score}";
    //}
    //
    //private void OnCollisionEnter(Collision collision)
    //{
    //    score++;
    //}
}
