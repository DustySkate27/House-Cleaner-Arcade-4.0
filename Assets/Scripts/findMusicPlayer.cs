using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findMusicPlayer : MonoBehaviour
{
    public void findSetVolume(float volume)
    {
        musicPlayer.instance.SetVolume(volume);
    }
    public void findPlayStopMusic(bool activate)
    {
        musicPlayer.instance.PlayStopMusic(activate);
    }
}
