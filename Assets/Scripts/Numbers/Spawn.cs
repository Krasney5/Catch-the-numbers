using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField] private float _spawnRate;
    [SerializeField] private GameObject[] _numberPrefab;

    private void Start()
    {
        StartCoroutine(SpawnNumber());
    }

    private IEnumerator SpawnNumber()
    {
        while (true)
        {
            Instantiate(_numberPrefab[Random.Range(0, _numberPrefab.Length)], _spawnPoint[Random.Range(0, _spawnPoint.Length)].position, Quaternion.identity);
            if (_spawnRate >= 0.5)
            {
                _spawnRate -= 0.1f;
            }
            yield return new WaitForSeconds(_spawnRate);
        }
    }
}
