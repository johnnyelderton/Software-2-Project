﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.ImageEffects;
using System;
using System.Reflection;
using Assets.SwimmingSystem.Scripts;

namespace Assets.SwimmingSystem.Scripts
{

    public class Swim : MonoBehaviour
    {

        private FirstPersonController _firstPersonController;

        private CharacterController _characterController;

        public Blur _blur;

        private Color _fogColorWater;

        // Default settings on start
        private float _defWalkspeed, _defJumpspeed, _defRunspeed, _defGravityMultiplier;

        private FogMode _defFogMode;

        private float _defFogDensity;

        private Color _defFogColor;

        private bool _defFogEnabled;

        private Camera _camera;

        private bool _isInWater = false;

        private float _waterSurfacePosY = 0.0f;

        public float _aboveWaterTolerance = 0.5f;

        [Range(0.5f, 3.0f)]
        public float _upDownSpeed = 1.0f;

		public GameObject fpc;      // firstPersonController

        // Use this for initialization
        void Start()
        {
            _firstPersonController = GetComponent<FirstPersonController>();

            _characterController = GetComponent<CharacterController>();
          
            _fogColorWater = new Color(0.2f, 0.65f, 0.75f, 0.5f);

            Transform fpChar = transform.FindChild("FirstPersonCharacter");

            _blur = fpChar.GetComponent<Blur>();

            _camera = fpChar.GetComponent<Camera>();

            // Default values for FirstPersonController on start
            _defWalkspeed = WalkSpeed;
            _defRunspeed = RunSpeed;
            _defJumpspeed = JumpSpeed;
            _defGravityMultiplier = GravityMultiplier;

            _defFogMode = RenderSettings.fogMode;
            _defFogDensity = RenderSettings.fogDensity;
            _defFogColor = RenderSettings.fogColor;
            _defFogEnabled = RenderSettings.fog;

			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
        }

        // Update is called once per frame
        void Update()
        {
			FirstPersonController fpScript = fpc.GetComponent("FirstPersonController") as FirstPersonController;
			if (Time.timeScale == 1) {
				fpScript.enabled = true;

				// Set underwater rendering or default
				if (IsUnderwater ()) {
					SetRenderDiving ();
				} else {
					SetRenderDefault ();
				}

				// Handle swimming
				// 1. If camera underwater we dive
				if (_isInWater) {
					if (IsUnderwater ()) {
						DoDiving ();
					} else {
						// we are grounded and not underwater, we might walk as well
						if (_characterController.isGrounded) {
							DoWalking ();
						} else {
							// we are not grounded so we are swimming above the surface
							HandleUpDownSwimMovement ();

						}
					}

				} else {
					DoWalking ();
				}
			}
			else {
				fpScript.enabled = false;
			}
        }

        // Check if we are underwater
        private bool IsUnderwater()
        {
            return _camera.gameObject.transform.position.y < (_waterSurfacePosY);
        }

        // Let's walk
        private void DoWalking()
        {
            StickToGroundForce = 10;
            WalkSpeed = Mathf.Lerp(WalkSpeed, _defWalkspeed, Time.deltaTime * 3.0f);
            RunSpeed = Mathf.Lerp(RunSpeed, _defRunspeed, Time.deltaTime * 3.0f);
            JumpSpeed = _defJumpspeed;
            GravityMultiplier = _defGravityMultiplier;
            UserHeadBob = true;
        }

        // Let's dive
        private void DoDiving()
        {
            WalkSpeed = 1.0f;
            RunSpeed = 2.0f;
            JumpSpeed = 0.0f;

            UserHeadBob = false;

            HandleUpDownSwimMovement();
   
        }

