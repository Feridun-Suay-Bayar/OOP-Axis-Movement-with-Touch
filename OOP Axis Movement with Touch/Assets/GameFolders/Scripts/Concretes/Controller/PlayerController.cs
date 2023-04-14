using PlayerMove.Inputs;
using PlayerMove.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerMove.Controllers
{
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] float _movementSpeed;

        TouchInput _touchInput;
        Movement _movement;

        // Start is called before the first frame update
        void Start()
        {
            _touchInput = GetComponent<TouchInput>();
            _movement = new Movement(transform);
        }

        // Update is called once per frame
        void Update()
        {
            _movement.MoveWithDirection(_touchInput.Direction, _movementSpeed);
        }
    }
}