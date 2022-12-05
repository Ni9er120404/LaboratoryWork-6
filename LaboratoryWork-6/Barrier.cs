using System;

namespace ProjectForTrainingFunction
{
	public class Barrier
	{
		public IBarrierState? State { get; set; }

		public Barrier(IBarrierState? state, Card? card)
		{
			if (card is not null)
			{
				State = state;
			}
			else
			{
				throw new Exception("Не вставлена карта");
			}
		}
		public string Open()
		{
			return State!.Open(this);
		}
		public string Close()
		{
			return State!.Close(this);
		}
	}
}