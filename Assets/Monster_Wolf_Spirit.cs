using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Monster_Wolf_Spirit : Monster_Wolf
{
    [SyncVar]
    public float spiritPower;

    protected override void Update()
    {
        base.Update();
        if (!isServer) return;
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("spiritPower");
            spiritPower++;
        }
    }
}
