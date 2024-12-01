using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{

    private FMOD.Studio.EventInstance _bgmEvent;
    private FMOD.Studio.EventInstance _titleScreenEvent;
    private FMOD.Studio.EventInstance _endingEvent1;
    private FMOD.Studio.EventInstance _endingEvent2;

    public AudioClip buttonClickClip;
    public AudioClip buttonHoverClip;

    private AudioSource source;

    private static bool initialised = false;

    void Awake()
    {
        if (GameObject.Find("AudioManager") != gameObject) {
            Destroy(gameObject);
        }

        if (initialised)
            return;

        source = GetComponent<AudioSource>();
        _bgmEvent = FMODUnity.RuntimeManager.CreateInstance("event:/BGM");
        _titleScreenEvent = FMODUnity.RuntimeManager.CreateInstance("event:/Menu");
        _endingEvent1 = FMODUnity.RuntimeManager.CreateInstance("event:/Ending 1");
        _endingEvent2 = FMODUnity.RuntimeManager.CreateInstance("event:/Ending 2");
        PlayTitleScreenMusic();

        DontDestroyOnLoad(this);

        initialised = true;
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

    public void PlayMainBGM()
    {
        _bgmEvent.start();
    }

    public void PlayEndingBGM1()
    {
        _endingEvent1.start();
    }

    public void PlayEndingBGM2()
    {
        _endingEvent2.start();
    }

    public void TransitionToGame()
    {
        StartCoroutine(ToGame());
    }

    public void TransitionToTitleScreen()
    {
        StartCoroutine(ToTitleScreen());
    }

    public void PlayButtonClickSound()
    {
        source.PlayOneShot(buttonClickClip, 0.08f);
    }

    public void PlayButtonHoverSound()
    {
        source.PlayOneShot(buttonHoverClip, 0.03f);
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
        _endingEvent1.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        _endingEvent2.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        yield return new WaitForSecondsRealtime(0.5f);
        _titleScreenEvent.start();
    }



}
