﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x77eec38f)]
	public class TCdnFileHash : ICdnFileHash
	{
       [SerializationOrder(0)]
       public int Offset {get; set;}

       [SerializationOrder(1)]
       public int Limit {get; set;}

       [SerializationOrder(2)]
       public byte[] Hash {get; set;}

	}
}