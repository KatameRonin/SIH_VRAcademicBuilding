using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class apppath : MonoBehaviour
{
    public Text text;

    void Start() { 
        text.gameObject.SetActive(false);
    }

    public void checkpath()
    {
        text.text = Application.persistentDataPath;
        text.gameObject.SetActive(true);
    }
}
