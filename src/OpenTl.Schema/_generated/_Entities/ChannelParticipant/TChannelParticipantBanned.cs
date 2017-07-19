﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x222c1886)]
	public class TChannelParticipantBanned : IChannelParticipant
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Left {get; set;}

       [SerializationOrder(2)]
       public int UserId {get; set;}

       [SerializationOrder(3)]
       public int KickedBy {get; set;}

       [SerializationOrder(4)]
       public int Date {get; set;}

       [SerializationOrder(5)]
       public IChannelBannedRights BannedRights {get; set;}

	}
}
