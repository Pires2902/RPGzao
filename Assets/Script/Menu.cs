using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] string videoFile;
    [SerializeField] VideoPlayer vp; 
    float tempo;
    // Start is called before the first frame update
    void Start()
    {
        playVideo();
    }

    void playVideo(){
        string caminho=System.IO.Path.Combine(Application.streamingAssetsPath, videoFile);
        vp.url =caminho;
        vp.Play();
      //   tempo=(float)vp.clip.length;

    }
}
