using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EventType
{
    PLAYER_GETS_50_BEANS,
    PLAYER_SELLS_999_BEANS
}

public enum Entity
{
    PLAYER,
    ENEMY,
    BEAN_SALESMAN
}

public class Player
{
    public static int beans { get; set; }

    Player()
    {
        beans = 50;
    }
}

public interface IObserver 
{
    void OnNotify(Entity entity, EventType eventToTrigger);
}
