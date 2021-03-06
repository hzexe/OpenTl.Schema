﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0x8b31c4f)]
	public sealed class TPageBlockCollage : IPageBlock
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPageBlock> Items {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IRichText Caption {get; set;}

	}
}
