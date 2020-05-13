using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class QmToggle : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (GameManager.isClickDown)
        {
            GetComponent<Toggle>().isOn = true;
        }
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        //if (GameManager.isClickDown)
        //{
        // //   GetComponent<Toggle>().isOn = false;
        //}
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if (GameManager.isClickDown)
        {
            //transform.parent.GetComponent<ToggleGroup>().enabled = true;\
            //GetComponent<Toggle>().isOn = false;
        }
        else
        {
            //GetComponent<Toggle>().isOn = false;
            //transform.parent.GetComponent<ToggleGroup>().enabled = false;
        }

        GameManager.isClickDown = !GameManager.isClickDown;
    }

    public void Setbool()
    {
        GameManager.isClickDown = false;
        GetComponent<Toggle>().isOn = false;
    }
}