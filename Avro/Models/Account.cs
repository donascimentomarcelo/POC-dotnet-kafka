// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.7.7.5
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Avro.Models
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using global::Avro;
	using global::Avro.Specific;

	public class Account : Avro.Specific.ISpecificProtocol
	{
		private static readonly Avro.Protocol protocol = Avro.Protocol.Parse("{\"protocol\":\"Account\",\"namespace\":\"Avro.Models\",\"types\":[],\"messages\":{}}");

		private string _Number;
		private double _Balance;
		public Avro.Protocol Protocol
		{
			get
			{
				return protocol;
			}
		}

		public string Number
		{
			get
			{
				return this._Number;
			}
			set
			{
				this._Number = value;
			}
		}
		public double Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				this._Balance = value;
			}
		}
		public void Request(Avro.Specific.ICallbackRequestor requestor, string messageName, object[] args, object callback)
		{
			;
		}
	}
}