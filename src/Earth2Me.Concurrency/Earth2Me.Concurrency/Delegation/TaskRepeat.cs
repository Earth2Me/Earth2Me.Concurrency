namespace Earth2Me.Concurrency.Delegation
{
	/// <summary>
	/// Describes if and when a task should repeat.
	/// </summary>
	public enum TaskRepeat : byte
	{
		/// <summary>
		/// Do not repeat the task.
		/// </summary>
		NoRepeat,

		/// <summary>
		/// Repeat the task immediately once all tasks higher than the specified priority
		/// level are in progress.  Tasks given this status are executed on a first-come,
		/// first serve basis.  This essentially acts as an intermediate priority level that
		/// is half a step higher than the specified level.
		/// </summary>
		RepeatImmediately,

		/// <summary>
		/// Enqueue this task at the specified priority level.
		/// </summary>
		RepeatPassively,
	}
}