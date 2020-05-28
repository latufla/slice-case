namespace BzKovSoft.ObjectSlicer.Samples
{
	public static class SliceIdProvider
	{
		static int _sliceId = 0;
		public static int GetNewSliceId()
		{
			return ++_sliceId;
		}
	}
}