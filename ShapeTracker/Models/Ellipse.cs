namespace ShapeTracker.Models
{
	public class Ellipse
	{
		private int _rad1;
		private int _rad2;
public int Rad1 { get; set; }
public int Rad2 { get; }

		public Ellipse(int rad1, int rad2)
		{
			Rad1 = rad1;
      Rad2 = rad2;
    }
	}
}
