using UnityEngine;
using System.Collections;

public class TriggerWin : MonoBehaviour
{
    public string Lvl;

    void OnTriggerEnter2D(Collider2D other)
    {
        MovePlayer.PortalMovePlayer.rb.constraints = RigidbodyConstraints2D.FreezeAll;
        MovePlayer.PortalMovePlayer.vectorMovement = new Vector3(0, 0, 0);

        LvlManager.LvlChange.LvlNumber = Lvl;

        SceneManager.Portal.UNActiveateScene("Control");
        SceneManager.Portal.ActiveateScene("Win");
    }
}
