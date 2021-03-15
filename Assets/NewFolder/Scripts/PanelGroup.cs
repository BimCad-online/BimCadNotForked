using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelGroup : MonoBehaviour
{
    public GameObject iconGroup;
    public GameObject[] otherGroup;

    public void Open_Close_group()
    {
        if(iconGroup.activeSelf == false)
        {
            iconGroup.SetActive(true);
        }
        else if(iconGroup.activeSelf == true)
        {
            iconGroup.SetActive(false);
        }
    }

    public void OtherGroupClose()
    {
        for(int i = 0; i <= otherGroup.Length; i++)
        {
            otherGroup[i].SetActive(false);
            i++;
        }
    }


}
