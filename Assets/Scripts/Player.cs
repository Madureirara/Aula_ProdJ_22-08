using UnityEngine;

public class Player : MonoBehaviour
{
    public AttackBehaviour attack;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attack.DoAttack();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            attack= new Kick();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            attack = new Punch();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            attack = new FireBall();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            attack = new IceBolt();
        }
    }
}
