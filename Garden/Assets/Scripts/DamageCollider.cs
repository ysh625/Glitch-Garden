using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Attacker>() != null)
        {
            Destroy(collider.gameObject);
        }
        FindObjectOfType<LivesDisplay>().TakeLife();
    }
}
