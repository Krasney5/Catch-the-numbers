using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField] private float _spawnRate;
    [SerializeField] private GameObject[] _numberPrefab;

    private List<GameObject> _spawnedPrefabs = new();

    private void Start()
    {
        StartCoroutine(SpawnNumber());
    }

    private IEnumerator SpawnNumber()
    {
        while (true)
        {
            var newObject = Instantiate(_numberPrefab[Random.Range(0, _numberPrefab.Length)], _spawnPoint[Random.Range(0, _spawnPoint.Length)].position, Quaternion.identity);
            _spawnedPrefabs.Add(newObject);
            if (_spawnRate >= 0.5)
            {
                _spawnRate -= 0.1f;
            }
            yield return new WaitForSeconds(_spawnRate);
        }
    }

    public void DeletePrefabs(GameObject spawned)
    {
        Destroy(spawned);
        _spawnedPrefabs.Remove(spawned);
    }

    public void DeletePrefabs()
    {
        foreach (var obj in _spawnedPrefabs)
        {
            Destroy(obj);
        }

        _spawnedPrefabs.Clear();
    }
}
