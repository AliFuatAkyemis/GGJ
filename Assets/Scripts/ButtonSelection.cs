using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSelection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.transform.position = gameObject.transform.position - new Vector3(60f, 0);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        gameObject.transform.position = gameObject.transform.position + new Vector3(60f, 0);
    }
}
