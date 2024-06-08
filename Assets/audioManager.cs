using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    [Header("---------------Audio Source---------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;
    
    [Header("---------------Audio Clips---------------")]
    public AudioClip background;
    public AudioClip flap;
    public AudioClip score;
    public AudioClip gameOver;
    public AudioClip hit;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip sfx)
    {
        sfxSource.PlayOneShot(sfx);
    }

    public IEnumerator PlaySequentially(AudioClip clip1, AudioClip clip2)
    {
        PlaySFX(clip1);
        yield return new WaitForSeconds(clip1.length); // Wait for the first audio clip to finish
        PlaySFX(clip2);
    }
}
