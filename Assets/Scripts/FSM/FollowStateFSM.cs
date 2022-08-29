using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowStateFSM : StateFSM
{
    PlayerMachineFSM player;
    Vector3 dir;
    public FollowStateFSM(PlayerMachineFSM player)
    {
        this.player = player;
    }
    public void Enter()
    {
        Debug.Log("Follow");
    }
    public void Update()
    {
        player.Move(player.TargetDir().normalized);
        if (player.energy<0)
        {
            player.SetState(new SleepStateFSM(player));
        }
        if (!player.IsNearTarget())
        {
            player.SetState(new SleepStateFSM(player));
        }
    }
    public void Exit()
    {

    }
}
