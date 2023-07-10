using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected Animator animator;
    protected bool b_isAttacking = false;
    public float health = 100;
    public float f_attackSeconds = 3f;

    public float attackSeconds
    {
        get => f_attackSeconds;
    }

    protected void Awake()
    {
        
    }

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
        animator.SetTrigger("Attack");
    }

    protected virtual void Die()
    {
        Destroy(this.gameObject);
    }

    public void TakeDamage(float dmgAmount)
    {
        print($"{this.name} took {dmgAmount} damage!");
        health -= dmgAmount;
        if (health <= 0)
        {
            Die();
        }
        print($"Health: {health}");
    }
}
