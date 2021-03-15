using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseText : MonoBehaviour
{
    public GameObject buttonText;

    private void OnMouseEnter()
    {
        buttonText.SetActive(true);
        Debug.Log("OnMouseEnter");
    }

    private void OnMouseExit()
    {
        buttonText.SetActive(false);
        Debug.Log("OnMouseExit");
    }

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
    }

    private void OnMouseUpAsButton()
    {
        
    }

    public void OpenTextF()
    {
        buttonText.SetActive(true);
        Debug.Log("OnMouseEnter");
    }

    public void CloseTextF()
    {
        buttonText.SetActive(false);
        Debug.Log("OnMouseExit");
    }
}
