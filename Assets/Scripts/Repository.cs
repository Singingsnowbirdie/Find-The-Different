using System.Collections.Generic;
using UnityEngine;
using System.IO;

//репозиторий

public class Repository
{
    //количество коллекций
    int collectionsAmount = 2;

    //все коллекции
    Collection[] collections;

    public Repository()
    {
        for (int i = 0; i < collectionsAmount; i++)
        {
            //путь к папке с коллекцией
            string path = "Sprites/Collections/" + i.ToString();
        }



    }
}
