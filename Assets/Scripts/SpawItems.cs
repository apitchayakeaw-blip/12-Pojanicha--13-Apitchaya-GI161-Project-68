using UnityEngine;
using System.Collections;

public class SpawItems : MonoBehaviour
{
    [SerializeField] GameObject[] itemPrefab;
    [SerializeField] float secondsSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;

    [SerializeField] Character[] target;


    Coroutine spawnCoroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnCoroutine = StartCoroutine(SpawnItems());

        foreach (var t in target)
        {
            if (t != null)
            {
                t.OnDeath += StopSpawn;
            }
        }

    }


    void StopSpawn()
    {
        Debug.Log("Stop spawn because target is dead!");
        if (spawnCoroutine != null)
        {
            StopCoroutine(spawnCoroutine);
        }
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



 





