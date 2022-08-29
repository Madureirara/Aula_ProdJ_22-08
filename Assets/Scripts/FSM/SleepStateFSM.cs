using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepStateFSM : StateFSM
{
    PlayerMachineFSM player;
    float time;
    public SleepStateFSM(PlayerMachineFSM player)
    {
        this.player = player;
    }
    public void Enter()
    {
        time = Time.time + 3;
        Debug.Log("Sleep");
    }
    public void Update()
    {
        if (Time.time>time)
        {
            player.SetState(new PatrolStateFSM(player));
        }
    }
    public void Exit()
    {
        player.energy = 3;
    }
}
