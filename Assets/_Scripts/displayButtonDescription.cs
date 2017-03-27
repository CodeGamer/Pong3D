using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayButtonDescription : MonoBehaviour
{
    public string _ButtonDescription;
    public Text _DescriptionField;

    public void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter"); 
        _DescriptionField.text = _ButtonDescription;
    }

    public void OnMouseExit()
    {
        Debug.Log("OnMouseExit");
        _DescriptionField.text = "";
    }
}
