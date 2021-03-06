// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Account.Methods
{
	/// <summary>
	/// RCP method account.updateProfile.
	/// Returns <see cref="Telegram.Api.TL.TLUserBase"/>
	/// </summary>
	public partial class TLAccountUpdateProfile : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			FirstName = (1 << 0),
			LastName = (1 << 1),
			About = (1 << 2),
		}

		public bool HasFirstName { get { return Flags.HasFlag(Flag.FirstName); } set { Flags = value ? (Flags | Flag.FirstName) : (Flags & ~Flag.FirstName); } }
		public bool HasLastName { get { return Flags.HasFlag(Flag.LastName); } set { Flags = value ? (Flags | Flag.LastName) : (Flags & ~Flag.LastName); } }
		public bool HasAbout { get { return Flags.HasFlag(Flag.About); } set { Flags = value ? (Flags | Flag.About) : (Flags & ~Flag.About); } }

		public Flag Flags { get; set; }
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public String About { get; set; }

		public TLAccountUpdateProfile() { }
		public TLAccountUpdateProfile(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountUpdateProfile; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			if (HasFirstName) FirstName = from.ReadString();
			if (HasLastName) LastName = from.ReadString();
			if (HasAbout) About = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			if (HasFirstName) to.WriteString(FirstName ?? string.Empty);
			if (HasLastName) to.WriteString(LastName ?? string.Empty);
			if (HasAbout) to.WriteString(About ?? string.Empty);
		}

		private void UpdateFlags()
		{
			HasFirstName = FirstName != null;
			HasLastName = LastName != null;
			HasAbout = About != null;
		}
	}
}