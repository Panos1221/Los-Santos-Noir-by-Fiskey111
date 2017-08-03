﻿using LtFlash.Common.EvidenceLibrary.Serialization;

namespace LSNoir.Data
{
    public class SuspectData : IIdentifiable
    {
        public string ID { get; set; }
        public string Model;
        public LtFlash.Common.SpawnPoint Spawn;
        public string Name;
        public string Description; //?
        public int ChanceResisting;

        public string Weapon;
        public string Scenario;
        public string AnimName;
        public string AnimDictionary;

        public string[] ReportID; //NOTE: how we know about his identity
        public string DialogID;
        public string InterrogationID;
        public string[] NoteID;
    }
}
