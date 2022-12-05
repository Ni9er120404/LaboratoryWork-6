namespace ProjectForTrainingFunction
{
	public interface IBarrierState
	{
		public string Open(Barrier barrier);

		public string Close(Barrier barrier);
	}
}