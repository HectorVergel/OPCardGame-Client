using System;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;

/*
 * Class for applying hover effects to the game objects
 * like cards or whatever.
 */
public class InteractiveObject : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 mOriginalScale;
    private Vector2 mOriginalPosition;
    private RectTransform mRectTransform;

    public float hoverScale;
    public float positionOffset;
    private void Start()
    {
        mRectTransform = GetComponent<RectTransform>();
        Assert.IsTrue(mRectTransform != null, "Card must have Rect Transform component");
        
        mOriginalPosition = mRectTransform.localPosition;
        mOriginalScale = mRectTransform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mRectTransform.localScale *= hoverScale;
        mRectTransform.localPosition = new Vector2(mOriginalPosition.x, mOriginalPosition.y + positionOffset);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mRectTransform.localScale = mOriginalScale;
        mRectTransform.localPosition = mOriginalPosition;
    }
}
