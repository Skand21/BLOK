using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnWin : MonoBehaviour
{
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

        LvlManager.LvlChange.LoadLvl();
        
        MovePlayer.PortalMovePlayer.StartRun();
        MovePlayer.PortalMovePlayer.transform.position = new Vector3(0, 0, 0);
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
