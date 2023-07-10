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
        if (Input.GetKeyDown(KeyCode.Space) && !b_isAttacking)
        {
            StartCoroutine(SetAttacking()); //not wild about this... time based introduces a lot of issues
            base.Attack();
        }
    }

    protected override void Die()
    {
        base.Die();
        // Game Over
    }

    IEnumerator SetAttacking()
    {
        sword.isAttacking = true;
        b_isAttacking = true;
        print($"{this.name} is attacking");
        yield return new WaitForSeconds(f_attackSeconds);
        print($"{this.name} has attacked");
        sword.isAttacking = false;
        b_isAttacking = false;
    }
    
}
