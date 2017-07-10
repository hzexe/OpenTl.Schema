﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf35c6d01)]
	public class TRpcResult : IObject
	{
       [SerializationOrder(0)]
       public long ReqMsgId {get; set;}

       [SerializationOrder(1)]
       public IObject Result {get; set;}

	}
}