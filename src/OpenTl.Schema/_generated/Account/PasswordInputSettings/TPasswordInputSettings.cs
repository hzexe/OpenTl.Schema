﻿// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x21ffa60d)]
	public sealed class TPasswordInputSettings : IPasswordInputSettings
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public byte[] NewSalt {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public byte[] NewPasswordHash {get; set;}

       /// <summary>Binary representation for the 'Hint' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public byte[] HintAsBinary { get => _HintAsBinary; set { _Hint = Encoding.UTF8.GetString(value); _HintAsBinary = value; }}
       private byte[] _HintAsBinary;
       private string _Hint;
       public string Hint { get => _Hint; set { HintAsBinary = Encoding.UTF8.GetBytes(value); _Hint = value; }}

       /// <summary>Binary representation for the 'Email' property</summary>
       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public byte[] EmailAsBinary { get => _EmailAsBinary; set { _Email = Encoding.UTF8.GetString(value); _EmailAsBinary = value; }}
       private byte[] _EmailAsBinary;
       private string _Email;
       public string Email { get => _Email; set { EmailAsBinary = Encoding.UTF8.GetBytes(value); _Email = value; }}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 2)]
       public byte[] NewSecureSalt {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 2)]
       public byte[] NewSecureSecret {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 2)]
       public long NewSecureSecretId {get; set;}

	}
}
