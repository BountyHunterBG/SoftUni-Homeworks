﻿using System;
using System.Collections.Generic;
using System.Linq;
using MXGP.Models.Races.Contracts;
using MXGP.Models.Riders.Contracts;
using MXGP.Utilities.Messages;

namespace MXGP.Models.Races
{
    public class Race : IRace
    {
        private string name;
        private int laps;
        private List<IRider> riders;

        public Race(string name, int laps)
        {
            Name = name;
            Laps = laps;
            riders = new List<IRider>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Name {value} cannot be less than 5 symbols.");
                }

                name = value;
            }
        }

        public int Laps
        {
            get
            {
                return laps;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Laps cannot be less than 1.");
                }

                laps = value;
            }
        }

        public IReadOnlyCollection<IRider> Riders => riders.AsReadOnly();

        public void AddRider(IRider rider)
        {
            if (rider == null)
            {
                throw new ArgumentNullException(nameof(rider), "Rider cannot be null.");
            }
            if (!rider.CanParticipate)
            {
                throw new ArgumentException($"Rider {rider.Name} could not participate in race.");
            }
            if (riders.Any(r => r.Name == rider.Name))
            {
                throw new ArgumentNullException(nameof(rider) , $"Rider {rider.Name} is already added in {Name} race.");
            }

            riders.Add(rider);
        }
    }
}
