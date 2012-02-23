namespace Earth2Me.Concurrency.Delegation
{
	/// <summary>
	/// A task to be executed by a <seealso cref="TaskServer"/>.
	/// </summary>
	/// <param name="context">Reserved for future use.</param>
	/// <returns>The result of the task execution.</returns>
	public delegate TaskResult TaskCallback(TaskContext context);
}