        private void HandleUpDownSwimMovement()
        {
            StickToGroundForce = 0.0f;

            GravityMultiplier = 0.1f;

            Vector3 mv = MoveDir;

            if (Input.GetKey(KeyCode.Space))
            {
                // go upwards
                if (_camera.gameObject.transform.position.y < _waterSurfacePosY + _aboveWaterTolerance)
                {
                    mv.y = _upDownSpeed;
                }

            }
            /*else if (Input.GetKey(KeyCode.Q))
            {
                // go down
                mv.y = -_upDownSpeed;
            }*/

            MoveDir = mv;
        }

        // Rendering when diving
        private void SetRenderDiving()
        {
            RenderSettings.fog = true;
            RenderSettings.fogColor = _fogColorWater;
            RenderSettings.fogDensity = 0.1f;
            RenderSettings.fogMode = FogMode.Exponential;
            _blur.enabled = true;
        }

        // Rendering when above water
        private void SetRenderDefault()
        {
            RenderSettings.fogColor = _defFogColor;
            RenderSettings.fogDensity = _defFogDensity;
            RenderSettings.fog = _defFogEnabled;
            RenderSettings.fogMode = _defFogMode;
            _blur.enabled = false;
        }


        public void OnTriggerEnter(Collider other)
        {
            if (LayerMask.LayerToName(other.gameObject.layer) == "Water")
            {
                // We enter the water... doesn't matter if we return from underwater, we are still in the water
                _isInWater = true;

                Debug.Log("Water Trigger Enter : " + _isInWater);
            }
        }

        public void OnTriggerExit(Collider other)
        {
            if (LayerMask.LayerToName(other.gameObject.layer) == "Water" && _isInWater)
            {
                // we are leaving the water, or are we under the sureface?
                _waterSurfacePosY = other.transform.position.y;
                float fpsPosY = this.transform.position.y;
                if (fpsPosY > _waterSurfacePosY)
                {
                    // ok we really left the water
                    _isInWater = false;
                }

                Debug.Log("Water Trigger Exit : " + _isInWater);
            }
        }
        
        #region Properties by reflection

        private Vector3 MoveDir
        {
            get
            {
                return (Vector3)ReflectionUtil.GetFieldValue(_firstPersonController, "m_MoveDir");
            }
            set
            {
                ReflectionUtil.SetFieldValue(_firstPersonController, "m_MoveDir", value);
            }
        }


        public float WalkSpeed
        {
            get
            {
                return (float)ReflectionUtil.GetFieldValue(_firstPersonController, "m_WalkSpeed");
            }
            set
            {
                ReflectionUtil.SetFieldValue(_firstPersonController, "m_WalkSpeed", value);
            }
        }

        public float RunSpeed
        {
            get
            {
                return (float)ReflectionUtil.GetFieldValue(_firstPersonController, "m_RunSpeed");
            }
            set
            {
                ReflectionUtil.SetFieldValue(_firstPersonController, "m_RunSpeed", value);
            }
        }

        public float JumpSpeed
        {
            get
            {
                return (float)ReflectionUtil.GetFieldValue(_firstPersonController, "m_JumpSpeed");
            }
            set
            {
                ReflectionUtil.SetFieldValue(_firstPersonController, "m_JumpSpeed", value);
            }
        }

        public float GravityMultiplier
        {
            get
            {
                return (float)ReflectionUtil.GetFieldValue(_firstPersonController, "m_GravityMultiplier");
            }
            set
            {
                ReflectionUtil.SetFieldValue(_firstPersonController, "m_GravityMultiplier", value);
            }
        }

        public float StickToGroundForce
        {
            get
            {
                return (float)ReflectionUtil.GetFieldValue(_firstPersonController, "m_StickToGroundForce");
            }
            set
            {
                ReflectionUtil.SetFieldValue(_firstPersonController, "m_StickToGroundForce", value);
            }
        }

        
        public bool UserHeadBob
        {
            get
            {
                return (bool)ReflectionUtil.GetFieldValue(_firstPersonController, "m_UseHeadBob");
            }
            set
            {
                ReflectionUtil.SetFieldValue(_firstPersonController, "m_UseHeadBob", value);
            }
        }

        #endregion

    }
}
