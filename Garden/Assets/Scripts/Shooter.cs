using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject gun;
    AttackerSpawner mySpawner;
    Animator animator;
    private void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
        
    }
    private void Update()
    {
        if (IsAttackerInLane())
        {
            animator.SetBool("IsAttacking", true);
        }
        else
        {
            animator.SetBool("IsAttacking", false);
        }
    }
    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) < Mathf.Epsilon);
            if (IsCloseEnough)
            {
                mySpawner = spawner;
            }
        }
        
    }
    private bool IsAttackerInLane()
    {
        if (mySpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
      
    }
}
