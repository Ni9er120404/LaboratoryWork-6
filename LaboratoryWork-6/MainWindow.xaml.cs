using ProjectForTrainingFunction;
using System;
using System.Windows;

namespace LaboratoryWork_6
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public Barrier Barrier { get; set; } = null!;
		
		public Card Card { get; set; } = null!;

		private void ButtonToTake_Click(object sender, RoutedEventArgs e)
		{
			Card = new Card(Math.Abs(new Random().Next()).ToString());
		
			Barrier = new(new OpenState(), Card);
			
			Car car = new(new MovingInState(Barrier, Card), Card);

			TextBoxForState.AppendText($"{car.MovingIn()} {Barrier.Close()}");
		}

		private void ButtonToGive_Click(object sender, RoutedEventArgs e)
		{
			if (Card != null && Barrier != null)
			{
				Barrier.State = new CloseState();
				
				Car car = new(new MovingOutState(Barrier, Card), Card);

				TextBoxForState.AppendText($"{car.MovingOut()} {Barrier.Close()}");
			}
		}
	}
}