using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlManager : MonoBehaviour
{
    // Создали ссылку LvlChange на этот скрипт

    public static LvlManager LvlChange;
    public string LvlNumber;
    public List<GameObject> UserInterfaces; // Лист Включаемых и Выключаемых объектов

    private void Awake()
    {
        LvlChange = this;
        LoadLvl();
    }

    public void LoadLvl()
    {
        CloseInterfacesAll();
        ActiveateScene(LvlNumber);
    }

    // Включаем сцену
    public void ActiveateScene(string nameInterface)
    {
        GetInterface(nameInterface).SetActive(true);
    }

    // Выключаем сцену
    public void UNActiveateScene(string nameInterface)
    {
        GetInterface(nameInterface).SetActive(false);
    }

    /// <summary>
    /// Функция берет название интерфейса и ищет на него ссылку в массиве, если находит, то возвращает на него ссылку, иначе null */
    /// </summary>
    public GameObject GetInterface(string nameInterface)
    {
        foreach (GameObject ui in UserInterfaces)           // Перебор интерефесов в массиве
        {
            if (ui.name.Equals(nameInterface))              // Сравниваем название интерфейса с нужным нам
            {
                return ui;                                  // Если названия похожи, возвращаем ссылку на него
            }
        }
        return null;                                        // Если сходств нет, то Null
    }

    /// <summary>
    /// Функция закрывает все UI
    /// </summary>
    public void CloseInterfacesAll()
    {
        foreach (GameObject ui in UserInterfaces)
        {
            if (ui.activeSelf)
                ui.SetActive(false);                // Если UI включен, выключаем его
        }
    }

}
