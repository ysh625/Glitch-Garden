using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int MyHP = 3;
    [SerializeField] int damage = 1;
    Text HPText;
    void Start()
    {
        HPText = GetComponent<Text>();
        UpdateDisplay();
    }
    private void UpdateDisplay()
    {

        HPText.text = MyHP.ToString();
    }

    public void TakeLife()
    {
        
            MyHP -= damage;
            UpdateDisplay();
        if (MyHP <= 0)
        {
            print("litch ate your head");
            FindObjectOfType<LevelLoder>().LoadLoseScene();
        }

    }
}
