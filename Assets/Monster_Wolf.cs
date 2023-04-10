using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Monster_Wolf : Monster
{
    [SyncVar]
    public bool isPackLeader;

    protected override void Update()
    {
        base.Update();
        if (!isServer) return;
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("isPackLeader");
            isPackLeader = !isPackLeader;
        }
    }
}
