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
    private bool isArea = false;//Ŀ���ѡ��ʽ
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
        //// �������Ļ����ת��Ϊ�������ꡪ��ʵ�ֿ��Ƹ�������ƶ���קЧ��
        //Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
        //Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
        //transform.position = worldPos;

        // �������Ļ����ת��Ϊ�������ꡪ��ʵ�ֿ��Ƹ�������ƶ���קЧ��
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

    //���¿��Ơ�B����mp�Ƿ����
    public void setCardState()
    {
        canDrag = cardItem.Cost <= player.MP;
    }
}
