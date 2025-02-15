﻿namespace Game_Scripts.Monster.State_Machine{
    public interface IStateMachineManager{
        WalkingNearbyPlayerState WalkingNearbyPlayerState { get; }
        WalkingRoutine WalkingRoutineState { get; }
        BaseMonsterState CurrentState { get; }
        NullState NullState { get; }

        void ChangeCurrentState(BaseMonsterState nextState);
    }
}