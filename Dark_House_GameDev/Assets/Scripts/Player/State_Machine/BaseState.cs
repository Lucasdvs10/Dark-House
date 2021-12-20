﻿using System;
using UnityEngine;

namespace Player.State_Machine{
    public abstract class BaseState{
        protected StateMachineManager _stateMachine;
        protected PlayerSingleton _playerSingleton;
        protected Rigidbody2D _playerRigidbody;
        
        
        protected BaseState(StateMachineManager stateMachineManager) {
            _stateMachine = stateMachineManager;
            _playerSingleton = PlayerSingleton.Instance;
            _playerRigidbody = _playerSingleton.GetComponent<Rigidbody2D>();
        }
        
        public virtual void executeState() {
        }

        public virtual void OnStateExit() {
            
        }


        public virtual void OnStateEnter() {
            
        }

    }
}