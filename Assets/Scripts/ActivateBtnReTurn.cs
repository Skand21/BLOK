using UnityEngine;

public class ActivateBtnReTurn : MonoBehaviour
{
    public GameObject reTurn;

    void OnTriggerEnter2D(Collider2D other)
    {
        reTurn.SetActive(true);
    }
}
