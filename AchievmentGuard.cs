using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AchievmentGuard : MonoBehaviour
{
    public abstract void OnNotification(object value, AchievmentType achievmentType);
}

public abstract class AchievmentObject : MonoBehaviour
{
    List<AchievmentGuard> achievmentGuardList = new List<AchievmentGuard>();

    public void RegisterAchievment(AchievmentGuard achievmentGuard)
    {
        achievmentGuardList.Add(achievmentGuard);
    }

    public void Notifier(object value, AchievmentType achievmentType)
    {
        foreach(var achievment in achievmentGuardList)
        {
            achievment.OnNotification(value, achievmentType);
        }
    }
}