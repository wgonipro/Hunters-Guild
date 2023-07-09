using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damage = 10;
    private float dmgDelay = 3;
    private bool b_isAttacking = false;
    public MeshCollider meshCollider;

    public bool isAttacking
    {
        get => b_isAttacking;
        set => b_isAttacking = value;
    }


    // Start is called before the first frame update
    void Start()
    {
        meshCollider = this.GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //TODO(wgonipro)::Should this move off the weapon?
        //If yes: how would projectiles work?
        //If no: how do we know if the weapon collides was an actual attack vs just getting close?
        print($"{this.name} collided with {collision.gameObject.name}");
        Character character = collision.gameObject.GetComponent<Character>();
        print($"Attacking? {isAttacking}, character? {character.name}");
        if (isAttacking && character != null)
        {
            character.TakeDamage(damage);
        }
    }
}
