﻿using CSharpPaxosRuntime.Messaging;
using CSharpPaxosRuntime.Messaging.Bus;
using CSharpPaxosRuntime.Models.Properties;

namespace CSharpPaxosRuntime.Models.PaxosSpecificMessageTypes
{
    public class VoteResponse : IDecisionMessage
    {
        public BallotNumber BallotNumber
        {
            get;
            set;
        }

        public MessageSender MessageSender
        {
            get;
            set;
        }

        public int SlotNumber
        {
            get;
            set;
        }

        public VoteStatus VoteStatus
        {
            get;
            set;
        }

        public ICommand Command
        {
            get;
            set;
        }
    }
}