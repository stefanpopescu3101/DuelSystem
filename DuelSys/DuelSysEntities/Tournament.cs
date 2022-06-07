﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysEntities
{
    public class Tournament
    {
        public int id;
        private string sportType;
        private string description;
        private string startDate;
        private string endDate;
        private int minPlayers;
        private int maxPlayers;
        private string location;
        private string tournamentType;
        private string status;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string SportType
        {
            get { return sportType; }
            set { sportType = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public int MinPlayers
        {
            get { return minPlayers; }
            set { minPlayers = value; }
        }

        public int MaxPlayers
        {
            get { return maxPlayers; }
            set { maxPlayers = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string TournamentType
        {
            get { return tournamentType; }
            set { tournamentType = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }



        public Tournament(int id, string sportType, string description, string startDate, string endDate, int minPlayers, int maxPlayers, string location, string tournamentType, string status)
        {
            this.id = id;
            this.sportType = sportType;
            this.description = description;
            this.startDate = startDate;
            this.endDate = endDate;
            this.minPlayers = minPlayers;
            this.maxPlayers = maxPlayers;
            this.location = location;
            this.tournamentType = tournamentType;
            this.status = status;
        }


        public Tournament(string sportType, string description, string startDate, string endDate, int minPlayers, int maxPlayers, string location, string tournamentType, string status)
        {
            
            this.sportType = sportType;
            this.description = description;
            this.startDate = startDate;
            this.endDate = endDate;
            this.minPlayers = minPlayers;
            this.maxPlayers = maxPlayers;
            this.location = location;
            this.tournamentType = tournamentType;
            this.status = status;
        }

        public void UpdateInfo(string sportType, string description, string startDate, string endDate, int minPlayers, int maxPlayers, string location, string status)
        {
            this.sportType = sportType;
            this.description = description;
            this.startDate = startDate;
            this.endDate = endDate;
            this.minPlayers = minPlayers;
            this.maxPlayers = maxPlayers;
            this.location = location;
            this.status = status;
            
        }
    }
}