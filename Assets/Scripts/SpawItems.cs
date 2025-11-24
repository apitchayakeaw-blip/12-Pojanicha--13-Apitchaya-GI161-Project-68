using UnityEngine;
using System.Collections;

public class SpawItems : MonoBehaviour
{
    [SerializeField] GameObject[] itemPrefab;
    [SerializeField] float secondsSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnItems());
    }

    IEnumerator SpawnItems()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(itemPrefab[Random.Range(0, itemPrefab.Length)],
            position, Quaternion.identity);

            yield return new WaitForSeconds(secondsSpawn);

        }
    }
}
