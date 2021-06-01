using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderBotton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    private void OnMouseDown()
    {
        var bottons = FindObjectsOfType<DefenderBotton>();
     
        foreach(DefenderBotton botton in bottons)
        {
            botton.GetComponent<SpriteRenderer>().color = new Color32(80, 80, 80, 255);
        }
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSeletedDefender(defenderPrefab);
       
    }
}
