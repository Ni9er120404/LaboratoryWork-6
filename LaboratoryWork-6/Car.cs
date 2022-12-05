using System;

namespace ProjectForTrainingFunction
{
	public class Car
	{
		public ICarState State { get; set; }

		public Car(ICarState state, Card card)
		{
			if (card is not null)
			{
				State = state;
			}
			else
			{
				throw new Exception("Вы не взяли карту");
			}
		}

		public string MovingIn()
		{
			return State.MovingIn(this);
		}

		public string MovingOut()
		{
			return State.MovingOut(this);
		}
	}
}