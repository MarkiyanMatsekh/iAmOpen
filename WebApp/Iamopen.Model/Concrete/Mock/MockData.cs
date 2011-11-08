using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock
{
    public class MockData
    {
        static readonly Status statusOK = new Status() { ID = 1, Name = "OK" };
        static readonly Status statusNW = new Status() { ID = 2, Name = "NotWorking" };

        static readonly State state_1 = new State() { ID = 1, Name = "State1" };
        static readonly State state_2 = new State() { ID = 2, Name = "State2" };

        static readonly User user_1 = new User() { ID = 1, Nickname = "Nick_1", FirstLoginDLC = DateTime.Now, PrivacyOn = true };
        static readonly User user_2 = new User() { ID = 2, Nickname = "Nick_2", FirstLoginDLC = DateTime.Now, PrivacyOn = true };

        static readonly List<Institution> _institutions = new List<Institution>()
        {
            new Institution() { ID = 1, CoordinatesX = 1, CoordinatesY = 2, StateID = state_1.ID, StatusID = statusOK.ID, UserID = user_1.ID, IconPath = "somePath1", CreatedDLC = DateTime.Now, Rating = 5, Status = statusOK, State = state_1, CreatedByUser = user_1},
            new Institution() { ID = 2, CoordinatesX = 10, CoordinatesY = 21, StateID = state_1.ID, StatusID = statusOK.ID, UserID = user_2.ID, IconPath = "somePath2", CreatedDLC = DateTime.Now, Rating = 4, Status = statusNW, State = state_2, CreatedByUser = user_2},
            new Institution() { ID = 3, CoordinatesX = 11, CoordinatesY = 92, StateID = state_1.ID, StatusID = statusNW.ID, UserID = user_1.ID, IconPath = "somePath3", CreatedDLC = DateTime.Now, Rating = 3, Status = statusOK, State = state_1, CreatedByUser = user_1}
        };

        static readonly List<State> _states = new List<State>()
        {
            state_1,
            state_2
        };

        static readonly List<Chain> _chains = new List<Chain>()
        {
            new Chain(){ ID = 1, Name = "Silpo"}, 
            new Chain(){ ID = 2, Name = "Arsen"}, 
            new Chain(){ ID = 3, Name = "Local"}
        };

        static readonly List<Status> _statuses = new List<Status>()
        {
            statusOK,
            statusNW
        };

        static readonly List<User> _users = new List<User>()
        {
            user_1,
            user_2
        };

        public static List<Institution> Institutions { get { return _institutions; } }

        public static List<Chain> Chains { get { return _chains; } }

        public static List<Status> Statuses { get { return _statuses; } }

        public static List<State> States { get { return _states; } }

        public static List<User> Users { get { return _users; } }

    }
}
