using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerMove.Abstracts.Movers
{
    public interface IHorizontalMover
    {
        Vector2 Direction { get; }
        Transform Transform { get; }
    }
}