using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public string url;
    VideoPlayer player;
    private void Awake()
    {
        player = GetComponent<VideoPlayer>();
        player.url = url;
        player.isLooping = true;
    }

    public void PlayVideo()
    {
        player.Prepare();
        player.Play();
    }

    public void PauseVideo()
    {
        player.Pause();
    }
}
