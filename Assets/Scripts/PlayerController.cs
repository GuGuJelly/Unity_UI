using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// �߰����� �߰����� ��������, �� ��Ʈ�ѷ��� UI�� ���� ��� �ְ�.
// ui�� ������ ���� ���������� �ʰ�, model�� ������ ���� �������ִ� ����.
// �𵨰� ui�� ������׸� �������ִ� ����.
// ��Ʈ�ѷ��� ������ �����ϸ� �ȴ�
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
        // OnHPChanged�� �־����� ü���� ��������� ����ϵ���.
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
        // ���� ������ �������ִ°� ��Ʈ�ѷ��� ���� 
        // �����̽��ٸ� ������ 
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
    //    scoreText.text = $"���� ����: {score}";
    //}
    //
    //private void OnCollisionEnter(Collision collision)
    //{
    //    score++;
    //}
}
