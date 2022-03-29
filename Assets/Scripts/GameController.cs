using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //репозиторий
    Repository repository;

    private void Awake()
    {
        //создаем экземпляр репозитория
        repository = new Repository();
    }
}
