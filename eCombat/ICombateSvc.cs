﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eCombat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICombateSvc" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface ICombateSvc
    {
        [OperationContract(IsOneWay = true, IsInitiating = true, IsTerminating = false)]
        void StartMatch(string opponentName, string opponentId, bool isOpponentTurn);

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = true)]
        void CancelMatch(bool isWorthPoints);

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
        void MoveBoardPiece(int srcX, int srcY, int destX, int destY, bool isOpponentTurn);

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
        void AttackBoardPiece(int srcX, int srcY, int destX, int destY,
            string attackerPowerLevel, string defenderPowerLevel, bool isOpponentTurn);

        [OperationContract(IsInitiating = false, IsTerminating = false)]
        string ShowPowerLevel(int srcX, int srcY);
    }
}
