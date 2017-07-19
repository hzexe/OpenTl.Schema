﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1b7907ae)]
	public class TChannelAdminLogEventActionToggleInvites : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public bool NewValue {get; set;}

	}
}
