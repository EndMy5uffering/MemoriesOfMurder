using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{

    private FMOD.Studio.EventInstance _bgmEvent;
    private FMOD.Studio.EventInstance _titleScreenEvent;

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        _bgmEvent = FMODUnity.RuntimeManager.CreateInstance("event:/BGM");
        _titleScreenEvent = FMODUnity.RuntimeManager.CreateInstance("event:/Menu");
        PlayTitleScreenMusic();
    }

    public void PlayOneShotFMOD2D(string eventName)
    {
        FMOD.Studio.EventInstance eventInstance = FMODUnity.RuntimeManager.CreateInstance("event:/" + eventName);
        eventInstance.start();
        eventInstance.release();
    }

    public void PlayOneShotFMOD2DInt(string eventName, string param, int value)
    {
        FMOD.Studio.EventInstance eventInstance = FMODUnity.RuntimeManager.CreateInstance("event:/" + eventName);
        eventInstance.setParameterByName(param, value);
        eventInstance.start();
        eventInstance.release();
    }

    public void PlayOneShotFMOD3D(string eventName, Transform objectTransform)
    {
        FMOD.Studio.EventInstance eventInstance = FMODUnity.RuntimeManager.CreateInstance("event:/" + eventName);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(eventInstance, objectTransform);
        eventInstance.start();
        eventInstance.release();
    }

    public void PlayOneShotFMOD3DInt(string eventName, Transform objectTransform, string param, int value)
    {
        FMOD.Studio.EventInstance eventInstance = FMODUnity.RuntimeManager.CreateInstance("event:/" + eventName);
        eventInstance.setParameterByName(param, value);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(eventInstance, objectTransform);

        eventInstance.start();
        eventInstance.release();
    }

    public void PlayOneShotUnity(AudioClip clip, float volume = 1f)
    {
        source.PlayOneShot(clip, volume);
    }







    public void PlayTitleScreenMusic()
    {
        _titleScreenEvent.start();
    }

    public void TransitionToGame()
    {
        StartCoroutine(ToGame());
    }

    public void TransitionToTitleScreen()
    {
        StartCoroutine(ToTitleScreen());
    }

    private IEnumerator ToGame()
    {
        _titleScreenEvent.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        yield return new WaitForSecondsRealtime(0.5f);
        _bgmEvent.start();
    }

    private IEnumerator ToTitleScreen()
    {
        _bgmEvent.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        yield return new WaitForSecondsRealtime(0.5f);
        _titleScreenEvent.start();
    }

}
