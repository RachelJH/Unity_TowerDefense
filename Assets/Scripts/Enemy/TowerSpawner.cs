using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject towerPrefab;
    [SerializeField]
    private int towerBulidGold = 50;
    [SerializeField]
    private EnemySpawner enemySpawner;
    [SerializeField]
    private PlayerGold playerGold;
    public void SpawnTower(Transform tileTransform)
    {
        if(towerBulidGold > playerGold.CurrentGold)
        {
            return;
        }

        Tile tile = tileTransform.GetComponent<Tile>();

        if (tile.IsBuildTower == true)
        {
            return;
        }

        tile.IsBuildTower = true;
        playerGold.CurrentGold -= towerBulidGold;

        Vector3 position = tileTransform.position + Vector3.back;
        GameObject clone =  Instantiate(towerPrefab, position, Quaternion.identity);
    
        clone.GetComponent<TowerWeapon>().SetUp(enemySpawner);
    }
}
