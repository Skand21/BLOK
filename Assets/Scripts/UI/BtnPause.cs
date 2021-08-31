using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPause : MonoBehaviour
{
    public GameObject SoundOn;
    public GameObject SoundOff;
    public GameObject MusicOn;
    public GameObject MusicOff;

    public GameObject MusicObj; //контроллер музыки
    public GameObject SoundObj; //контроллер звука

    bool music;
    bool sound;

    private void Awake()
    {
        if (music == false)
        {
            MusicOn.SetActive(true);
            MusicOff.SetActive(false);
        }
        else
        {
            MusicOn.SetActive(false);
            MusicOff.SetActive(true);
        }


        if (sound == false)
        {
            SoundOn.SetActive(true);
            SoundOff.SetActive(false);
        }
        else
        {
            SoundOn.SetActive(false);
            SoundOff.SetActive(true);
        }
    }

    //Для вкл/выкл звуков
    public void BtnSound()
    {
        if (sound == true)
        {
            sound = false;
            //SoundObj.SetActive(true);

            SoundOn.SetActive(true);
            SoundOff.SetActive(false);
        }
        else
        {
            sound = true;
            //SoundObj.SetActive(false);

            SoundOn.SetActive(false);
            SoundOff.SetActive(true);
        }
    }

    //Для вкл/выкл музыки
    public void BtnMusic()
    {
        if (music == true)
        {
            music = false;
            MusicObj.SetActive(true);

            MusicOn.SetActive(true);
            MusicOff.SetActive(false);
        }
        else
        {
            music = true;
            MusicObj.SetActive(false);

            MusicOn.SetActive(false);
            MusicOff.SetActive(true);
        }
    }
    

    public void Home()
    {
        SceneManager.Portal.CloseInterfacesAll();
        SceneManager.Portal.ActiveateScene("MainMenu");
    }


    public void Play()
    {
        SceneManager.Portal.CloseInterfacesAll();
        SceneManager.Portal.ActiveateScene("Grid");
        SceneManager.Portal.ActiveateScene("Control");
        SceneManager.Portal.ActiveateScene("HeroPref");

        MovePlayer.PortalMovePlayer.StartRun();
    }

    public void Restart()
    {
        SceneManager.Portal.CloseInterfacesAll();
        SceneManager.Portal.ActiveateScene("Grid");
        SceneManager.Portal.ActiveateScene("Control");
        SceneManager.Portal.ActiveateScene("HeroPref");

        MovePlayer.PortalMovePlayer.StartRun();
        MovePlayer.PortalMovePlayer.transform.position = new Vector3(0, 0, 0);
    }
}
