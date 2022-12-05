using System;
using System.Text;

namespace ProjectForTrainingFunction
{
	public class MovingOutState : ICarState
	{
		public Barrier Barrier { get; private set; }

		public Card? Card { get; private set; }

		public MovingOutState(Barrier barrier, Card? card)
		{
			Barrier = barrier;
			Card = card;
		}

		public string MovingIn(Car car)
		{
			if (Card != null)
			{
				StringBuilder state = new(Barrier.Open());
				state.Append("\nМашина въезжает\n");
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
				StringBuilder state = new(Barrier.Open());
				state.Append("\nМашина Выезжает\n");
				car.State = new MovingInState(Barrier, Card);
				return state.ToString();
			}
			else
			{
				throw new Exception("Вставьте пожалуйста карту для открытия шлагбаума и вьезда внутрь");
			}
		}
	}
}