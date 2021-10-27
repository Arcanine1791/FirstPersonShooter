using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public bool toggle=true;
    private void Start()
    {
        GameEvents.instance.EnemyDead += KillMe;
        GameEvents.instance.EnemyDead += updateMyMessage;
            
    }
    public void KillMe()
    {
        toggle = !toggle;
        this.gameObject.SetActive(toggle);
    }

    public void updateMyMessage()
    {
        Debug.Log("kjhdjkhsdg");
    }
    private void OnDestroy()
    {
        GameEvents.instance.EnemyDead-=KillMe;
    }
}
