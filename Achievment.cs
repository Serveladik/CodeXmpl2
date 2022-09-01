using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievment : AchievmentObject
{
    public string achievmentName;

    public void OnTriggerEnter(Collider objectCollider)
    {
        Notifier(achievmentName, AchievmentType.AchievmentUnlocked);
    }
}
