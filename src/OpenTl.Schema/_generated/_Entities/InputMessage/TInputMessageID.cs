﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0xa676a322)]
	public sealed class TInputMessageID : IInputMessage
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

	}
}
