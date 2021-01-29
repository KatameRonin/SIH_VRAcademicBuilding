using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class YesVR : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(ActivatorVR("cardboard"));
    }

    public IEnumerator ActivatorVR(string YESVR) {

        XRSettings.LoadDeviceByName(YESVR);
        yield return null;
        XRSettings.enabled = true;
    }
}
