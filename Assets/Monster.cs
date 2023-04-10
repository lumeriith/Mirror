using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Monster : Entity
{
    [SyncVar]
    public float damage;

    protected override void Update()
    {
        base.Update();
        if (!isServer) return;
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("damage");
            damage++;
        }
    }
}
