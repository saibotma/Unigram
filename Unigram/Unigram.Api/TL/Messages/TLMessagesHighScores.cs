// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages
{
	public partial class TLMessagesHighScores : TLObject 
	{
		public TLVector<TLHighScore> Scores { get; set; }
		public TLVector<TLUserBase> Users { get; set; }

		public TLMessagesHighScores() { }
		public TLMessagesHighScores(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesHighScores; } }

		public override void Read(TLBinaryReader from)
		{
			Scores = TLFactory.Read<TLVector<TLHighScore>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Scores);
			to.WriteObject(Users);
		}
	}
}