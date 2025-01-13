using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bunny;

    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft = 5;
    private int _numSeedsPlanted = 0;

    private void Start ()
    {
        _playerTransform = this.transform;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) //player moves up with W key
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) //player moves left with A key
        {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) //player moves down with S key
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) //player moves right with D key
        {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space)) //seed appears with space key
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if (_numSeeds > 0)
        {
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
            Debug.Log("number seeds decrease");
            _numSeeds -= 1;
            _numSeedsLeft -= 1;
            _numSeedsPlanted += 1;
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
            
        }
    }
}
