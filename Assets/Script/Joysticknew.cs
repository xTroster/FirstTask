using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joysticknew : MonoBehaviour
{
      [SerializeField] private Rigidbody _body;
      [SerializeField] private FixedJoystick _joystick;
      [SerializeField] private PlayerControl _playerControl;

      public float _moveForce = 5;

      private void Update()
      {
            _body.velocity = new Vector3(_joystick.Horizontal * _moveForce, _body.velocity.y,
                  _joystick.Vertical * _moveForce);

            if (_joystick.Horizontal != 0f || _joystick.Vertical != 0f)
            {
                  _playerControl.enabled = false;
            }
            else
            {
                  _playerControl.enabled = true;
            }
      }
}