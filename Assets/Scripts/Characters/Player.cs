using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;
    private Vector3 _moveDir;
    

    // Start is called before the first frame update
    void Start()
    {
        ImputManager.init(this);
        ImputManager.GameMode();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * _moveDir;
    }

    public void SetMovementDirection(Vector3 newDirection) 
    {
        _moveDir = newDirection;
    }

}
