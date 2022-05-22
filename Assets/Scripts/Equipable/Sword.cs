using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : EquipableItem
{
    [SerializeField]
    Weapon weapon;
    private AudioSource audio;

    private void Start()
    {
        
        Physics.IgnoreCollision(GetComponent<Collider>(), player.gameObject.GetComponent<Collider>());
        audio = GetComponent<AudioSource>();
    }
    public override void Draw()
    {
        player.currentItem = this;
        player.anim.ResetTrigger("DrawSword");
        player.anim.SetTrigger("DrawSword");

    }
    public override void Sheath()
    {

        player.anim.ResetTrigger("SheathSword");
        player.anim.SetTrigger("SheathSword");

    }

    public override void Attack()
    {
        int random = Random.Range(0, 9);

        if (random % 2 == 0)
        {
            player.anim.ResetTrigger("Attack");
            player.anim.SetTrigger("Attack");
        }
        else
        {
            player.anim.ResetTrigger("Attack2");
            player.anim.SetTrigger("Attack2");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Character>())
        {
            if (isEquiped)
            {

                Character character = collision.gameObject.GetComponent<Character>();
                character.TakeHit(weapon.damage);

                audio.Play();
            }
        }
    }
}
