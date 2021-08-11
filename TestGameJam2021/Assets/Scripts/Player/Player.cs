using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] private Rigidbody2D _rigidbody;
   [SerializeField] private float _speed;
   [SerializeField] private float _jumpforse;
   [SerializeField] private Transform _checkPoint;
   [SerializeField] private LayerMask _layer;
   [SerializeField] private float _range;
   private bool _isTurned;
   private Vector3 _sizes;
   private int _extra;
   private void Start() {
       _sizes = transform.localScale;
   }
   private void Update() {
       float movement = Input.GetAxis("Horizontal");
       _rigidbody.velocity = new Vector2(movement* _speed,_rigidbody.velocity.y);
       bool _isOnEarth = Physics2D.OverlapCircle(_checkPoint.position,_range, _layer);
       
       if (Input.GetKeyDown(KeyCode.Space) && _isOnEarth ==true)
       {
          Jump();
       }
       
       if(movement != 0)
       {
           _isTurned = movement > 0;
           ChangeDirection();
       }
      


   }
   private void Jump() 
   { 
       _rigidbody.velocity = Vector2.up*_jumpforse;
   }
   
   private void ChangeDirection() {
       float _turn = _isTurned ?_sizes.x : -_sizes.x;
     Vector3 scale = transform.localScale;
        scale.x = _turn;
       transform.localScale = scale;
   }
}
