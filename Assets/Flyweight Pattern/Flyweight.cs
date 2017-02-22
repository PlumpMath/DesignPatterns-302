using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyweight : MonoBehaviour
{        
    //The list that stores all aliens
    List<Alien> allAliens = new List<Alien>();

    List<Vector3> eyePositions;
    List<Vector3> legPositions;
    List<Vector3> armPositions;

    public bool useFlyweight;

    void Start()
    {
        //List used when flyweight is enabled
        eyePositions = GetBodyPartPositions();
        legPositions = GetBodyPartPositions();
        armPositions = GetBodyPartPositions();

        //Create all aliens
        for (int i = 0; i < 1000; i++)
        {
            Alien newAlien = new Alien();

            if(useFlyweight)
            {
                newAlien.eyePositions = eyePositions;
                newAlien.armPositions = legPositions;
                newAlien.legPositions = armPositions;
            }
            else
            {
                newAlien.eyePositions = GetBodyPartPositions();
                newAlien.armPositions = GetBodyPartPositions();
                newAlien.legPositions = GetBodyPartPositions();
            }


            allAliens.Add(newAlien);
        }
    }

    //Generate a list with body part positions
    List<Vector3> GetBodyPartPositions()
    {
        //Create a new list
        List<Vector3> bodyPartPositions = new List<Vector3>();

        //Add body part positions to the list
        for (int i = 0; i < 100; i++)
        {
            bodyPartPositions.Add(new Vector3());
        }

        return bodyPartPositions;
    }
}
