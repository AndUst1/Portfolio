using UnityEngine;

public class SpawnKnifes : MonoBehaviour
{
    [SerializeField] private GameObject KnifesToSpawn;
    [SerializeField] public Transform[] SpawnPoints;

    void Awake()
    {
        var index = Random.Range(2, SpawnPoints.Length);
        var spawn = Instantiate(KnifesToSpawn, SpawnPoints[index].position, Quaternion.identity);
    }
}
