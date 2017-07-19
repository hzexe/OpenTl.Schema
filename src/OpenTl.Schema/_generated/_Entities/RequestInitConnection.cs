﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc7481da6)]
    public class RequestInitConnection : IRequest<IObject>
    {
       [SerializationOrder(0)]
       public int ApiId {get; set;}

       [SerializationOrder(1)]
       public string DeviceModel {get; set;}

       [SerializationOrder(2)]
       public string SystemVersion {get; set;}

       [SerializationOrder(3)]
       public string AppVersion {get; set;}

       [SerializationOrder(4)]
       public string SystemLangCode {get; set;}

       [SerializationOrder(5)]
       public string LangPack {get; set;}

       [SerializationOrder(6)]
       public string LangCode {get; set;}

       [SerializationOrder(7)]
       public IObject Query {get; set;}

    }
}
