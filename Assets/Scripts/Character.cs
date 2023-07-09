using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected Animator animator;
    public float health = 100;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        animator = this.GetComponent<Animator>();
        if (animator == null)
        {
            animator = this.GetComponentInChildren<Animator>();
        }
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

    protected void Attack()
    {
        print("Attack!");
        animator.SetTrigger("Attack");
    }

    public void TakeDamage(float dmgAmount)
    {
        print($"{this.name} took {dmgAmount} damage!");
        print($"Health: {health}");
        health -= dmgAmount;
    }
}
