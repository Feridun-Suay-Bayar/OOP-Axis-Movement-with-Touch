using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerMove.Abstracts.Movers
{
    public interface IMover
    {
        Vector2 Direction { get; }
        Transform Transform { get; }

        void MoveWithDirection(Vector2 direction, float speed);
    }
}