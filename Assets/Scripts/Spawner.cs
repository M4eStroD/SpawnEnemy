using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    [SerializeField] private float _timeSpawn = 2f;

    [SerializeField] private List<Transform> _spawnPosition = new List<Transform>();

    private void Start()
    {
        StartCoroutine(SpawnEnenmy());
    }

    private IEnumerator SpawnEnenmy()
    {
        WaitForSeconds wait = new WaitForSeconds(_timeSpawn);

        Vector3 rotate = new Vector3();

        while (true)
        {
            var enemy = Instantiate(_enemy, _spawnPosition[GetRandomPosition()].position, Quaternion.identity);

            rotate.y = Random.rotation.eulerAngles.y;
            enemy.transform.Rotate(rotate);            

            yield return wait;
        }
    }

    private int GetRandomPosition()
    {
        return Random.Range(0, _spawnPosition.Count);
    }
}
