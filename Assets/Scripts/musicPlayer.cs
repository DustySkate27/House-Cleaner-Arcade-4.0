using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPlayer : MonoBehaviour
{
    public static musicPlayer instance;

    [SerializeField] private AudioClip gameMusic;
    [SerializeField] private AudioClip storeMusic;
    private AudioSource audioSource;

    private bool musicON = true;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (musicON)
        {
            audioSource.loop = true;
            audioSource.clip = gameMusic;
            audioSource.Play();
        }
        
    }

    public void putMusic()
    {
        if(musicON)
        {
            audioSource.clip = gameMusic;
            audioSource.Play();
        }
    }

    public void putStore()
    {
        if(musicON)
        {
            audioSource.clip = storeMusic;
            audioSource.Play();
        }
    }

    public void PlayStopMusic(bool activate)
    {
        if (activate)
        {
            musicON = activate;
            audioSource.Play();
        }
        else
        {
            musicON = activate;
            audioSource.Stop();
        }
        
        
    }

}
