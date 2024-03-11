using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pig : MonoBehaviour
{
    public AudioClip collisionClip; // 設定碰撞音效

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = collisionClip;
    }

    void OnTriggerEnter(Collider collider)
    {
       
            audioSource.PlayOneShot(collisionClip);
        
    }
}
