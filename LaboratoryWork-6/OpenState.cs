namespace ProjectForTrainingFunction
{
	public class OpenState : IBarrierState
	{
		public string Open(Barrier barrier)
		{
			string state = "\nШлагбаум Открывается\n";
			barrier.State = new CloseState();
			return state;

		}

		public string Close(Barrier barrier)
		{
			string state = "\nШлагбаум закрывается\n";
			return state;
		}
	}
}