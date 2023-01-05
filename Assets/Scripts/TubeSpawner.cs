using UnityEngine;

public class TubeSpawner : MonoBehaviour
{
    [SerializeField] public GameObject tube;
    [SerializeField] public float height;
    private float _maxTime = 1.5f;
    private float _timer = 0;

    void Update()
    {
        if (_timer > _maxTime)
        {
            GameObject newTube = Instantiate(tube);
            newTube.tag = tube.tag;
            newTube.transform.position = transform.position + new Vector3(10, Random.Range(-height, height), 0);
            _timer = 0;
            Destroy(newTube,15);
        }

        _timer += Time.deltaTime;
    }
}
