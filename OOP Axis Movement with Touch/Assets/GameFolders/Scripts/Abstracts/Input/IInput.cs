using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerMove.Abstracts.Inputs
{
    public interface IInput
    {
        Vector2 Direction { get; }
    }
}