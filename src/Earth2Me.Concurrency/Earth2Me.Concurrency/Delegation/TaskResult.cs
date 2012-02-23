namespace Earth2Me.Concurrency.Delegation
{
	/// <summary>
	/// The result of a task execution.
	/// </summary>
	public sealed class TaskResult
	{
		/// <summary>
		/// Gets when the task should be repeated, if at all.
		/// </summary>
		public TaskRepeat Repeat { get; private set; }

		/// <summary>
		/// Gets the priority at which the task should be repeated.
		/// </summary>
		public PriorityOffset Priority { get; private set; }

		/// <summary>
		/// Instantiates a new <see cref="TaskResult"/> object.
		/// </summary>
		/// <param name="repeat">When the the associated task should be repeated, if at all.</param>
		/// <param name="priority">The new priority for the repeated task.</param>
		public TaskResult(TaskRepeat repeat, PriorityOffset priority)
		{
			Repeat = repeat;
			Priority = priority;
		}
	}
}