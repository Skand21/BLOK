using UnityEngine;

public class BtnMainMenu : MonoBehaviour
{
    public GameObject BtnUnder;
    public GameObject BtnReTurn;

    public void BtnStart()
    {
        SceneManager.Portal.CloseInterfacesAll();
        SceneManager.Portal.ActiveateScene("Grid");
        SceneManager.Portal.ActiveateScene("Control");
        SceneManager.Portal.ActiveateScene("HeroPref");
        
        LvlManager.LvlChange.LoadLvl();

        MovePlayer.PortalMovePlayer.StartRun();
        MovePlayer.PortalMovePlayer.transform.position = new Vector3(0, 0, 0);
    }
    
    public void BtnNewGame()
    {
        LvlManager.LvlChange.LvlNumber = "Lvl1";
        BtnUnder.SetActive(false);
        BtnReTurn.SetActive(false);

        SceneManager.Portal.CloseInterfacesAll();
        SceneManager.Portal.ActiveateScene("Grid");
        SceneManager.Portal.ActiveateScene("Control");
        SceneManager.Portal.ActiveateScene("HeroPref");
        
        LvlManager.LvlChange.LoadLvl();

        MovePlayer.PortalMovePlayer.StartRun();
        MovePlayer.PortalMovePlayer.transform.position = new Vector3(0, 0, 0);
    }


    //public void BtnShop()
    //{
    //    SceneManager.Portal.CloseInterfacesAll();
    //    SceneManager.Portal.ActiveateScene("Shop");
    //}
    //public void BtnSettings()
    //{
    //    SceneManager.Portal.CloseInterfacesAll();
    //    SceneManager.Portal.ActiveateScene("Settings");
    //}


    public void BtnExit()
    {
        Application.Quit();
    }
}
