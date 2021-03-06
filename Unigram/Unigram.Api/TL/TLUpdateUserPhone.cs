// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdateUserPhone : TLUpdateBase 
	{
		public Int32 UserId { get; set; }
		public String Phone { get; set; }

		public TLUpdateUserPhone() { }
		public TLUpdateUserPhone(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateUserPhone; } }

		public override void Read(TLBinaryReader from)
		{
			UserId = from.ReadInt32();
			Phone = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(UserId);
			to.WriteString(Phone ?? string.Empty);
		}
	}
}