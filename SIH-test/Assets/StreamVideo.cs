using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
using UnityEngine.Video;


public class StreamVideo : MonoBehaviour
{
    public VideoPlayer video;


    // Start is called before the first frame update
    void Start()
    {
        //if (DownloadVideo.check == 1)
        //{
            video.url = Application.persistentDataPath + "/beach.mp4";
            video.Play();
        //}
        //else
       // {
         //ideo.url = "https://res.cloudinary.com/onigiri/video/upload/v1579199701/VR/SIH_Videos/beach_qrdrzx.mp4";
         //  video.Play();
        //}
    }

    // Update is called once per frame
    //id Update()
    //

    //
}
