using UnityEngine;

// Спавн всяких предметов в главном меню

public class MainMenuAnimation : MonoBehaviour
{
    public GameObject[] Objs;
    private int randomInt;
    private GameObject NewGameObj;
    public GameObject MainMenu;

    private void Update()
    {
        if (Input.touchCount == 2)
        {
            int t = Random.Range(-10, 10);
            transform.position += new Vector3(t, 0, 200);
            randomInt = Random.Range(0, Objs.Length);
            RandomSpawn();
            transform.position -= new Vector3(t, 0, 200);
        }
    }

    private void RandomSpawn()
    {
        NewGameObj = Instantiate(Objs[randomInt], transform.position, Quaternion.identity);
        int rotation = Random.Range(0, 179);
        NewGameObj.transform.Rotate(new Vector3(0, 0, rotation));
        if ((NewGameObj.transform.position.y < -50) || !(MainMenu.activeSelf)) Destroy(NewGameObj);
    }
}
