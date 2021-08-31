using UnityEngine;

public class ActivateBtnUnder : MonoBehaviour
{
    public GameObject Under;

    void OnTriggerEnter2D(Collider2D other)
    {
        Under.SetActive(true);
    }
}
