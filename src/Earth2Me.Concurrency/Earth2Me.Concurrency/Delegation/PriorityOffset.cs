using System;

namespace Earth2Me.Concurrency.Delegation
{
	/// <summary>
	/// Represents a relative or absolute offset from a task's original priority.
	/// </summary>
	public sealed class PriorityOffset
	{
		/// <summary>
		/// Gets whether the offset is relative or absolute.
		/// </summary>
		public OffsetAssociation Association { get; private set; }

		/// <summary>
		/// Gets the actual offset.
		/// </summary>
		public int Offset { get; private set; }

		/// <summary>
		/// Instantiates a new priority offset defaulting to none.
		/// </summary>
		public PriorityOffset()
		{
			// Intentionally blank.
		}

		/// <summary>
		/// Instantiates a new priority offset with the specified values.
		/// </summary>
		/// <param name="association">Whether the offset is relative or absolute.</param>
		/// <param name="offset">The actual offset, as per the association.</param>
		public PriorityOffset(OffsetAssociation association, int offset)
		{
			Association = association;
			Offset = offset;
		}

		public int Apply(int lowest, int current)
		{
			// Bounds checking.
			if (lowest < 0)
			{
				throw new ArgumentOutOfRangeException("lowest", "lowest must be greater than or equal to zero.");
			}
			if (current > lowest || current < 0)
			{
				throw new ArgumentOutOfRangeException("current", "current must be between zero and lowest.");
			}

			int retval;
			switch (Association)
			{
			case OffsetAssociation.None:
				return current;

			case OffsetAssociation.FromHighest:
			case OffsetAssociation.Absolute:
				retval = Offset;
				break;

			case OffsetAssociation.FromLowest:
				retval = lowest - Offset;
				break;

			case OffsetAssociation.Relative:
				retval = current + Offset;
				break;

			default:
				throw new InvalidOperationException("The Association property for the current PriorityOffset object is invalid.");
			}

			// Bounds check.  Do not throw exceptions, since tasks might recursively decrease
			// or increase their priority.
			if (retval < 0)
			{
				retval = 0;
			}
			if (retval > lowest)
			{
				retval = lowest;
			}

			return retval;
		}
	}
}