﻿using _07.MilitaryElite2.Contracts_Interfaces;
using _07.MilitaryElite2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite2.Models_Classes
{
    public class Mission : IMission
    {
        public Mission(string codeName, MissionState missionState)
        {
            this.CodeName = codeName;
            this.MissionState = missionState;
        }

        public string CodeName { get; private set; }

        public MissionState MissionState { get; private set; }

        public void CompleteMission()
        {

            this.MissionState = MissionState.Finished;
        }
        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.MissionState}"; 
        }
    }
}
