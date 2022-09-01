using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievments : AchievmentGuard
{
    void Start()
    {
        foreach(var achievment in FindObjectsOfType<AchievmentPlace>())
        {
            achievment.RegisterAchievment(this);
        }
    }

    public override void OnNotification(object value, AchievmentType achievmentType)
    {
        if(achievmentType == AchievmentType.AchievmentUnlocked)
        {
            PlayerPrefs.SetInt("Achievment " + value, 1);
        }
    }
}

public enum AchievmentType
{
    AchievmentLocked = 0, AchievmentUnlocked = 1
}

