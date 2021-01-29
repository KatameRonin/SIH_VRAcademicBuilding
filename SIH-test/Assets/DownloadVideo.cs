using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;

public class DownloadVideo : MonoBehaviour
{

    //atic int check = 0;

    public void OnClick()
    {
        StartCoroutine(VideoDownload());
       
    }

    IEnumerator VideoDownload()
    {

        var www = new WWW("https://res.cloudinary.com/onigiri/video/upload/v1579199701/VR/SIH_Videos/beach_qrdrzx.mp4");
        SSTools.ShowMessage("Downloading", SSTools.Position.bottom, SSTools.Time.twoSecond);
       //ebug.Log("Downloading!");
        yield return www;
        File.WriteAllBytes(Application.persistentDataPath + "/beach.mp4", www.bytes);
        SSTools.ShowMessage("Downloadeded", SSTools.Position.bottom, SSTools.Time.twoSecond);
        //ebug.Log("File Saved!");
        //eck= 1;
    }
}
