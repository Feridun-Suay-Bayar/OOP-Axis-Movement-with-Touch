using PlayerMove.Abstracts.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerMove.Inputs
{
    public class TouchInput : MonoBehaviour, IInput
    {

        private Vector2 _direction;
        public Vector2 Direction => _direction; //Interface

        Vector2 _beginingPosition;
        Vector2 _endPosition;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.touchCount > 0)
            {   
                Touch parmak = Input.GetTouch(0); // 1 parmak dokunuþu, 1 yazsaydýk 2 parmak dokunuþu olacaktý.
                if (parmak.phase == TouchPhase.Began)//Dokunma gerçekleþtiyse.
                {
                    _beginingPosition = parmak.position;
                }
                if (parmak.phase == TouchPhase.Stationary)//Dokunma devam ediyorsa.
                {
                    
                }
                if (parmak.phase == TouchPhase.Moved)//Oyuncu parmaðýný hareket ettiriyorsa.
                {
                    _endPosition = parmak.position;
                    _direction = _endPosition - _beginingPosition;
                }
                if (parmak.phase == TouchPhase.Ended)//Dokunma bittiyse.
                {
                    _beginingPosition = Vector2.zero;
                    _endPosition = Vector2.zero;
                    _direction = Vector2.zero;
                }
            }
        }
    }
}