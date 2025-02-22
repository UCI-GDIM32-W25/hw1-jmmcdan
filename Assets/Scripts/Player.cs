using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsPlanted = 0;
        _numSeedsLeft = _numSeeds;
        _plantCountUI.UpdateSeeds(_numSeeds, _numSeedsPlanted);
    }
    // allows wasd to have the player move
    private void Update()
    {
        if (Input.GetKey((KeyCode.W)))
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        if (Input.GetKey((KeyCode.A)))
        {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        if (Input.GetKey((KeyCode.S)))
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
        if (Input.GetKey((KeyCode.D)))
        {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }

        if(Input.GetKeyDown((KeyCode.Space)))
        {
            PlantSeed();
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
    }
    //this checks if the player still has seeds, and if they do plants them in the players position
    public void PlantSeed ()
    {
        if(_numSeedsLeft != 0)
        {
            _numSeedsLeft--;
            _numSeedsPlanted++;
            Instantiate(_plantPrefab, transform.position, Quaternion.identity);
            
        }
    }
}
