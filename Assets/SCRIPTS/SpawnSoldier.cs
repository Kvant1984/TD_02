using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSoldier : MonoBehaviour
{
    [SerializeField] GameObject _object;
    [SerializeField] GameObject _spawnZone;

    public void SoldierSpawn() 
    {
        Vector3 _spawnPosition = new Vector3(1f, 1f, 1f);

        Instantiate(_object, _spawnPosition, Quaternion.identity);
    }
}
