using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BGMType { Stage = 0, Boss}
public class BGMController : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] bgmClips;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ChangeBGM(BGMType index)
    {
        audioSource.Stop();
        audioSource.clip = bgmClips[(int)index];
        audioSource.Play();
    }

    void Update()
    {
        
    }
}
