using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderManager : MonoBehaviour
{
    // Создали ссылку UnderChange на этот скрипт

    public static UnderManager UnderChange;
    public bool under;

    public List<GameObject> UnderScene;
    public List<GameObject> Scene;

    private void Awake()
    {
        UnderChange = this;
        if (under) ActivateInterfacesAll(UnderScene, Scene);
        else
            ActivateInterfacesAll(Scene, UnderScene);
    }
    public void Change()
    {
        under = !under;
        if (under) ActivateInterfacesAll(UnderScene, Scene);
        else
            ActivateInterfacesAll(Scene, UnderScene);
    }

    /// <summary>
    /// Функция открывает все UI
    /// </summary>
    public void ActivateInterfacesAll(List<GameObject> OnScene, List<GameObject> OffScene)
    {
        foreach (GameObject ui in OnScene)
        {
            ui.SetActive(true);                // Если UI выключен, включаем его
        }

        foreach (GameObject ui in OffScene)
        {
            ui.SetActive(false);                // Если UI включен, выключаем его
        }

    }

}
