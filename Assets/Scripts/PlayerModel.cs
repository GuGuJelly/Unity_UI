using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//  �𵨿��� ü���� �ٲ� ��쿡���� �̺�Ʈ�� �޾Ƽ� View�� �����ǵ��� ���� �� �ִ�
public class PlayerModel : MonoBehaviour
{
    // ��길 �����ؼ� ���� �����͸� �ٲ��ش�
    // �����Ͱ� ����������� �����ص� �ȴ�.
    // �𵨿��ٰ� �̺�Ʈ�� ���� �޾��ش�
    [SerializeField] int hp;
    // �о���̴� get�� public����, set ���� ���� �����ϴ°Ͱ� ���ÿ� �̺�Ʈ �߻�
    public int HP { get { return hp; } set { hp = value; OnHPChanged?.Invoke(hp); } }

    [SerializeField] int mp;
    public int MP { get { return mp; } set { mp = value; OnMPChanged?.Invoke(mp); } }

    // �ִ�ü���� �ٲ�� ��찡 ���ٰ� �����ϰ� ������ش�.
    [SerializeField] int maxHP;
    public int MaxHP { get { return maxHP; } }

    [SerializeField] int maxMP;
    public int MaxMP { get { return maxMP; } }
    
    // ü�¿� ��������� �ִ� �̺�Ʈ�� �����
    // ü���� ���Ҷ����� �̺�Ʈ�� �߻��ȴ�
    public UnityAction<int> OnHPChanged;
    public UnityAction<int> OnMPChanged;
}
