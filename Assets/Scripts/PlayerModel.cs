using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//  모델에서 체력이 바뀐 경우에서만 이벤트를 받아서 View가 수정되도록 해줄 수 있다
public class PlayerModel : MonoBehaviour
{
    // 계산만 진행해서 모델의 데이터를 바꿔준다
    // 데이터가 변경됐을때만 반응해도 된다.
    // 모델에다가 이벤트를 같이 달아준다
    [SerializeField] int hp;
    // 읽어들이는 get은 public으로, set 같은 경우는 설정하는것과 동시에 이벤트 발생
    public int HP { get { return hp; } set { hp = value; OnHPChanged?.Invoke(hp); } }

    [SerializeField] int mp;
    public int MP { get { return mp; } set { mp = value; OnMPChanged?.Invoke(mp); } }

    // 최대체력은 바뀌는 경우가 없다고 생각하고 만들어준다.
    [SerializeField] int maxHP;
    public int MaxHP { get { return maxHP; } }

    [SerializeField] int maxMP;
    public int MaxMP { get { return maxMP; } }
    
    // 체력에 변경사항이 있는 이벤트를 만든다
    // 체력이 변할때마다 이벤트가 발생된다
    public UnityAction<int> OnHPChanged;
    public UnityAction<int> OnMPChanged;
}
