using System.Text;

namespace ProjectForTrainingFunction
{
	public class CloseState : IBarrierState
	{
		public string Open(Barrier barrier)
		{
			StringBuilder state = new("\nШлагбаум открыт\n");
			return state.ToString();
		}

		public string Close(Barrier barrier)
		{
			StringBuilder state = new("Шлагбаум Закрывается\n");
			barrier.State = new OpenState();
			return state.ToString();
		}
	}
}