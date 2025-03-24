using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Card : MonoBehaviour,IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField]private Card_item cardItem;
    [SerializeField]private Image icon;
    [SerializeField]private TextMeshProUGUI cardID;
    [SerializeField]private CharacterBase player;

    private bool canDrag = false;
    private bool isArea = false;//目标的选择方式
    private bool canExecute = false;

    private CharacterBase target;
    private List<CharacterBase> targets = new List<CharacterBase>();


    public void CardInit(Item data , CharacterBase _player)
    {
        cardItem = (Card_item)data;
        icon.sprite = cardItem.Icon;
        cardID.text = cardItem.ID.ToString();
        player = _player;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if(canDrag)
        {
            switch (cardItem.Effects[0].TargetType)
            {
                case EffectTarget.Self:
                case EffectTarget.Target:
                    isArea = false;
                    break;
                case EffectTarget.TargetArea:
                case EffectTarget.All:
                case EffectTarget.Random:
                    isArea = true;
                    break;
            }

        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        //// 将鼠标屏幕坐标转换为世界坐标——实现卡牌跟随鼠标移动拖拽效果
        //Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
        //Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
        //transform.position = worldPos;

        // 将鼠标屏幕坐标转换为世界坐标——实现卡牌跟随鼠标移动拖拽效果
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            transform.parent as RectTransform,
            eventData.position,
            eventData.pressEventCamera,
            out localPoint);
        (transform as RectTransform).anchoredPosition = localPoint;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }

    //更新卡牌狀態——mp是否足夠
    public void setCardState()
    {
        canDrag = cardItem.Cost <= player.MP;
    }
}
