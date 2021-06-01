using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;//找到当前选中的DefenderBotton，获取它引用的defenderPrefab，判断费用
    private void OnMouseDown()
    {
        print("attempt to spawn defender");
        AttemptToSpawnDefenderAt(GetSquareClicked());
    }
    private void AttemptToSpawnDefenderAt(Vector2 pos)
    {
        
        var starDisplay = FindObjectOfType<StarDisplay>();
        if (starDisplay.HaveEnoughStars(defender.GetStarCost()))
        {
            SpawnDefender(pos);
            starDisplay.SpendStars(defender.GetStarCost());
        }

    }
    public void SetSeletedDefender(Defender defenderToSelected)
    {
        defender = defenderToSelected;
    }
    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }
    private Vector2 SnapToGrid(Vector2 worldPos)
    {
        int newX = Mathf.RoundToInt(worldPos.x);
        int newY = Mathf.RoundToInt(worldPos.y);
        return new Vector2(newX, newY);
    }
    private void SpawnDefender(Vector2 roundPos)
    {
        Defender newDefender = Instantiate(defender, roundPos, Quaternion.identity) as Defender;
       // Debug.Log(roundPos);
    }
}
