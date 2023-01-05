using System;
using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;


// Photon ネットワーク関係
[Obsolete("Obsolete")]
public class Player : NetworkBehaviour
{
    private NetworkCharacterController _cc;
    
    private void Awake()
    {
        _cc = GetComponent<NetworkCharacterController>();
    }

    public override void FixedUpdateNetwork()
    {
        if (GetInput(out NetworkInput data))
        {
            data.direction.Normalize();
            _cc.Move(5*data.direction*Runner.DeltaTime);
        }
    }
}
