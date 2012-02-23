namespace Earth2Me.Concurrency.Delegation
{
	public enum OffsetAssociation : byte
	{
		/// <summary>
		/// Do not offset priority at all.  Use the current priority.  This is the default.
		/// </summary>
		// If this ever changes from zero, update the parameterless constructor
		// for PriorityOffset.
		None = 0,

		/// <summary>
		/// Offset relative to the current priority.  Positive numbers decrease the priority,
		/// and negative numbers increase the priority.
		/// </summary>
		Relative,

		/// <summary>
		/// Jump to the given priority.
		/// </summary>
		Absolute,

		/// <summary>
		/// Offset relative to the highest priority.  Positive numbers decrease the priority.
		/// Negative numbers are illegal.
		/// </summary>
		FromHighest,

		/// <summary>
		/// Offset relative to the lowest priority.  Positive numbers increase the priority.
		/// Negative numbers are illegal.
		/// </summary>
		FromLowest,
	}
}