using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;
    [SerializeField]
    private Animator settingsAnimator;
    public void Retry()
    {
        soundManager.PlayButtonClick();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Play()
    {
        soundManager.PlayButtonClick();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Pause()
    {
        soundManager.PlayButtonClick();
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        soundManager.PlayButtonClick();
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        soundManager.PlayButtonClick();
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Restart()
    {
        soundManager.PlayButtonClick();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void Settings()
    {
        soundManager.PlayButtonClick();
        if (settingsAnimator.GetBool("enter"))
        {
            settingsAnimator.SetBool("enter", false);
            settingsAnimator.SetBool("exit", true);
        }
        else
        {
            settingsAnimator.SetBool("enter", true);
            settingsAnimator.SetBool("exit", true);
        }
    }

    [SerializeField]
    private AudioMixer musicAudioMixer;
    [SerializeField]
    private AudioMixer sfxAudioMixer;

    public void SetMusicVolume(float volume)
    {
        musicAudioMixer.SetFloat("Volume", volume);
    }
    public void SetSFXVolume(float volume)
    {
        sfxAudioMixer.SetFloat("Volume", volume);
    }

    public void SetGraphics(int graphics)
    {
        QualitySettings.SetQualityLevel(graphics);
    }

}