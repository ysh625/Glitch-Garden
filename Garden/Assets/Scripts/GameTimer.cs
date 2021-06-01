using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer in SECONDS")]
    [SerializeField] float levelTime = 10;
    bool triggerdLevelFinished = false;
    // Update is called once per frame
    void Update()
    {
        if (triggerdLevelFinished) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;
        bool timeFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timeFinished)
        {
            Debug.Log("Level time expired");
            FindObjectOfType<LevelController>().LevelTimerFinished();
            triggerdLevelFinished = true;
        }
    }
}
