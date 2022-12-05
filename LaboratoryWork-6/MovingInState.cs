using System;
using System.Text;

namespace ProjectForTrainingFunction
{
	public class MovingInState : ICarState
	{
		public Barrier Barrier { get; private set; }

		public Card? Card { get; private set; }

		public MovingInState(Barrier barrier, Card card)
		{
			Barrier = barrier;
			Card = card;
		}

		public string MovingIn(Car car)
		{
			if (Card != null)
			{
				StringBuilder state = new(Barrier.Open());
				_ = state.Append("\nМашина въезжает\n");
				car.State = new MovingOutState(Barrier, Card);
				return state.ToString();
			}
			else
			{
				throw new Exception("Вставьте пожалуйста карту для открытия шлагбаума и вьезда внутрь");
			}
		}

		public string MovingOut(Car car)
		{
			if (Card != null)
			{
				StringBuilder state = new(Barrier.Close());
				_ = state.Append("\nМашина выезжает\n");
				return state.ToString();
			}
			else
			{
				throw new Exception("Вставьте пожалуйста карту для открытия шлагбаума и вьезда внутрь");
			}
		}
	}
}