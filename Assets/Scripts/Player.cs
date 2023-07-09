using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Weapon sword;
    

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sword.isAttacking = true;
            base.Attack();
            sword.isAttacking = false;
        }
    }

    
}
