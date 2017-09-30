﻿using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    // Serialized
    [SerializeField] AudioClip clip;
    [SerializeField] int layerFilter = 11;
    [SerializeField] float playerDistanceThreshold = 5f;
    [SerializeField] bool isOneTimeOnly = true;

    // Private members
    bool hasPlayed = false;
    AudioSource audioSource;
    GameObject player; // will only trigger on distance to player

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = clip;

        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceToPlayer <= playerDistanceThreshold)
        {
            RequestPlayAudioClip();
        }
    }

    void RequestPlayAudioClip()
    {
        if (isOneTimeOnly && hasPlayed)
        {
            return;
        }
        else if (audioSource.isPlaying == false)
        {
            audioSource.Play();
            hasPlayed = true;
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 255f, 0, .5f);
        Gizmos.DrawWireSphere(transform.position, playerDistanceThreshold);
    }
}