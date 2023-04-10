using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Entity : NetworkBehaviour
{
    [SyncVar]
    public float health;

    protected virtual void Update()
    {
        if (!isServer) return;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("health");
            health++;
        }
    }
}
