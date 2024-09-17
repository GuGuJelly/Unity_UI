using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

//  �𵨿��� ü���� �ٲ� ��쿡���� �̺�Ʈ�� �޾Ƽ� View�� �����ǵ��� ���� �� �ִ�
public class PlayerView : MonoBehaviour
{
    // �𵨿��� ü�¿� ��������� �־��� ���� �䰡 �����ǰ� ���� �� �ִ�
    // ����� �ϴ� �͵� �ƴϰ� �����͸� ���� ������ �ִ°� �ƴϴ�
    // UI�� ���Ÿ� ���ָ� �ȴ�. PlayerView
    // �����ʹ� �÷��̾�𵨿��� �ִ�
    // �𵨿� �̺�Ʈ�� �ִ�
    // �信���� �������� ǥ����. UI�� ǥ����.

    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] PlayerModel model;

    // ��Ʈ�������� ���� ���� ù��°
    private StringBuilder sb = new StringBuilder();

    // �̺�Ʈ�� �Ⱦ��� ������� ������ �̷� ������.
    // ������ ��õ������ �ʴ�
    // ������ �����Ͱ� �ǽð����� ���ϴ� ���̸� �Ʒ� ��ĵ� �����ϴ�
    // private void Update()
    // {
    //     �����Ͱ� �ǽð����� �ٲ�� ���� �� ��� �̰� ���ٴ� �ٸ���.
    //     UpdateHP(model.HP);
    // }

    // ü���� �ٲ������ ����ϴ� �� OnEnable����
    private void OnEnable()
    {
        model.OnHPChanged += UpdateHP;
    }

    // ü���� �ٲ���� �� �� �̻� �ȹٲ�� ���ִ� OnDisable����
    private void OnDisable()
    {
        model.OnHPChanged -= UpdateHP;
    }

    private void Start()
    {
        // �����Ҷ� ������Ʈ ü��
        UpdateHP(model.HP);
    }
    private void UpdateHP(int hp)
    {
        // ��Ʈ�������� ������
        // sb.Clear();
        // sb.Append(hp);
        // hpText.SetText(sb);
        hpText.text = $"{hp}";
    }

    private void UpdateMP(int mp)
    {
        // ��Ʈ�������� ������
        // sb.Clear();
        // sb.Append(hp);
        // hpText.SetText(sb);
        hpText.text = $"{mp}";
    }
}
