using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

//  모델에서 체력이 바뀐 경우에서만 이벤트를 받아서 View가 수정되도록 해줄 수 있다
public class PlayerView : MonoBehaviour
{
    // 모델에서 체력에 변경사항이 있었을 때만 뷰가 수정되게 해줄 수 있다
    // 계산을 하는 것도 아니고 데이터를 직접 가지고 있는게 아니다
    // UI의 갱신만 해주면 된다. PlayerView
    // 데이터는 플레이어모델에만 있다
    // 모델에 이벤트가 있다
    // 뷰에서는 데이터의 표현만. UI의 표현만.

    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] PlayerModel model;

    // 스트링빌더를 쓰기 위한 첫번째
    private StringBuilder sb = new StringBuilder();

    // 이벤트를 안쓰는 방식으로 쓸려면 이런 식으로.
    // 하지만 추천하지는 않다
    // 하지만 데이터가 실시간으로 변하는 모델이면 아래 방식도 쓸만하다
    // private void Update()
    // {
    //     데이터가 실시간으로 바뀌는 경우는 잘 없어서 이거 보다는 다른거.
    //     UpdateHP(model.HP);
    // }

    // 체력이 바뀌었을때 등록하는 걸 OnEnable에서
    private void OnEnable()
    {
        model.OnHPChanged += UpdateHP;
    }

    // 체력이 바뀌었을 때 더 이상 안바뀌도록 해주는 OnDisable에서
    private void OnDisable()
    {
        model.OnHPChanged -= UpdateHP;
    }

    private void Start()
    {
        // 시작할때 업데이트 체력
        UpdateHP(model.HP);
    }
    private void UpdateHP(int hp)
    {
        // 스트링빌더를 쓸때는
        // sb.Clear();
        // sb.Append(hp);
        // hpText.SetText(sb);
        hpText.text = $"{hp}";
    }

    private void UpdateMP(int mp)
    {
        // 스트링빌더를 쓸때는
        // sb.Clear();
        // sb.Append(hp);
        // hpText.SetText(sb);
        hpText.text = $"{mp}";
    }
}
