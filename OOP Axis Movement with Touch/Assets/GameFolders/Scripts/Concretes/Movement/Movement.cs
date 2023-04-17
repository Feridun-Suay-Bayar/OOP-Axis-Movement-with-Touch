using PlayerMove.Abstracts.Movers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerMove.Movements
{
    public class Movement : MonoBehaviour, IMover
    {
        Vector2 _direction;
        Transform _transform;

        public Vector2 Direction => _direction;

        public Transform Transform => _transform;
        public Movement(Transform transform)
        {
            _transform = transform;
        }

        public void MoveWithDirection(Vector2 direction,float speed)
        {
            _direction = direction.normalized;
            _direction.y = 0;
            _transform.position = ClampVector3(_transform.position);
            _transform.Translate(_direction * Time.deltaTime * speed,0);
    
        }
        public Vector3 ClampVector3(Vector3 transform)
        {
            Vector3 clampedPosition = transform;
            clampedPosition.x = Mathf.Clamp(clampedPosition.x, -4f, 4f);
            return clampedPosition;
        }
    }
}