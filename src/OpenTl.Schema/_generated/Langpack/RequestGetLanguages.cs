﻿// ReSharper disable All

namespace OpenTl.Schema.Langpack
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x800fd57d)]
    public class RequestGetLanguages : IRequest<TVector<TLangPackLanguage>>
    {

    }
}