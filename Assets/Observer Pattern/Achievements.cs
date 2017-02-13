using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement
{
    public string AchievementName { get; set; }

    public void Unlock()
    {
        GenericUIManager.ChangeText("You have unlocked the" + AchievementName + " achievement!!");
    }

}

public class Achievements : MonoBehaviour, IObserver
{
    public Dictionary<String, Achievement> achievements = new Dictionary<string, Achievement>();

    public void OnNotify(Entity entity, EventType eventToTrigger)
    {
        switch (eventToTrigger)
        {
            case EventType.PLAYER_GETS_50_BEANS:
                if(entity == Entity.PLAYER && Player.beans >= 50)
                {
                    Unlock(achievements[eventToTrigger.ToString()]);
                }
                break;
            default:
                break;
        }
    }

    private void Unlock(Achievement achievement)
    {
        achievement.Unlock();
    }

}
